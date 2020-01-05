using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using QLCBCore.Models;
using QLCBCore.Models.ThongKe;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers.ThongKe
{
    public class ThongKeGDCSController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public ThongKeGDCSController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }

        // GET: ThongKeGDCS
        public async Task<IActionResult> Index()
        {
            return View(GetListThongKeGDCS());
        }

        public List<ThongKeGDCS> GetListThongKeGDCS()
        {
            List<ThongKeGDCS> lts = new List<ThongKeGDCS>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("RP_ThongKe_GDCS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@KieuCB", SqlDbType.Int).Value = 10;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ThongKeGDCS obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ThongKeGDCS();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.TenGDCS = dt.Rows[i]["TenGDCS"].ToString();
                        obj.total = dt.Rows[i]["count_num"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["count_num"].ToString());
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }
    }
}
