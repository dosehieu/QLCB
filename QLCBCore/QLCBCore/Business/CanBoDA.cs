using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;
using QLCBCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Threading.Tasks;

namespace QLCBCore.Business
{
    
    public class CanBoDA
    {
        private readonly QLCBDbContext _context;

        public CanBoDA(QLCBDbContext context)
        {
            _context = context;
        }
        public List<CanBoVM> GetListCB(int CurrentPage, int PageSize, string Field, bool FieldOption, string Keyword, List<string> SearchInField, int ID_DonVi, HttpRequest requests, bool? IsAll = null)
        {
            List<CanBoVM> lts = new List<CanBoVM>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString))
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("[GET_ListCanBo]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DonViID", SqlDbType.Int).Value = ID_DonVi;

                CanBoVM obj;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)// lấy list theo current page
                    {
                        obj = new CanBoVM();
                        obj.ID = int.Parse(dt.Rows[i]["CanBoID"].ToString().Equals("") ? "0" : dt.Rows[i]["CanBoID"].ToString());
                        obj.Ma = dt.Rows[i]["Ma"].ToString();
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.NgaySinh = dt.Rows[i]["NgaySinh"].ToString().Equals("") ? string.Empty : DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                        obj.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.TenKieuCanBo = dt.Rows[i]["TenKieuCanBo"].ToString();
                        obj.TenTrinhDo = dt.Rows[i]["TenTrinhDo"].ToString();
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }
    }
}
