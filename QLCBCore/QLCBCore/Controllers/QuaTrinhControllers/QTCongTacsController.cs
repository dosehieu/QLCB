using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;

namespace QLCBCore.Controllers.QuaTrinhControllers
{
    public class QTCongTacsController : Controller
    {
        private readonly QLCBDbContext _context;

        public QTCongTacsController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: QTCongTacs
        public async Task<IActionResult> Index(int? id)
        {
            //var qLCBDbContext = _context.QTCongTacs.Include(q => q.CanBo);
            //return View(await qLCBDbContext.ToListAsync());
            if (id == null)
            {
                return NotFound();
            }

            var qTCongTac = await _context.QTCongTacs
                .Where(m => m.CanBoID == id)
                .Include(q => q.CanBo).ToListAsync();
            if (qTCongTac == null)
            {
                return NotFound();
            }

            return View(qTCongTac);
        }

        // GET: QTCongTacs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTCongTac = await _context.QTCongTacs
                .Include(q => q.CanBo)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qTCongTac == null)
            {
                return NotFound();
            }

            return View(qTCongTac);
        }

        // GET: QTCongTacs/Create
        public IActionResult Create()
        {
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen");
            return View();
        }

        // POST: QTCongTacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CanBoID,TuThangNam,DenThangNam,GhiChu,isChuyenCT,IsDeleted")] QTCongTac qTCongTac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qTCongTac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTCongTac.CanBoID);
            return View(qTCongTac);
        }

        // GET: QTCongTacs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTCongTac = await _context.QTCongTacs.FindAsync(id);
            if (qTCongTac == null)
            {
                return NotFound();
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTCongTac.CanBoID);
            return View(qTCongTac);
        }

        // POST: QTCongTacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CanBoID,TuThangNam,DenThangNam,GhiChu,isChuyenCT,IsDeleted")] QTCongTac qTCongTac)
        {
            if (id != qTCongTac.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qTCongTac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QTCongTacExists(qTCongTac.ID))
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
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTCongTac.CanBoID);
            return View(qTCongTac);
        }

        // GET: QTCongTacs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTCongTac = await _context.QTCongTacs
                .Include(q => q.CanBo)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qTCongTac == null)
            {
                return NotFound();
            }

            return View(qTCongTac);
        }

        // POST: QTCongTacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qTCongTac = await _context.QTCongTacs.FindAsync(id);
            _context.QTCongTacs.Remove(qTCongTac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QTCongTacExists(int id)
        {
            return _context.QTCongTacs.Any(e => e.ID == id);
        }
    }
}
