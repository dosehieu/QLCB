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
using QLCBCore.Base;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Hosting;
using Syncfusion.XlsIO;


namespace QLCBCore.Controllers
{

    public class CanBoController : Base.BaseController
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private string _fileName;
        private string _filePath;
        private readonly QLCBDbContext _context;
        public CanBoController(QLCBDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _fileName = "DanhSachCanBo"+DateTime.Today.ToString("dd-MM-yyyy")+".xlsx";
            _filePath = string.Format("{0}/{1}", _hostingEnvironment.WebRootPath, _fileName);
        }

        // GET: CanBo
        public async Task<IActionResult> Index(int id)
        {
            if (id == 1)
                ViewBag.HinhAnh = 1;
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
            if (canBo.HinhAnh != null)
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
        [HttpPost]
        public ActionResult ExportExcel()
        {
            var List = _context.CanBos.Where(n => n.IsDeleted == false)
                                            .Include(n => n.dmChucVu)
                                            .Include(n => n.dmDonVi)
                                            .Include(n => n.dmKieuCanBo)
                                            .Include(n => n.dmTrinhDo)
                                            .ToList();
            //Create an instance of ExcelEngine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Set the default application version as Excel 2016
                excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2016;

                //Create a workbook with a worksheet
                IWorkbook workbook = excelEngine.Excel.Workbooks.Create(1);

                //Access first worksheet from the workbook instance
                IWorksheet worksheet = workbook.Worksheets[0];



                worksheet.Range[1, 1].CellStyle.WrapText = true;
                worksheet.Range[1, 1].Value = "Danh sách cán bộ"; // Heading Name
                worksheet.Range[1, 1, 1, 9].Merge(); //Merge columns start and end range
                worksheet.Range[1, 1, 1, 9].CellStyle.Font.Bold = true; //Font should be bold
                worksheet.Range[1, 1, 1, 9].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter; // Aligmnet 
                worksheet.Range[1, 1, 1, 9].CellStyle.Font.FontName = "Times New Roman";
                worksheet.Range[1, 1, 1, 9].CellStyle.Font.Size = 22;

                worksheet.Range[2, 1].CellStyle.WrapText = true;
                worksheet.Range[2, 1].Value = "Tổng số : " + List.Count.ToString() + " (cán bộ)"; // Heading Name
                worksheet.Range[2, 1, 2, 9].Merge(); //Merge columns start and end range
                worksheet.Range[2, 1, 2, 9].CellStyle.Font.Bold = true; //Font should be bold
                worksheet.Range[2, 1, 2, 9].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter; // Aligmnet 
                worksheet.Range[2, 1, 2, 9].CellStyle.Font.FontName = "Times New Roman";
                worksheet.Range[2, 1, 2, 9].CellStyle.Font.Size = 14;

                worksheet.UsedRange.AutofitColumns();
                // Tạo header  
                worksheet.Range[4, 1,4,9].RowHeight = 25;
                worksheet.Range[4, 1, 4, 9].BorderInside(ExcelLineStyle.Thin, ExcelKnownColors.Black);
                worksheet.Range[4, 1, 4, 9].CellStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                worksheet.Range[4, 1, 4, 9].CellStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                worksheet.Range[4, 1, 4, 9].CellStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                worksheet.Range[4, 1, 4, 9].CellStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                worksheet.Range[4, 1].Value = "STT";
                worksheet.Range[4, 1].ColumnWidth = 7;

                worksheet.Range[4, 2].Value = "Mã";
                worksheet.Range[4, 2].ColumnWidth = 15;

                worksheet.Range[4, 3].Value = "Họ tên";
                worksheet.Range[4, 3].ColumnWidth = 25;

                worksheet.Range[4, 4].Value = "Giới tính";
                worksheet.Range[4, 4].ColumnWidth = 15;

                worksheet.Range[4, 5].Value = "Ngày sinh";
                worksheet.Range[4, 5].ColumnWidth = 20;

                worksheet.Range[4, 6].Value = "Đơn vị";
                worksheet.Range[4, 6].ColumnWidth = 25;

                worksheet.Range[4, 7].Value = "Chức vụ";
                worksheet.Range[4, 7].ColumnWidth = 20;

                worksheet.Range[4, 8].Value = "Phân loại";
                worksheet.Range[4, 8].ColumnWidth = 20;

                worksheet.Range[4, 9].Value = "Trình độ";
                worksheet.Range[4, 9].ColumnWidth = 20;
                // Lấy range vào tạo format cho range đó ở đây là từ A1 tới D1

                //range.CellStyle.Border.BorderAround(ExcelBorderCellStyle.Thin);
                // Set PatternType
                worksheet.Range[4, 1, 4, 9].CellStyle.FillPattern = ExcelPattern.Solid;
                //worksheet.Range["A4:D4"].CellStyle.Borders.LineStyle = ExcelLineStyle.Thin;
                // Set Màu cho Background
                //worksheet.Range["A4:D4"].SetDefaultColumnStyle
                // Canh giữa cho các text
                worksheet.Range[4, 1, 4, 9].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                // Set Font cho text  trong Range hiện tại
                worksheet.Range[4, 1, 4, 9].CellStyle.Font.FontName = "Times New Roman";
                worksheet.Range[4, 1, 4, 9].CellStyle.Font.Size = 14;

                worksheet.Range[4, 1, 4, 9].CellStyle.Font.Bold = true;

                int row = 5;
                int i = 1;
                foreach (var item in List)
                {
                    {
                        worksheet.Range[row, 1, row, 9].CellStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                        worksheet.Range[row, 1, row, 9].CellStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                        worksheet.Range[row, 1, row, 9].CellStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                        worksheet.Range[row, 1, row, 9].CellStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                        worksheet.Range[row, 1].Value = i.ToString();
                        worksheet.Range[row, 1].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                        worksheet.Range[row, 2].Text = item.Ma;
                        worksheet.Range[row, 3].Text = item.HoTen;
                        worksheet.Range[row, 4].Text = item.GioiTinh == null ? "" : (item.GioiTinh == true ? "Nam" : "Nữ");
                        worksheet.Range[row, 5].Text = DateTime.Parse(item.NgaySinh.ToString()).ToShortDateString();
                        worksheet.Range[row, 6].Text = item.DonViID != null ? item.dmDonVi.TenDonVi : "";
                        worksheet.Range[row, 7].Text = item.ChucVuID != null ? item.dmChucVu.TenChucVu : "";
                        worksheet.Range[row, 8].Text = item.KieuCanBo != null ? item.dmKieuCanBo.TenKieuCanBo : "";
                        worksheet.Range[row, 9].Text = item.TrinhDoID != null ? item.dmTrinhDo.TenTrinhDo : "";
                        i++;
                        row++;
                    }
                    //Save the workbook to disk in xlsx format
                    workbook.Version = ExcelVersion.Excel2016;
                    using (FileStream fileStream = new FileStream(_filePath, FileMode.Create, FileAccess.ReadWrite))
                    {
                        workbook.SaveAs(fileStream);
                    }
                }
                var errorMessage = "you can return the errors here!";
                //Return the Excel file name
                return Json(new { _fileName, errorMessage });
            }
        }

        [HttpGet]
        public ActionResult Download(string fileName)
        {
            byte[] fileByteArray = System.IO.File.ReadAllBytes(_filePath);
            System.IO.File.Delete(_filePath);
            return File(fileByteArray, "application/vnd.ms-excel", _fileName);
        }

    }
}
