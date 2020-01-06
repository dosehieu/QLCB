using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;

namespace QLCBCore.Controllers
{
    public class DonViController : Controller
    {
        private readonly QLCBDbContext _context;

        public DonViController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: DonVi
        public async Task<IActionResult> Index()
        {
            var List = await _context.dmDonVis.ToListAsync();
            ViewData["Count"] = List.Count;
            return View(List);
        }

        // GET: DonVi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dmDonVi = await _context.dmDonVis
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dmDonVi == null)
            {
                return NotFound();
            }

            return View(dmDonVi);
        }

        // GET: DonVi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonVi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MaDonVi,TenDonVi,RegionID,MaCha,Leve,STT,TenVietTat,KieuDonvi,DonViAllID,IsDeleted")] dmDonVi dmDonVi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dmDonVi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dmDonVi);
        }

        // GET: DonVi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dmDonVi = await _context.dmDonVis.FindAsync(id);
            if (dmDonVi == null)
            {
                return NotFound();
            }
            return View(dmDonVi);
        }

        // POST: DonVi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MaDonVi,TenDonVi,RegionID,MaCha,Leve,STT,TenVietTat,KieuDonvi,DonViAllID,IsDeleted")] dmDonVi dmDonVi)
        {
            if (id != dmDonVi.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dmDonVi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!dmDonViExists(dmDonVi.ID))
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
            return View(dmDonVi);
        }

        
        public string Delete(int id)
        {
            var dmDonVi =  _context.dmDonVis.Find(id);
            _context.dmDonVis.Remove(dmDonVi);
             _context.SaveChanges();
            return "1";
        }

        private bool dmDonViExists(int id)
        {
            return _context.dmDonVis.Any(e => e.ID == id);
        }
    }
}
