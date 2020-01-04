using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QLCBCore.Base
{
    public abstract partial class BaseController : Controller
    {
        public int _Page = 1;
        public int _RowPerPage = 10;
        public string _Field;
        public int TotalRecord = 0;
        public bool _FieldOption;
        public string _Filter;
        public string HtmlPager;
        ///<summary>
        /// Nối Custom Param vào Url phân trang
        ///</summary>
        public string _Request ="";
        public int ID_DonVi;
        public void SetHtmlPager(int TotalRecord)
        {
            if(string.IsNullOrEmpty(_Request))
            {
                _Request += "&";
            }
            HtmlPager = QLCBCore.Base.HtmlPager.getPage(
                   string.Format("?Field={0}&{1}FieldOption={2}{3}&Page=",
                   _Field, _Request, (_FieldOption) ? 0 : 1, _Filter), _Page, _RowPerPage, TotalRecord);
            //HtmlPager = QLCBCore.Utils.HtmlPager.getPage(
            //       string.Format("?ID_DonVi=" + ID_DonVi + "&Field={0}&FieldOption={1}{2}&Page=",
            //       Field, (FieldOption) ? 0 : 1, filter), _Page, _RowPerPage, TotalRecord);
        }
        public void SetPage (int? page, int? RowPerPage , string Field, bool FieldOption, string Filter)
        {
            _Page = page?? _Page;
            _RowPerPage = RowPerPage?? _RowPerPage;
            _Field = Field;
            _FieldOption = FieldOption;
            _Filter = Filter;
        }

    }
}