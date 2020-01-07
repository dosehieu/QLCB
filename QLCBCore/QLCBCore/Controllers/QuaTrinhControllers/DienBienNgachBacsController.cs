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
    public class DienBienNgachBacsController : Controller
    {
        private readonly QLCBDbContext _context;

        public DienBienNgachBacsController(QLCBDbContext context)
        {
            _context = context;
        }

        // GET: DienBienNgachBacs
        public async Task<IActionResult> Index(int? id)
        {
            //var qLCBDbContext = _context.DienBienNgachBacs.Include(d => d.CanBo).Include(d => d.dmNgach);
            //return View(await qLCBDbContext.ToListAsync());
            if (id == null)
            {
                return NotFound();
            }

            var dienBienNgachBac = await _context.DienBienNgachBacs
                .Where(m => m.CanBoID == id)
                .Include(d => d.CanBo)
                .Include(d => d.dmNgach).ToListAsync();
            if (dienBienNgachBac == null)
            {
                return NotFound();
            }

            return View(dienBienNgachBac);
        }

        // GET: DienBienNgachBacs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienBienNgachBac = await _context.DienBienNgachBacs
                .Include(d => d.CanBo)
                .Include(d => d.dmNgach)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dienBienNgachBac == null)
            {
                return NotFound();
            }

            return View(dienBienNgachBac);
        }

        // GET: DienBienNgachBacs/Create
        public IActionResult Create()
        {
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen");
            ViewData["NgachID"] = new SelectList(_context.dmNgachs, "ID", "TenNgach");
            return View();
        }

        // POST: DienBienNgachBacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CanBoID,NgachID,BacLuong,NgayHuong,NgayKetThuc,ThoiHanNangBac,DaVuotKhung,SoQD,NguoiKy,NgayKy,HSCLBL,HeSo,PhuCapVuotKhung,PhuCapKhac,LuongCoBan,Kieu,Curent,NgachCuID,PhuCapChucVu,PhuCapTrachNhiem,PhuCapKhuVuc,BatDauGiuNgach,GhiChu,isTapSu,PhuCapUuDai,DonGiaDocHai,PhuCapDocHai,NgayBatDauGiuNgach,ThoiGianTapSu,PhuCapThuHut,PhuCapLuuDong,HeSoChenhLechBaoLuu,PhuCapDacBiet,PhuCapThamNien,ThamNienVungKhoKhan,IsDeleted")] DienBienNgachBac dienBienNgachBac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dienBienNgachBac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", dienBienNgachBac.CanBoID);
            ViewData["NgachID"] = new SelectList(_context.dmNgachs, "ID", "ID", dienBienNgachBac.NgachID);
            return View(dienBienNgachBac);
        }

        // GET: DienBienNgachBacs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienBienNgachBac = await _context.DienBienNgachBacs.FindAsync(id);
            if (dienBienNgachBac == null)
            {
                return NotFound();
            }
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", dienBienNgachBac.CanBoID);
            ViewData["NgachID"] = new SelectList(_context.dmNgachs, "ID", "TenNgach", dienBienNgachBac.NgachID);
            return View(dienBienNgachBac);
        }

        // POST: DienBienNgachBacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CanBoID,NgachID,BacLuong,NgayHuong,NgayKetThuc,ThoiHanNangBac,DaVuotKhung,SoQD,NguoiKy,NgayKy,HSCLBL,HeSo,PhuCapVuotKhung,PhuCapKhac,LuongCoBan,Kieu,Curent,NgachCuID,PhuCapChucVu,PhuCapTrachNhiem,PhuCapKhuVuc,BatDauGiuNgach,GhiChu,isTapSu,PhuCapUuDai,DonGiaDocHai,PhuCapDocHai,NgayBatDauGiuNgach,ThoiGianTapSu,PhuCapThuHut,PhuCapLuuDong,HeSoChenhLechBaoLuu,PhuCapDacBiet,PhuCapThamNien,ThamNienVungKhoKhan,IsDeleted")] DienBienNgachBac dienBienNgachBac)
        {
            if (id != dienBienNgachBac.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dienBienNgachBac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DienBienNgachBacExists(dienBienNgachBac.ID))
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
            ViewData["CanBoID"] = new SelectList(_context.CanBos, "ID", "HoTen", dienBienNgachBac.CanBoID);
            ViewData["NgachID"] = new SelectList(_context.dmNgachs, "ID", "ID", dienBienNgachBac.NgachID);
            return View(dienBienNgachBac);
        }

        // GET: DienBienNgachBacs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienBienNgachBac = await _context.DienBienNgachBacs
                .Include(d => d.CanBo)
                .Include(d => d.dmNgach)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dienBienNgachBac == null)
            {
                return NotFound();
            }

            return View(dienBienNgachBac);
        }

        // POST: DienBienNgachBacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dienBienNgachBac = await _context.DienBienNgachBacs.FindAsync(id);
            _context.DienBienNgachBacs.Remove(dienBienNgachBac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DienBienNgachBacExists(int id)
        {
            return _context.DienBienNgachBacs.Any(e => e.ID == id);
        }
    }
}
