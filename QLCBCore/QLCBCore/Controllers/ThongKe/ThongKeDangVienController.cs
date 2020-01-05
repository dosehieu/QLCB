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
using QLCBCore.Models.ThongKe;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers.ThongKe
{
    public class ThongKeDangVienController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public ThongKeDangVienController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }

        // GET: ThongKeDangVien
        public async Task<IActionResult> Index()
        {
            return View(GetListThongKeDangvien());
        }

        public ThongKeDangVien GetListThongKeDangvien()
        {
            ThongKeDangVien lts = new ThongKeDangVien();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("RP_ThongKe_DangVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@KieuCB", SqlDbType.Int).Value = 10;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ThongKeDangVien obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ThongKeDangVien();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.TongSo = dt.Rows[i]["TongSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSo"].ToString());
                        obj.DangVien = dt.Rows[i]["DangVien"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["DangVien"].ToString());
                        lts = obj;
                    }
                }
                return lts;
            }
        }
    }
}
