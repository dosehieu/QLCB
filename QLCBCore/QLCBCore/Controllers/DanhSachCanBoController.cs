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
using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace QLCBCore.Controllers
{
    public class DanhSachCanBoController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        private readonly IHostingEnvironment _hostingEnvironment;
        private string _fileName;
        private string _filePath;
        private readonly QLCBDbContext _context;
        public GetStoredProcedure getStoredProcedure;
        public DanhSachCanBoController(QLCBDbContext context, IHostingEnvironment hostingEnvironment, IOptions<ConnectionString> config)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _fileName = "DanhSachCanBo" + DateTime.Today.ToString("dd-MM-yyyy") + ".xlsx";
            _filePath = string.Format("{0}/{1}", _hostingEnvironment.WebRootPath, _fileName);
            this.config = config;

        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CanBoSinhNhat(int? startMonth, int? endMonth, int? year)
        {
            if (startMonth != null)
            {
                startMonth = endMonth = DateTime.Now.Month;
                year = DateTime.Now.Year;
            }
            DateTime startDate = new DateTime(year ?? DateTime.Now.Year, startMonth ?? DateTime.Now.Month, 1);
            DateTime endDate = new DateTime(  year ?? DateTime.Now.Year, startMonth ?? DateTime.Now.Month, DateTime.DaysInMonth(year ?? DateTime.Now.Year, startMonth ?? DateTime.Now.Month));
            var List = await _context.CanBos.Where(n => n.IsDeleted == false && n.NgaySinh> startDate && n.NgaySinh < endDate)
                                            .Include(n => n.dmChucVu)
                                            .Include(n => n.dmDonVi)
                                            .Include(n => n.dmKieuCanBo)
                                            .Include(n => n.dmTrinhDo)
                                            .ToListAsync();
            ViewData["CountCB"] = List.Count;
            return View(List);
        }
        [HttpPost]
        public ActionResult ExportExcelCanBoSinhNhat()
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
                worksheet.Range[4, 1, 4, 9].RowHeight = 25;
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
        public ActionResult DownloadCanBoSinhNhat(string fileName)
        {
            byte[] fileByteArray = System.IO.File.ReadAllBytes(_filePath);
            System.IO.File.Delete(_filePath);
            return File(fileByteArray, "application/vnd.ms-excel", _fileName);
        }
        public IActionResult CanBoSapHetHanChucVu()
        {
            getStoredProcedure = new GetStoredProcedure(_context, config);
            List<CanBoSapHetHanChucVuVM> list = getStoredProcedure.GetListCanBoSapHetHanChucVu();
            ViewData["CountCBSHHCV"] = list.Count;
            return View(list);
        }
        
        public IActionResult CanBoNangLuong()
        {
            getStoredProcedure = new GetStoredProcedure(_context, config);
            List<CanBoNangLuongVM> list = getStoredProcedure.GetListCanBoNangLuong();
            ViewData["CountCBNL"] = list.Count;
            return View(list);
        }
        

    }
}