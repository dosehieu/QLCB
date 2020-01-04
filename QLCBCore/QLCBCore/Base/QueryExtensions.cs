using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace QLCBCore.Base
{
    public static class QueryExtensions
    {
        public static string ToJson(this object source)
        {
            return JsonConvert.SerializeObject(source);
        }
        //Sort dmBangLuongCoSo
        public static IQueryable<T> SortPagings<T>(this IQueryable<T> source, int RowPerPage, int CurrentPage, string Keyword, List<string> SearchInField, ref int totalRecord)
        {
            Expression methodCallExpression = source.Expression;
            string propertyName;
            string methodName;
            ParameterExpression parameter;
            MemberExpression property;
            LambdaExpression lambda;

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        methodCallExpression, Expression.Quote(predicate));
            }
            //#region dùng cho việc Order
            //if (string.IsNullOrEmpty(FieldSort))
            //{
            //    FieldSort = source.ElementType.GetProperties()[0].Name;
            //    FieldOption = true;
            //}
            //propertyName = FieldSort;
            //methodName = (FieldOption) ? "OrderByDescending" : "OrderBy";

            //parameter = Expression.Parameter(source.ElementType, String.Empty);
            //property = Expression.Property(parameter, propertyName);
            //lambda = Expression.Lambda(property, parameter);
            //methodCallExpression = Expression.Call(typeof(Queryable), methodName,
            //                                new[] { typeof(T), property.Type },
            //                                methodCallExpression, Expression.Quote(lambda));

            //source = source.Provider.CreateQuery<T>(methodCallExpression);
            //#endregion

            totalRecord = source.Count();

            if (CurrentPage > 0 && RowPerPage > 0)
            {
                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Skip",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant((CurrentPage - 1) * RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);

                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Take",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant(RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);
            }
            return source;
        }

        /// <summary>
        /// Truy vấn Order by
        /// Source.EditByMe
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        /// 

        public static IQueryable<T> SortBy<T>(this IQueryable<T> source, string propertyName)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            // DataSource control passes the sort parameter with a direction
            // if the direction is descending          
            int descIndex = propertyName.IndexOf(" DESC");
            if (descIndex >= 0)
            {
                propertyName = propertyName.Substring(0, descIndex).Trim();
            }

            if (String.IsNullOrEmpty(propertyName))
            {
                return source;
            }

            ParameterExpression parameter = Expression.Parameter(source.ElementType, String.Empty);
            MemberExpression property = Expression.Property(parameter, propertyName);
            LambdaExpression lambda = Expression.Lambda(property, parameter);

            string methodName = (descIndex < 0) ? "OrderBy" : "OrderByDescending";

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                                new Type[] { source.ElementType, property.Type },
                                                source.Expression, Expression.Quote(lambda));
            return source.Provider.CreateQuery<T>(methodCallExpression);
        }

        
        public static IQueryable<T> Has<T>(this IQueryable<T> source, List<string> SearchInField, string Keyword)
        {
            if (source == null || !SearchInField.Any() || SearchInField == null || string.IsNullOrEmpty(Keyword))
            {
                return source;
            }
            Keyword = Keyword.ToLower();
            Expression methodCallExpression = source.Expression;
            ParameterExpression parameter;
            MemberExpression property;

            if (SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        methodCallExpression, Expression.Quote(predicate));


                return source.Provider.CreateQuery<T>(methodCallExpression);
            }
            else { return source; }
        }


        /// <summary>
        /// Hàm lấy qua GridRequest
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static IQueryable<T> SortPaging<T>(this IQueryable<T> source, string FieldSort, bool FieldOption, int RowPerPage, int CurrentPage, string Keyword, List<string> SearchInField, ref int totalRecord)
        {
            Expression methodCallExpression = source.Expression;
            string propertyName;
            string methodName;
            ParameterExpression parameter;
            MemberExpression property;
            LambdaExpression lambda;

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        methodCallExpression, Expression.Quote(predicate));
            }
            #region dùng cho việc Order
            if (string.IsNullOrEmpty(FieldSort))
            {
                FieldSort = source.ElementType.GetProperties()[0].Name;
                FieldOption = true;
            }
            propertyName = FieldSort;
            methodName = (FieldOption) ? "OrderByDescending" : "OrderBy";

            parameter = Expression.Parameter(source.ElementType, String.Empty);
            property = Expression.Property(parameter, propertyName);
            lambda = Expression.Lambda(property, parameter);
            methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                            new[] { typeof(T), property.Type },
                                            methodCallExpression, Expression.Quote(lambda));

            source = source.Provider.CreateQuery<T>(methodCallExpression);
            #endregion

            totalRecord = source.Count();

            if (CurrentPage > 0 && RowPerPage > 0)
            {
                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Skip",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant((CurrentPage - 1) * RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);

                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Take",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant(RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);
            }
            return source;
        }

        /// <summary>
        /// Hàm lấy qua GridRequest
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static IQueryable<T> SortPagingQHGD<T>(this IQueryable<T> source, string FieldSort, bool FieldOption, int RowPerPage, int CurrentPage, string Keyword, List<string> SearchInField, ref int totalRecord)
        {
            Expression methodCallExpression = source.Expression;
            string propertyName;
            string methodName;
            ParameterExpression parameter;
            MemberExpression property;
            LambdaExpression lambda;

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        methodCallExpression, Expression.Quote(predicate));
            }
            #region dùng cho việc Order
            if (!string.IsNullOrEmpty(FieldSort))
            {
                propertyName = FieldSort;
                methodName = (FieldOption) ? "OrderByDescending" : "OrderBy";

                parameter = Expression.Parameter(source.ElementType, String.Empty);
                property = Expression.Property(parameter, propertyName);
                lambda = Expression.Lambda(property, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                                new[] { typeof(T), property.Type },
                                                methodCallExpression, Expression.Quote(lambda));
                source = source.Provider.CreateQuery<T>(methodCallExpression);
            }
            #endregion

            totalRecord = source.Count();

            if (CurrentPage > 0 && RowPerPage > 0)
            {
                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Skip",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant((CurrentPage - 1) * RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);

                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Take",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant(RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);
            }
            return source;
        }


        /// <summary>
        /// Hàm lấy qua GridRequest
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static IQueryable<T> SortPaging<T>(this IQueryable<T> source, string FieldSort, bool FieldOption, string Keyword, List<string> SearchInField, ref int totalRecord)
        {
            Expression methodCallExpression = source.Expression;
            string propertyName;
            string methodName;
            ParameterExpression parameter;
            MemberExpression property;
            LambdaExpression lambda;

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (!string.IsNullOrEmpty(Keyword) && SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(Keyword, typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(Keyword, typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        source.Expression, Expression.Quote(predicate));
            }
            #region dùng cho việc Order
            if (string.IsNullOrEmpty(FieldSort))
            {
                FieldSort = source.ElementType.GetProperties()[0].Name;
                FieldOption = true;
            }

            propertyName = FieldSort;
            methodName = (FieldOption) ? "OrderByDescending" : "OrderBy";

            parameter = Expression.Parameter(source.ElementType, String.Empty);
            property = Expression.Property(parameter, propertyName);
            lambda = Expression.Lambda(property, parameter);
            methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                            new Type[] { source.ElementType, property.Type },
                                            methodCallExpression, Expression.Quote(lambda));
            source = source.Provider.CreateQuery<T>(methodCallExpression);
            #endregion

            totalRecord = source.Count();


            return source;
        }

        public static IQueryable<T> SortPagingCanBo<T>(this IQueryable<T> source, string FieldSort, bool FieldOption, int RowPerPage, int CurrentPage, string Keyword, List<string> SearchInField, ref int totalRecord)
        {
            Expression methodCallExpression = source.Expression;
            string propertyName;
            string methodName;
            ParameterExpression parameter;
            MemberExpression property;
            LambdaExpression lambda;

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(string.IsNullOrEmpty(Keyword) ? string.Empty : Keyword.ToLower(), typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        methodCallExpression, Expression.Quote(predicate));
            }
            #region dùng cho việc Order
            if (string.IsNullOrEmpty(FieldSort))
            {
                FieldSort = source.ElementType.GetProperties()[0].Name;
                FieldOption = true;
            }
            methodName = (FieldOption) ? "OrderByDescending" : "OrderBy";
            propertyName = FieldSort.Equals("ID") ? "STTDonVi" : FieldSort;
            if (propertyName.Equals("STTDonVi"))
            {
                methodName = (FieldOption) ? "OrderBy" : "OrderByDescending";
            }

            parameter = Expression.Parameter(source.ElementType, String.Empty);
            property = Expression.Property(parameter, propertyName);
            lambda = Expression.Lambda(property, parameter);
            methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                            new[] { typeof(T), property.Type },
                                            methodCallExpression, Expression.Quote(lambda));

            source = source.Provider.CreateQuery<T>(methodCallExpression);
            #endregion

            totalRecord = source.Count();

            if (CurrentPage > 0 && RowPerPage > 0)
            {
                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Skip",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant((CurrentPage - 1) * RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);

                methodCallExpression = Expression.Call(
                    typeof(Queryable), "Take",
                    new[] { typeof(T) },
                    methodCallExpression, Expression.Constant(RowPerPage));
                source = source.Provider.CreateQuery<T>(methodCallExpression);
            }
            return source;
        }

        /// <summary>
        /// Hàm lấy qua GridRequest
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static IQueryable<T> Has<T>(this IQueryable<T> source, string Keyword, List<string> SearchInField, ref int totalRecord)
        {
            Expression methodCallExpression = source.Expression;

            ParameterExpression parameter;
            MemberExpression property;


            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (!string.IsNullOrEmpty(Keyword) && SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(Keyword, typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(Keyword, typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        source.Expression, Expression.Quote(predicate));
            }

            totalRecord = source.Count();


            return source;
        }
        /// <summary>
        /// Search keyword in search in field
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertyName"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static IQueryable<T> Has<T>(this IQueryable<T> source, string propertyName, string keyword)
        {
            if (source == null || string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(keyword))
            {
                return source;
            }
            keyword = keyword.ToLower();

            var parameter = Expression.Parameter(source.ElementType, String.Empty);
            var property = Expression.Property(parameter, propertyName);
            var CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });

            var toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
            var termConstant = Expression.Constant(keyword, typeof(string));
            var containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);

            var predicate = Expression.Lambda<Func<T, bool>>(containsExpression, parameter);

            var methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        source.Expression, Expression.Quote(predicate));


            return source.Provider.CreateQuery<T>(methodCallExpression);
        }
        public static IQueryable<T> SortPagingP<T>(this IQueryable<T> source, string Keyword, List<string> SearchInField)
        {
            Expression methodCallExpression = source.Expression;
            //  string propertyName;
            // string methodName;
            ParameterExpression parameter;
            MemberExpression property;
            //    LambdaExpression lambda;

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (!string.IsNullOrEmpty(Keyword) && SearchInField.Count > 0)
            {
                parameter = Expression.Parameter(source.ElementType, String.Empty);
                System.Reflection.MethodInfo CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });//.Contains()
                System.Reflection.MethodInfo TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });//.ToLower();
                Expression toLowerExpression = null;
                Expression termConstant = null;
                Expression containsExpression = null;
                Expression orExpression = null;
                Expression predicate = null;
                int indexField = 0;

                foreach (var propSearch in SearchInField)
                {
                    indexField++;
                    if (indexField == 1) //Nếu là đầu tiên
                    {
                        property = Expression.Property(parameter, propSearch); // o.Ten
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD); // o.Ten.ToLower()
                        termConstant = Expression.Constant(Keyword, typeof(string)); //.Contains(Keyword);
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);// o.Ten.ToLower().Contains(Keyword);
                        orExpression = containsExpression;// o.Ten.ToLower().Contains(Keyword);
                    }
                    else
                    {
                        property = Expression.Property(parameter, propSearch);
                        toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                        termConstant = Expression.Constant(Keyword, typeof(string));
                        containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                        orExpression = Expression.OrElse(containsExpression, orExpression); // o.Ten.ToLower().Contains(Keyword) || ;
                    }
                }
                predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameter);
                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                        new Type[] { source.ElementType },
                                        source.Expression, Expression.Quote(predicate));
            }
            return source;
        }


        #region MyRegion
        
        private static Expression Equals(Expression memberExpression,
                                      ConstantExpression constantToCompare)
        {
            var hasValueExpression = Expression.Property(memberExpression, "HasValue");
            var valueExpression = Expression.Property(memberExpression, "Value");
            var Equal = Expression.Equal(valueExpression, constantToCompare);
            return Expression.AndAlso(hasValueExpression, Equal);
        }
        public static IQueryable<T> HasCustom<T>(this IQueryable<T> source, string propertyName, string keyword)
        {
            if (source == null || string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(keyword))
            {
                return source;
            }
            keyword = keyword.ToLower();

            var parameter = Expression.Parameter(source.ElementType, String.Empty);
            var property = Expression.Property(parameter, propertyName);
            var CONTAINS_METHOD = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var TO_LOWER_METHOD = typeof(string).GetMethod("ToLower", new Type[] { });
            var typeProperty = property.Type.FullName;

            MethodCallExpression toLowerExpression = null;
            var termConstant = Expression.Constant(keyword, typeof(string));

            MethodCallExpression containsExpression = null;

            MethodCallExpression methodCallExpression = null;
            if (typeProperty == "System.String")
            {
                toLowerExpression = Expression.Call(property, TO_LOWER_METHOD);
                containsExpression = Expression.Call(toLowerExpression, CONTAINS_METHOD, termConstant);
                var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                            new Type[] { source.ElementType },
                                            source.Expression, Expression.Quote(predicate));
            }
            else if (typeProperty == "System.Int16")
            {
                try
                {
                    var keywordInt = Convert.ToInt16(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(Int16));
                    CONTAINS_METHOD = typeof(Int16).GetMethod("Equals", new[] { typeof(Int16) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Int16") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToInt16(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(Int16));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty == "System.Int32")
            {
                try
                {
                    var keywordInt = Convert.ToInt32(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(int));
                    CONTAINS_METHOD = typeof(int).GetMethod("Equals", new[] { typeof(int) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Int32") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToInt32(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(int));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty == "System.Int64")
            {
                try
                {
                    var keywordInt = Convert.ToInt64(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(Int64));
                    CONTAINS_METHOD = typeof(Int64).GetMethod("Equals", new[] { typeof(Int64) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch
                {
                    return Enumerable.Empty<T>().AsQueryable();
                }
            }
            else if (typeProperty.Contains("System.Int64") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToInt64(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(Int64));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch
                {
                    return Enumerable.Empty<T>().AsQueryable();
                }
            }
            else if (typeProperty == "System.Decimal")
            {
                try
                {
                    var keywordInt = Convert.ToDecimal(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(decimal));
                    CONTAINS_METHOD = typeof(decimal).GetMethod("Equals", new[] { typeof(decimal) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Decimal") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToDecimal(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(decimal));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            //System.boolean
            else if (typeProperty == "System.Boolean")
            {
                try
                {
                    var keywordInt = Convert.ToBoolean(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(bool));
                    CONTAINS_METHOD = typeof(bool).GetMethod("Equals", new[] { typeof(bool) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Boolean") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToBoolean(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(bool));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty == "System.Double")
            {
                try
                {
                    var keywordInt = Convert.ToDouble(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(Double));
                    CONTAINS_METHOD = typeof(Double).GetMethod("Equals", new[] { typeof(Double) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Double") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToDouble(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(double));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Single") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToSingle(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(float));
                    var Equal = Equals(property, termConstant);
                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            //System.Single
            else if (typeProperty == "System.DateTime")
            {
                try
                {
                    var keywordInt = Convert.ToDateTime(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(DateTime));
                    CONTAINS_METHOD = typeof(DateTime).GetMethod("Equals", new[] { typeof(DateTime) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.DateTime") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToDateTime(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(DateTime));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty == "System.Byte")
            {
                try
                {
                    var keywordInt = Convert.ToByte(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(Byte));
                    CONTAINS_METHOD = typeof(Byte).GetMethod("Equals", new[] { typeof(Byte) });
                    containsExpression = Expression.Call(property, CONTAINS_METHOD, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    containsExpression, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }
            else if (typeProperty.Contains("System.Byte") && typeProperty.Contains("System.Nullable"))
            {
                try
                {
                    var keywordInt = Convert.ToByte(keyword);
                    termConstant = Expression.Constant(keywordInt, typeof(byte));
                    var Equal = Equals(property, termConstant);

                    var predicate = Expression.Lambda<Func<T, bool>>(
                    Equal, parameter);

                    methodCallExpression = Expression.Call(typeof(Queryable), "Where",
                                                new Type[] { source.ElementType },
                                                source.Expression, Expression.Quote(predicate));
                }
                catch (Exception ex) { source = Enumerable.Empty<T>().AsQueryable(); }
            }


            try
            {
                source = source.Provider.CreateQuery<T>(methodCallExpression);
            }
            catch (Exception ex)
            {
                source = Enumerable.Empty<T>().AsQueryable();
            }
            return source;
        }
        #endregion

    }
}
