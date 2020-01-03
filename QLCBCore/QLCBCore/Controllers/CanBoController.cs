using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
   
   
    public class CanBoController : Base.BaseController
    {
        private readonly QLCBDbContext _context;
        public CanBoController(QLCBDbContext context)
        {
            _context = context;
        }
       
        // GET: CanBo
        public async Task<IActionResult> Index(int? Page,int? RowPerPage,string Field,bool FieldOption, string Filter)
        {
            //SetPage(Page, RowPerPage, Field,  FieldOption,  Filter);
            var List = await _context.CanBos.Where(n => n.IsDeleted == false)
                                            .Include(n => n.dmChucVu)
                                            .Include(n => n.dmDonVi)
                                            .Include(n => n.dmKieuCanBo)
                                            .Include(n => n.dmTrinhDo)
                                            .ToListAsync();
            ViewData["CountCB"] = List.Count;
            //TotalRecord = List.Count;
            //SetHtmlPager(TotalRecord);
            //ViewData["HtmlPager"] = HtmlPager;
            //return View(List.Skip((_Page - 1) * _RowPerPage).Take(_RowPerPage));
            return View(List);
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
    
        public async Task<IActionResult> Create([Bind("ID,Ma,SoHieu,HoTen,TenGoiKhac,GioiTinh,NgaySinh,DanTocID,TonGiaoID,DonViID,TrangThai,DienThoai,Email,CMTND,NgayCapCMT,NoiCapCMT,NoiSinhID,QueQuanID,HKTT,NoiO,TDPhoThongID,HochamID,NgheNghiepID,CoquanTuyenDung,NgayTuyen,NgayVeCQ,HinhThucThiTuyenID,KieuCanBo,NgayHetHanHD,CongViecDuocGiao,SoTruongCongTac,NgayVaoDang,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhatID,HangThuongBinhID,GiaDinhCSID,SucKhoeID,ChieuCao,CanNang,NhomMauID,SoBHXH,NoiCapSoBHXH,SoBHYT,LichSuBanThan,GhiChu,NhanXetDanhGia")] CanBo canBo, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                if(ImageFile!=null)
                {
                    string day = DateTime.Now.ToString();
                    var filename = ContentDispositionHeaderValue.Parse(ImageFile.ContentDisposition).FileName.Trim('"') ;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", ImageFile.FileName );
                    using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }
                    canBo.HinhAnh = filename;
                }
                _context.Add(canBo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            if (ImageFile != null)
            {
                ViewData["Image_Notif"] = "Vui lòng chọn lại ảnh đại diện";
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
            if(canBo.HinhAnh!= null)
            {
                ViewData["HinhAnh"] = "true";
            }
            else
                ViewData["HinhAnh"] = "false";
            return View(canBo);
        }

        // POST: CanBo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
     
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ma,SoHieu,HoTen,TenGoiKhac,GioiTinh,NgaySinh,DanTocID,TonGiaoID,DonViID,TrangThai,DienThoai,Email,CMTND,NgayCapCMT,NoiCapCMT,NoiSinhID,QueQuanID,HKTT,NoiO,TDPhoThongID,HochamID,HinhAnh,NgheNghiepID,CoquanTuyenDung,NgayTuyen,NgayVeCQ,HinhThucThiTuyenID,KieuCanBo,NgayHetHanHD,CongViecDuocGiao,SoTruongCongTac,NgayVaoDang,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhatID,HangThuongBinhID,GiaDinhCSID,SucKhoeID,ChieuCao,CanNang,NhomMauID,SoBHXH,NoiCapSoBHXH,SoBHYT,LichSuBanThan,GhiChu,NhanXetDanhGia")] CanBo canBo, IFormFile ImageFile)
        {
            if (id != canBo.ID)
            {
                return NotFound();
            }
            
            //await TryUpdateModelAsync(canBo);

            if (ModelState.IsValid)
            {
                try
                {
                    if (ImageFile != null)
                    {
                        string day = DateTime.Now.ToString();
                        var filename = ContentDispositionHeaderValue.Parse(ImageFile.ContentDisposition).FileName.Trim('"');
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", ImageFile.FileName);
                        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await ImageFile.CopyToAsync(stream);
                        }
                        canBo.HinhAnh = filename;
                    }
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
            if (ImageFile != null)
            {
                ViewData["Image_Notif"] = "Vui lòng chọn lại ảnh đại diện";
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
       
        [HttpGet]
        public string Delete(int id)
        {
            var canBo = _context.CanBos.Find(id);
            canBo.IsDeleted = true;
            //_context.CanBos.Remove(canBo);
            _context.SaveChanges();
            return "success";
        }

        private bool CanBoExists(int id)
        {
            return _context.CanBos.Any(e => e.ID == id);
        }
    }
}
