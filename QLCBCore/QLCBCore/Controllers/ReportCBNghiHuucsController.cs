using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using QLCBCore.Models;
using QLCBCore.Models.BaoCao;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    public class ReportCBNghiHuucsController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public ReportCBNghiHuucsController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }

        // GET: ReportCBNghiHuucs
        public async Task<IActionResult> Index()
        {
            return View(GetListNghiHuu());
        }

        public List<ReportCBNghiHuucs> GetListNghiHuu()
        {
            List<ReportCBNghiHuucs> lts = new List<ReportCBNghiHuucs>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var Date = DateTime.Now;
                con.Open();

                SqlCommand cmd = new SqlCommand("RP_CBNH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Date;
                cmd.Parameters.Add("@KieuCB", SqlDbType.Int).Value = 10;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ReportCBNghiHuucs obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ReportCBNghiHuucs();
                        obj.TenDonVi = dt.Rows[i]["STTChucVu"].ToString();
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.NgaySinh_Nam = dt.Rows[i]["NgaySinh_Nam"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgaySinh_Nam"].ToString());
                        obj.NgayThongBaoNghiHuu = dt.Rows[i]["NgayThongBaoNghiHuu"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgayThongBaoNghiHuu"].ToString());
                        obj.NgayNghiHuu = dt.Rows[i]["NgayNghiHuu"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgayNghiHuu"].ToString());
                        obj.NgaySinh_Nu = dt.Rows[i]["NgaySinh_Nu"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgaySinh_Nu"].ToString());
                        obj.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                        obj.MaNgach = dt.Rows[i]["MaNgach"].ToString();
                        obj.HeSo = dt.Rows[i]["HeSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["HeSo"].ToString()); ;
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString()); ;
                        obj.DonViID = dt.Rows[i]["DonViID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["DonViID"].ToString()); ;
                    }
                }
                return lts;
            }
        }

    }
}
