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
    public class DienBienChucVusController : Controller
    {
        private readonly QLCBDbContext _context;

        public DienBienChucVusController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: DienBienChucVus
        public async Task<IActionResult> Index()
        {
            var qLCBDbContext = _context.DienBienChucVus.Include(d => d.CanBo).Include(d => d.dmChucVu).Include(d => d.dmDonVi);
            return View(await qLCBDbContext.ToListAsync());
        }

        // GET: DienBienChucVus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienBienChucVu = await _context.DienBienChucVus
                .Include(d => d.CanBo)
                .Include(d => d.dmChucVu)
                .Include(d => d.dmDonVi)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dienBienChucVu == null)
            {
                return NotFound();
            }

            return View(dienBienChucVu);
        }

        // GET: DienBienChucVus/Create
        public IActionResult Create()
        {
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen");
            ViewData["ChucVuID"] = new SelectList(_context.dmChucVus, "ID", "ID");
            ViewData["PhongBanID"] = new SelectList(_context.dmDonVis, "ID", "ID");
            return View();
        }

        // POST: DienBienChucVus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CanBoID,TuNgay,DenNgay,ChucVuID,PhuCapChucVu,Curent,isLeader,NgayBoNhiem,SoQuyetDinh,NguoiKy,PhongBanID,IsDangDoan,IsDeleted")] DienBienChucVu dienBienChucVu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dienBienChucVu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", dienBienChucVu.CanBoID);
            ViewData["ChucVuID"] = new SelectList(_context.dmChucVus, "ID", "ID", dienBienChucVu.ChucVuID);
            ViewData["PhongBanID"] = new SelectList(_context.dmDonVis, "ID", "ID", dienBienChucVu.PhongBanID);
            return View(dienBienChucVu);
        }

        // GET: DienBienChucVus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienBienChucVu = await _context.DienBienChucVus.FindAsync(id);
            if (dienBienChucVu == null)
            {
                return NotFound();
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", dienBienChucVu.CanBoID);
            ViewData["ChucVuID"] = new SelectList(_context.dmChucVus, "ID", "ID", dienBienChucVu.ChucVuID);
            ViewData["PhongBanID"] = new SelectList(_context.dmDonVis, "ID", "ID", dienBienChucVu.PhongBanID);
            return View(dienBienChucVu);
        }

        // POST: DienBienChucVus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CanBoID,TuNgay,DenNgay,ChucVuID,PhuCapChucVu,Curent,isLeader,NgayBoNhiem,SoQuyetDinh,NguoiKy,PhongBanID,IsDangDoan,IsDeleted")] DienBienChucVu dienBienChucVu)
        {
            if (id != dienBienChucVu.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dienBienChucVu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DienBienChucVuExists(dienBienChucVu.ID))
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
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", dienBienChucVu.CanBoID);
            ViewData["ChucVuID"] = new SelectList(_context.dmChucVus, "ID", "ID", dienBienChucVu.ChucVuID);
            ViewData["PhongBanID"] = new SelectList(_context.dmDonVis, "ID", "ID", dienBienChucVu.PhongBanID);
            return View(dienBienChucVu);
        }

        // GET: DienBienChucVus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienBienChucVu = await _context.DienBienChucVus
                .Include(d => d.CanBo)
                .Include(d => d.dmChucVu)
                .Include(d => d.dmDonVi)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dienBienChucVu == null)
            {
                return NotFound();
            }

            return View(dienBienChucVu);
        }

        // POST: DienBienChucVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dienBienChucVu = await _context.DienBienChucVus.FindAsync(id);
            _context.DienBienChucVus.Remove(dienBienChucVu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DienBienChucVuExists(int id)
        {
            return _context.DienBienChucVus.Any(e => e.ID == id);
        }
    }
}
