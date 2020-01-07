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
    public class ReportCBThiDuaController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public ReportCBThiDuaController(QLCBDbContext context, IOptions<ConnectionString> config)
        {

            _context = context;
            this.config = config;
        }

        // GET: ReportCBThiDua
        public async Task<IActionResult> Index()
        {
            return View(GetListThiDua());
        }

        public async Task<IActionResult> Index2()
        {
            return View(GetListKhenThuong());
        }

        public List<ReportCBThiDua> GetListThiDua()
        {
            List<ReportCBThiDua> lts = new List<ReportCBThiDua>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var Year = DateTime.Now.Year;
                int IsKhenThuong = 0;

                con.Open();

                SqlCommand cmd = new SqlCommand("CanBo_KhenThuongNEW", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@iYear", SqlDbType.Int).Value = Year;
                cmd.Parameters.Add("@isKhenThuong", SqlDbType.Int).Value = IsKhenThuong;
                cmd.Parameters.Add("@KieuCB", SqlDbType.Int).Value = 10;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ReportCBThiDua obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ReportCBThiDua();
                        obj.STTChucVu = dt.Rows[i]["STTChucVu"].ToString().Equals("") ? 0 : int.Parse(dt.Rows[i]["STTChucVu"].ToString());
                        obj.DonVi = dt.Rows[i]["DonVi"].ToString();
                        obj.TenTrinhDo = dt.Rows[i]["TenTrinhDo"].ToString();
                        obj.KieuCanBo = dt.Rows[i]["KieuCanBo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["KieuCanBo"].ToString());
                        obj.TenKieuCanBo = dt.Rows[i]["TenKieuCanBo"].ToString();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.CanBoID = dt.Rows[i]["CanBoID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CanBoID"].ToString());
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.NgaySinh = dt.Rows[i]["NgaySinh"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                        obj.GioiTinh = dt.Rows[i]["GioiTinh"].ToString().Equals("") ? (bool?)null : bool.Parse(dt.Rows[i]["GioiTinh"].ToString());
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.TenPhongBan = dt.Rows[i]["TenPhongBan"].ToString();
                        obj.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                        obj.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                        obj.NoiDung = dt.Rows[i]["NoiDung"].ToString();
                        obj.TenHinhThucKhenThuong = dt.Rows[i]["TenHinhThucKhenThuong"].ToString();
                        obj.RegionID = dt.Rows[i]["RegionID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["RegionID"].ToString());
                        obj.Nam = dt.Rows[i]["Nam"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nam"].ToString());
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }

        public List<ReportCBThiDua> GetListKhenThuong()
        {
            List<ReportCBThiDua> lts = new List<ReportCBThiDua>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var Year = DateTime.Now.Year;
                int IsKhenThuong = 0;

                con.Open();

                SqlCommand cmd = new SqlCommand("CanBo_KhenThuongNEW", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@iYear", SqlDbType.Int).Value = Year;
                cmd.Parameters.Add("@isKhenThuong", SqlDbType.Int).Value = IsKhenThuong;
                cmd.Parameters.Add("@KieuCB", SqlDbType.Int).Value = 10;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ReportCBThiDua obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ReportCBThiDua();
                        obj.STTChucVu = dt.Rows[i]["STTChucVu"].ToString().Equals("") ? 0 : int.Parse(dt.Rows[i]["STTChucVu"].ToString());
                        obj.DonVi = dt.Rows[i]["DonVi"].ToString();
                        obj.TenTrinhDo = dt.Rows[i]["TenTrinhDo"].ToString();
                        obj.KieuCanBo = dt.Rows[i]["KieuCanBo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["KieuCanBo"].ToString());
                        obj.TenKieuCanBo = dt.Rows[i]["TenKieuCanBo"].ToString();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.CanBoID = dt.Rows[i]["CanBoID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CanBoID"].ToString());
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.NgaySinh = dt.Rows[i]["NgaySinh"].ToString().Equals("") ? (DateTime?)null : DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                        obj.GioiTinh = dt.Rows[i]["GioiTinh"].ToString().Equals("") ? (bool?)null : bool.Parse(dt.Rows[i]["GioiTinh"].ToString());
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.TenPhongBan = dt.Rows[i]["TenPhongBan"].ToString();
                        obj.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                        obj.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                        obj.NoiDung = dt.Rows[i]["NoiDung"].ToString();
                        obj.TenHinhThucKhenThuong = dt.Rows[i]["TenHinhThucKhenThuong"].ToString();
                        obj.RegionID = dt.Rows[i]["RegionID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["RegionID"].ToString());
                        obj.Nam = dt.Rows[i]["Nam"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nam"].ToString());
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }


        private bool ReportCBThiDuaExists(int? id)
        {
            return _context.ReportCBThiDua.Any(e => e.ID == id);
        }
    }
}
