
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;

namespace QLCBCore.Controllers.QuaTrinhControllers
{
    public class QTKhenThuongsController : Controller
    {
        private readonly QLCBDbContext _context;

        public QTKhenThuongsController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: QTKhenThuongs
        public async Task<IActionResult> Index(int? id)
        {
            //var qLCBDbContext = _context.QTKhenThuongs.Include(q => q.CanBo).Include(q => q.dmHinhThucKhenThuong);
            //return View(await qLCBDbContext.ToListAsync());
            if (id == null)
            {
                return NotFound();
            }

            var qTKhenThuong = await _context.QTKhenThuongs
                .Where(m => m.CanBoID == id)
                .Include(q => q.CanBo)
                .Include(q => q.dmHinhThucKhenThuong).ToListAsync();
            if (qTKhenThuong == null)
            {
                return NotFound();
            }

            return View(qTKhenThuong);
        }

        // GET: QTKhenThuongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTKhenThuong = await _context.QTKhenThuongs
                .Include(q => q.CanBo)
                .Include(q => q.dmHinhThucKhenThuong)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qTKhenThuong == null)
            {
                return NotFound();
            }

            return View(qTKhenThuong);
        }

        // GET: QTKhenThuongs/Create
        public IActionResult Create()
        {
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen");
            ViewData["HinhThucKhenThuongID"] = new SelectList(_context.dmHinhThucKhenThuongs, "ID", "TenHinhThucKhenThuong");
            return View();
        }

        // POST: QTKhenThuongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CanBoID,HinhThucKhenThuongID,NoiDung,NgayKhenThuong,IsCaoNhat,SoQuyetDinh,NgayKy,CoQuanBanHanhQD,IsKhenThuong,MucKhenThuong,IsDeleted")] QTKhenThuong qTKhenThuong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qTKhenThuong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTKhenThuong.CanBoID);
            ViewData["HinhThucKhenThuongID"] = new SelectList(_context.dmHinhThucKhenThuongs, "ID", "ID", qTKhenThuong.HinhThucKhenThuongID);
            return View(qTKhenThuong);
        }

        // GET: QTKhenThuongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTKhenThuong = await _context.QTKhenThuongs.FindAsync(id);
            if (qTKhenThuong == null)
            {
                return NotFound();
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTKhenThuong.CanBoID);
            ViewData["HinhThucKhenThuongID"] = new SelectList(_context.dmHinhThucKhenThuongs, "ID", "TenHinhThucKhenThuong", qTKhenThuong.HinhThucKhenThuongID);
            return View(qTKhenThuong);
        }

        // POST: QTKhenThuongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CanBoID,HinhThucKhenThuongID,NoiDung,NgayKhenThuong,IsCaoNhat,SoQuyetDinh,NgayKy,CoQuanBanHanhQD,IsKhenThuong,MucKhenThuong,IsDeleted")] QTKhenThuong qTKhenThuong)
        {
            if (id != qTKhenThuong.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qTKhenThuong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QTKhenThuongExists(qTKhenThuong.ID))
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
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", qTKhenThuong.CanBoID);
            ViewData["HinhThucKhenThuongID"] = new SelectList(_context.dmHinhThucKhenThuongs, "ID", "ID", qTKhenThuong.HinhThucKhenThuongID);
            return View(qTKhenThuong);
        }

        // GET: QTKhenThuongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qTKhenThuong = await _context.QTKhenThuongs
                .Include(q => q.CanBo)
                .Include(q => q.dmHinhThucKhenThuong)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qTKhenThuong == null)
            {
                return NotFound();
            }

            return View(qTKhenThuong);
        }

        // POST: QTKhenThuongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qTKhenThuong = await _context.QTKhenThuongs.FindAsync(id);
            _context.QTKhenThuongs.Remove(qTKhenThuong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QTKhenThuongExists(int id)
        {
            return _context.QTKhenThuongs.Any(e => e.ID == id);
        }
    }
}
