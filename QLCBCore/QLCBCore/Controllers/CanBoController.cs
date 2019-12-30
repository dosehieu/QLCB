using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    public class CanBoController : Controller
    {
        private readonly QLCBDbContext _context;

        public CanBoController(QLCBDbContext context)
        {
            _context = context;
        }
        
        // GET: CanBo
        public async Task<IActionResult> Index()
        {
            var i = 1;

            return View(await _context.CanBos.Include(n => n.dmChucVu).Include(n => n.dmDonVi).Include(n => n.dmKieuCanBo).Include(n => n.dmTrinhDo).ToListAsync());
        }

        // GET: CanBo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (canBo == null)
            {
                return NotFound();
            }

            return View(canBo);
        }

        // GET: CanBo/Create
        public IActionResult Create()
        {
            ViewData["DanTocID"] = new SelectList(_context.dmDanTocs, "ID", "TenDanToc");
            ViewData["TonGiaoID"] = new SelectList(_context.dmTonGiaos, "ID", "TenTonGiao");
            ViewData["TDPhoThongID"] = new SelectList(_context.dmTrinhDoPTs, "ID", "TenTrinhDo");
            ViewData["HocHamID"] = new SelectList(_context.dmHocHams, "ID", "TenHocHam");
            ViewData["NgheNghiepID"] = new SelectList(_context.dmNgheNghieps, "ID", "TenNgheNghiep");
            ViewData["TDPhoThongID"] = new SelectList(_context.dmTrinhDoPTs, "ID", "TenTrinhDo");
            ViewData["NgheNghiepID"] = new SelectList(_context.dmNgheNghieps, "ID", "TenNgheNghiep");
            ViewData["HinhThucThiTuyenID"] = new SelectList(_context.dmHinhThucThiTuyens, "ID", "TenHinhThucTT");
            ViewData["QuanHamCaoNhatID"] = new SelectList(_context.dmQuanHams, "ID", "TenQuanHam");
            ViewData["HangThuongBinhID"] = new SelectList(_context.dmHangThuongBinhs, "ID", "TenHangThuongBinh");
            ViewData["GiaDinhCSID"] = new SelectList(_context.dmGiaDinhCSs, "ID", "TenGiaDinhCS");
            ViewData["SucKhoeID"] = new SelectList(_context.dmTinhTrangSucKhoes, "ID", "TenTTSK");
            ViewData["DonViID"] = new SelectList(_context.dmDonVis, "ID", "TenDonVi");
            ViewData["KieuCanBo"] = new SelectList(_context.dmKieuCanBo, "ID", "TenKieuCanBo");

            return View();
        }

        // POST: CanBo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ma,SoHieu,HoTen,TenGoiKhac,GioiTinh,NgaySinh,DanTocID,TonGiaoID,DonViID,TrangThai,DienThoai,Email,CMTND,NgayCapCMT,NoiCapCMT,NoiSinhID,QueQuanID,HKTT,NoiO,TDPhoThongID,HochamID,HinhAnh,NgheNghiepID,CoquanTuyenDung,NgayTuyen,NgayVeCQ,HinhThucThiTuyenID,KieuCanBo,NgayHetHanHD,CongViecDuocGiao,SoTruongCongTac,NgayVaoDang,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhatID,HangThuongBinhID,GiaDinhCSID,SucKhoeID,ChieuCao,CanNang,NhomMauID,SoBHXH,NoiCapSoBHXH,SoBHYT,LichSuBanThan,GhiChu,NhanXetDanhGia")] CanBo canBo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(canBo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DanTocID"] = new SelectList(_context.dmDanTocs, "ID", "TenDanToc");
            ViewData["TonGiaoID"] = new SelectList(_context.dmTonGiaos, "ID", "TenTonGiao");
            ViewData["TDPhoThongID"] = new SelectList(_context.dmTrinhDoPTs, "ID", "TenTrinhDo");
            ViewData["HocHamID"] = new SelectList(_context.dmHocHams, "ID", "TenHocHam");
            ViewData["NgheNghiepID"] = new SelectList(_context.dmNgheNghieps, "ID", "TenNgheNghiep");
            ViewData["TDPhoThongID"] = new SelectList(_context.dmTrinhDoPTs, "ID", "TenTrinhDo");
            ViewData["NgheNghiepID"] = new SelectList(_context.dmNgheNghieps, "ID", "TenNgheNghiep");
            ViewData["HinhThucThiTuyenID"] = new SelectList(_context.dmHinhThucThiTuyens, "ID", "TenHinhThucTT");
            ViewData["QuanHamCaoNhatID"] = new SelectList(_context.dmQuanHams, "ID", "TenQuanHam");
            ViewData["HangThuongBinhID"] = new SelectList(_context.dmHangThuongBinhs, "ID", "TenHangThuongBinh");
            ViewData["GiaDinhCSID"] = new SelectList(_context.dmGiaDinhCSs, "ID", "TenGiaDinhCS");
            ViewData["SucKhoeID"] = new SelectList(_context.dmTinhTrangSucKhoes, "ID", "TenTTSK");
            ViewData["DonViID"] = new SelectList(_context.dmDonVis, "ID", "TenDonVi");
            ViewData["KieuCanBo"] = new SelectList(_context.dmKieuCanBo, "ID", "TenKieuCanBo");
            return View(canBo);
        }

        // GET: CanBo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBos.FindAsync(id);
            if (canBo == null)
            {
                return NotFound();
            }
            return View(canBo);
        }

        // POST: CanBo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ma,SoHieu,HoTen,TenGoiKhac,GioiTinh,NgaySinh,DanTocID,TonGiaoID,DonViID,TrangThai,DienThoai,Email,CMTND,NgayCapCMT,NoiCapCMT,NoiSinhID,QueQuanID,HKTT,NoiO,TDPhoThongID,HochamID,HinhAnh,NgheNghiepID,CoquanTuyenDung,NgayTuyen,NgayVeCQ,HinhThucThiTuyenID,KieuCanBo,NgayHetHanHD,CongViecDuocGiao,SoTruongCongTac,NgayVaoDang,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhatID,HangThuongBinhID,GiaDinhCSID,SucKhoeID,ChieuCao,CanNang,NhomMauID,SoBHXH,NoiCapSoBHXH,SoBHYT,LichSuBanThan,GhiChu,NhanXetDanhGia,ChucVuID,BacLuong,NgachID,HeSo,NgayHuong,PhuCapChucVu,PhuCapKhac,TrinhDoID,RegionID,NgayCapNhat,DanhHieuCaoNhatID,KhenThuong,KyLuat,NgayVe,NgayThongBaoNghiHuu,NgayNghiHuu,NgayGiuNgach,NgayThoiViec,NgayChuyenCtac,NgayTuTran,DonviOldID,IsDeleted")] CanBo canBo)
        {
            if (id != canBo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(canBo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CanBoExists(canBo.ID))
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
            return View(canBo);
        }

        // GET: CanBo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (canBo == null)
            {
                return NotFound();
            }

            return View(canBo);
        }

        // POST: CanBo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var canBo = await _context.CanBos.FindAsync(id);
            _context.CanBos.Remove(canBo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CanBoExists(int id)
        {
            return _context.CanBos.Any(e => e.ID == id);
        }
    }
}
