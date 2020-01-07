
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
    public class QuanHeGiaDinhsController : Controller
    {
        private readonly QLCBDbContext _context;

        public QuanHeGiaDinhsController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: QuanHeGiaDinhs
        public async Task<IActionResult> Index(int? id)
        {
            //var qLCBDbContext = _context.QuanHeGiaDinhs.Include(q => q.CanBo).Include(q => q.dmQuanHeGiaDinh);
            //return View(await qLCBDbContext.ToListAsync());
            if (id == null)
            {
                return NotFound();
            }

            var quanHeGiaDinh = await _context.QuanHeGiaDinhs
                .Where(m => m.CanBoID == id)
                .Include(q => q.CanBo)  
                .Include(q => q.dmQuanHeGiaDinh).ToListAsync();
            if (quanHeGiaDinh == null)
            {
                return NotFound();
            }

            return View(quanHeGiaDinh);
        }

        // GET: QuanHeGiaDinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quanHeGiaDinh = await _context.QuanHeGiaDinhs
                .Include(q => q.CanBo)
                .Include(q => q.dmQuanHeGiaDinh)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (quanHeGiaDinh == null)
            {
                return NotFound();
            }

            return View(quanHeGiaDinh);
        }

        // GET: QuanHeGiaDinhs/Create
        public IActionResult Create()
        {
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen");
            ViewData["QuanHeGDID"] = new SelectList(_context.dmQuanHeGiaDinhs, "ID", "TenQuanHeGD");
            return View();
        }

        // POST: QuanHeGiaDinhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CanBoID,QuanHeGDID,HoTen,NamSinh,NgheNghiep,GhiChu,ThongTinKhac,ThongTinTCXH,QueQuan,Type,IsDeleted,ChucVu,CoQuan,HoKhau,DiaChi")] QuanHeGiaDinh quanHeGiaDinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quanHeGiaDinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", quanHeGiaDinh.CanBoID);
            ViewData["QuanHeGDID"] = new SelectList(_context.dmQuanHeGiaDinhs, "ID", "ID", quanHeGiaDinh.QuanHeGDID);
            return View(quanHeGiaDinh);
        }

        // GET: QuanHeGiaDinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quanHeGiaDinh = await _context.QuanHeGiaDinhs.FindAsync(id);
            if (quanHeGiaDinh == null)
            {
                return NotFound();
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", quanHeGiaDinh.CanBoID);
            ViewData["QuanHeGDID"] = new SelectList(_context.dmQuanHeGiaDinhs, "ID", "TenQuanHeGD", quanHeGiaDinh.QuanHeGDID);
            return View(quanHeGiaDinh);
        }

        // POST: QuanHeGiaDinhs/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CanBoID,QuanHeGDID,HoTen,NamSinh,NgheNghiep,GhiChu,ThongTinKhac,ThongTinTCXH,QueQuan,Type,IsDeleted,ChucVu,CoQuan,HoKhau,DiaChi")] QuanHeGiaDinh quanHeGiaDinh)
        {
            if (id != quanHeGiaDinh.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quanHeGiaDinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuanHeGiaDinhExists(quanHeGiaDinh.ID))
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
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", quanHeGiaDinh.CanBoID);
            ViewData["QuanHeGDID"] = new SelectList(_context.dmQuanHeGiaDinhs, "ID", "ID", quanHeGiaDinh.QuanHeGDID);
            return View(quanHeGiaDinh);
        }

        // GET: QuanHeGiaDinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quanHeGiaDinh = await _context.QuanHeGiaDinhs
                .Include(q => q.CanBo)
                .Include(q => q.dmQuanHeGiaDinh)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (quanHeGiaDinh == null)
            {
                return NotFound();
            }

            return View(quanHeGiaDinh);
        }

        // POST: QuanHeGiaDinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quanHeGiaDinh = await _context.QuanHeGiaDinhs.FindAsync(id);
            _context.QuanHeGiaDinhs.Remove(quanHeGiaDinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuanHeGiaDinhExists(int id)
        {
            return _context.QuanHeGiaDinhs.Any(e => e.ID == id);
        }
    }
}

