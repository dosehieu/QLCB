
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
    public class QTKyLuatsController : Controller
    {
        private readonly QLCBDbContext _context;

        public QTKyLuatsController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: QTKyLuats
        public async Task<IActionResult> Index(int? id)
        {
            //var qLCBDbContext = _context.QTKyLuats.Include(q => q.CanBo).Include(q => q.dmKyLuat);
            //return View(await qLCBDbContext.ToListAsync());
            if (id == null)
            {
                return NotFound();
            }

            var qTKyLuat = await _context.QTKyLuats
                .Where(m => m.ID == id)
                .Include(q => q.CanBo)
                .Include(q => q.dmKyLuat).ToListAsync();
            if (qTKyLuat == null)
            {
                return NotFound();
            }

            return View(qTKyLuat);
        }

        // GET: QTKyLuats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTKyLuat = await _context.QTKyLuats
                .Include(q => q.CanBo)
                .Include(q => q.dmKyLuat)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qTKyLuat == null)
            {
                return NotFound();
            }

            return View(qTKyLuat);
        }

        // GET: QTKyLuats/Create
        public IActionResult Create()
        {
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen");
            ViewData["KyLuatID"] = new SelectList(_context.dmKyLuats, "ID", "IDTenKyLuat");
            return View();
        }

        // POST: QTKyLuats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CanBoID,NgayKyLuat,KyLuatID,NoiDung,IsCaoNhat,SoQuyetDinh,CoQuanBanHanhQD,IsDeleted")] QTKyLuat qTKyLuat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qTKyLuat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTKyLuat.CanBoID);
            ViewData["KyLuatID"] = new SelectList(_context.dmKyLuats, "ID", "ID", qTKyLuat.KyLuatID);
            return View(qTKyLuat);
        }

        // GET: QTKyLuats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTKyLuat = await _context.QTKyLuats.FindAsync(id);
            if (qTKyLuat == null)
            {
                return NotFound();
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTKyLuat.CanBoID);
            ViewData["KyLuatID"] = new SelectList(_context.dmKyLuats, "ID", "TenKyLuat", qTKyLuat.KyLuatID);
            return View(qTKyLuat);
        }

        // POST: QTKyLuats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CanBoID,NgayKyLuat,KyLuatID,NoiDung,IsCaoNhat,SoQuyetDinh,CoQuanBanHanhQD,IsDeleted")] QTKyLuat qTKyLuat)
        {
            if (id != qTKyLuat.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qTKyLuat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QTKyLuatExists(qTKyLuat.ID))
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
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTKyLuat.CanBoID);
            ViewData["KyLuatID"] = new SelectList(_context.dmKyLuats, "ID", "ID", qTKyLuat.KyLuatID);
            return View(qTKyLuat);
        }

        // GET: QTKyLuats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTKyLuat = await _context.QTKyLuats
                .Include(q => q.CanBo)
                .Include(q => q.dmKyLuat)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qTKyLuat == null)
            {
                return NotFound();
            }

            return View(qTKyLuat);
        }

        // POST: QTKyLuats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qTKyLuat = await _context.QTKyLuats.FindAsync(id);
            _context.QTKyLuats.Remove(qTKyLuat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QTKyLuatExists(int id)
        {
            return _context.QTKyLuats.Any(e => e.ID == id);
        }
    }
}
