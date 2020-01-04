using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using QLCBCore.Models;
using QLCBCore.Models.BaoCao;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    public class ReportSLCLCBTheoDoTuoisController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public ReportSLCLCBTheoDoTuoisController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }

        // GET: ReportSLCLCBTheoDoTuois
        public IActionResult Index()
        {            
            return View(GetListSLCLCBTheoDoTuoi());
        }

        // GET: ReportSLCLCBTheoDoTuois/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSLCLCBTheoDoTuoi = await _context.ReportSLCLCBTheoDoTuoi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reportSLCLCBTheoDoTuoi == null)
            {
                return NotFound();
            }

            return View(reportSLCLCBTheoDoTuoi);
        }

        // GET: ReportSLCLCBTheoDoTuois/Create
        public IActionResult Create()
        {
            return View();
        }

        public List<ReportSLCLCBTheoDoTuoi> GetListSLCLCBTheoDoTuoi()
        {
            List<ReportSLCLCBTheoDoTuoi> lts = new List<ReportSLCLCBTheoDoTuoi>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var DenNgay = DateTime.Now;
                con.Open();

                SqlCommand cmd = new SqlCommand("RP_SLCLCB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = DenNgay;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ReportSLCLCBTheoDoTuoi obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ReportSLCLCBTheoDoTuoi();
                        obj.DonViID = dt.Rows[i]["ID"].ToString().Equals("") ? 0 : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.TongSo = dt.Rows[i]["TongSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSo"].ToString());
                        obj.PhuNu = dt.Rows[i]["PhuNu"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["PhuNu"].ToString());
                        obj.Nam = dt.Rows[i]["Nam"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nam"].ToString());
                        obj.Total20den30 = dt.Rows[i]["Total20den30"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Total20den30"].ToString());
                        obj.Nam20den30 = dt.Rows[i]["Namtu20den30"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Namtu20den30"].ToString());
                        obj.Nu20den30 = dt.Rows[i]["Nutu20den30"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nutu20den30"].ToString());
                        obj.Total30den50 = dt.Rows[i]["Total30den50"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Total30den50"].ToString());
                        obj.Nam30den50 = dt.Rows[i]["Namtu30den50"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Namtu30den50"].ToString());
                        obj.Nu30den50 = dt.Rows[i]["Nutu30den50"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nutu30den50"].ToString());
                        obj.Totaltren50 = dt.Rows[i]["Totaltren50"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Totaltren50"].ToString());
                        obj.Namtren50 = dt.Rows[i]["Namtren50"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Namtren50"].ToString());
                        obj.Nutren50 = dt.Rows[i]["Nutren50"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Nutren50"].ToString());
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }

        // POST: ReportSLCLCBTheoDoTuois/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FullName,Birthday,Gender,Email,UserName,Password,DonViID")] ReportSLCLCBTheoDoTuoi reportSLCLCBTheoDoTuoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportSLCLCBTheoDoTuoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportSLCLCBTheoDoTuoi);
        }

        // GET: ReportSLCLCBTheoDoTuois/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSLCLCBTheoDoTuoi = await _context.ReportSLCLCBTheoDoTuoi.FindAsync(id);
            if (reportSLCLCBTheoDoTuoi == null)
            {
                return NotFound();
            }
            return View(reportSLCLCBTheoDoTuoi);
        }

        // POST: ReportSLCLCBTheoDoTuois/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FullName,Birthday,Gender,Email,UserName,Password,DonViID")] ReportSLCLCBTheoDoTuoi reportSLCLCBTheoDoTuoi)
        {
            if (id != reportSLCLCBTheoDoTuoi.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportSLCLCBTheoDoTuoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportSLCLCBTheoDoTuoiExists(reportSLCLCBTheoDoTuoi.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reportSLCLCBTheoDoTuoi);
        }

        // GET: ReportSLCLCBTheoDoTuois/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSLCLCBTheoDoTuoi = await _context.ReportSLCLCBTheoDoTuoi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reportSLCLCBTheoDoTuoi == null)
            {
                return NotFound();
            }

            return View(reportSLCLCBTheoDoTuoi);
        }

        // POST: ReportSLCLCBTheoDoTuois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportSLCLCBTheoDoTuoi = await _context.ReportSLCLCBTheoDoTuoi.FindAsync(id);
            _context.ReportSLCLCBTheoDoTuoi.Remove(reportSLCLCBTheoDoTuoi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportSLCLCBTheoDoTuoiExists(int id)
        {
            return _context.ReportSLCLCBTheoDoTuoi.Any(e => e.ID == id);
        }
    }
}
