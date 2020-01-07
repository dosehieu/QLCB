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
    public class ReportCBKyLuatsController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public ReportCBKyLuatsController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }

        // GET: ReportCBKyLuats
        public async Task<IActionResult> Index()
        {
            return View(GetListKyLuat());
        }

        public List<ReportCBKyLuat> GetListKyLuat()
        {
            List<ReportCBKyLuat> lts = new List<ReportCBKyLuat>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var Year = DateTime.Now.Year;
                con.Open();

                SqlCommand cmd = new SqlCommand("CanBo_KyLuatNEW", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@iYear", SqlDbType.Int).Value = Year;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ReportCBKyLuat obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ReportCBKyLuat();
                        obj.DonVi = dt.Rows[i]["DonVi"].ToString();
                        obj.TenTrinhDo = dt.Rows[i]["TenTrinhDo"].ToString();
                        obj.KieuCanBo = dt.Rows[i]["KieuCanBo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["KieuCanBo"].ToString());
                        obj.ChucVuSTT = dt.Rows[i]["ChucVuSTT"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ChucVuSTT"].ToString());
                        obj.TenKieuCanBo = dt.Rows[i]["TenKieuCanBo"].ToString();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.CanBoID = dt.Rows[i]["CanBoID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CanBoID"].ToString());
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.NgaySinh = dt.Rows[i]["NgaySinh"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                        obj.GioiTinh = dt.Rows[i]["GioiTinh"].ToString().Equals("") ? (bool?)null : bool.Parse(dt.Rows[i]["GioiTinh"].ToString());
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.TenPhongBan = dt.Rows[i]["TenPhongBan"].ToString();
                        obj.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                        obj.ChucVuID = dt.Rows[i]["ChucVuID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ChucVuID"].ToString());
                        obj.NoiDung = dt.Rows[i]["NoiDung"].ToString();
                        obj.HinhThucKyLuat = dt.Rows[i]["HinhThucKyLuat"].ToString();
                        obj.RegionID = dt.Rows[i]["RegionID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["RegionID"].ToString());
                        obj.Nam = dt.Rows[i]["Nam"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nam"].ToString());
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }
    }
}
