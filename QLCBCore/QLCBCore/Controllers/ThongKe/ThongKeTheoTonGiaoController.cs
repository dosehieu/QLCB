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
    public class ThongKeTheoTonGiaoController : Controller
    {
        private readonly IOptions<ConnectionString> config;

        private readonly QLCBDbContext _context;

        public ThongKeTheoTonGiaoController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }

        // GET: ThongKeTheoTonGiao
        public async Task<IActionResult> Index()
        {
            return View(GetListThongKeTonGiao());
        }

        public ThongKeTheoTonGiao GetListThongKeTonGiao()
        {
            ThongKeTheoTonGiao lts = new ThongKeTheoTonGiao();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("RP_ThongKe_TonGiao", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@KieuCB", SqlDbType.Int).Value = 10;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ThongKeTheoTonGiao obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ThongKeTheoTonGiao();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.MaCha = dt.Rows[i]["MaCha"].ToString();
                        obj.KieuDonVi = dt.Rows[i]["KieuDonVi"].ToString();
                        obj.Leve = dt.Rows[i]["Leve"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Leve"].ToString());
                        obj.STT = dt.Rows[i]["STT"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["STT"].ToString());
                        obj.TongSo = dt.Rows[i]["TongSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSo"].ToString());
                        obj.CoTonGiao = dt.Rows[i]["CoTonGiao"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CoTonGiao"].ToString());
                        obj.KhongTonGiao = dt.Rows[i]["KhongTonGiao"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["KhongTonGiao"].ToString());
                        lts = obj;
                    }
                }
                return lts;
            }
        }

    }
}
