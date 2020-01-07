using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using QLCBCore.Base;
using QLCBCore.Models;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLCBDbContext _context;
        private readonly IOptions<ConnectionString> config;
        public GetStoredProcedure getStoredProcedure;
        public HomeController(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;

        }
        public async Task<IActionResult> Index()
        {
            var ListCB = await _context.CanBos.Where(n => n.IsDeleted == false).ToListAsync();
            ViewBag.TongSoCB = ListCB.Count;

           

            getStoredProcedure = new GetStoredProcedure(_context, config);
            List<CanBoNangLuongVM> listNL = getStoredProcedure.GetListCanBoNangLuong();
            ViewBag.TongSoCBNL = listNL.Count;

            
            List<CanBoSapHetHanChucVuVM> listCV = getStoredProcedure.GetListCanBoSapHetHanChucVu();
            ViewBag.TongSoCBCV = listCV.Count;


            DateTime startDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month, 1);
            DateTime endDate = new DateTime( DateTime.Now.Year,DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            var List = await _context.CanBos.Where(n => n.IsDeleted == false && n.NgaySinh > startDate && n.NgaySinh < endDate).ToListAsync();
            ViewBag.TongSoCBSN = ListCB.Count;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
