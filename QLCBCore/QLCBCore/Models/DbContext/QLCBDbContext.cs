using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLCBCore.Models.BaoCao;
using QLCBCore.ViewModels;

namespace QLCBCore.Models
{
    public class QLCBDbContext : DbContext
    {
        public QLCBDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //Danh mục
        public DbSet<CanBo> CanBos { get; set; }
        public DbSet<dmChucVu> dmChucVus { get; set; }
        public DbSet<dmTrinhDo> dmTrinhDos { get; set; }
        public DbSet<dmKieuCanBo> dmKieuCanBo { get; set; }
        public DbSet<dmNhomMau> dmNhomMaus { get; set; }
        public DbSet<dmHinhThucThiTuyen> dmHinhThucThiTuyens { get; set; }
        public DbSet<dmHocHam> dmHocHams { get; set; }
        public DbSet<dmDanToc> dmDanTocs { get; set; }
        public DbSet<dmDonVi> dmDonVis { get; set; }
        public DbSet<dmGiaDinhCS> dmGiaDinhCSs { get; set; }
        public DbSet<dmHangThuongBinh> dmHangThuongBinhs { get; set; }
        public DbSet<dmHinhThucKhenThuong> dmHinhThucKhenThuongs { get; set; }
        public DbSet<dmKyLuat> dmKyLuats { get; set; }
        public DbSet<dmNgach> dmNgachs { get; set; }
        public DbSet<dmNgheNghiep> dmNgheNghieps { get; set; }
        public DbSet<dmQuanHeGiaDinh> dmQuanHeGiaDinhs { get; set; }
        public DbSet<dmTonGiao> dmTonGiaos { get; set; }
        public DbSet<dmTrinhDoPT> dmTrinhDoPTs { get; set; }
        public DbSet<dmTinhTrangSucKhoe> dmTinhTrangSucKhoes { get; set; }
        public DbSet<dmQuanHam> dmQuanHams { get; set; }
        //Quá trình
        public DbSet<DienBienChucVu> DienBienChucVus { get; set; }
        public DbSet<DienBienNgachBac> DienBienNgachBacs { get; set; }
        public DbSet<QTCongTac> QTCongTacs { get; set; }
        public DbSet<QTKhenThuong> QTKhenThuongs { get; set; }
        public DbSet<QTKyLuat> QTKyLuats { get; set; }
        public DbSet<QuanHeGiaDinh> QuanHeGiaDinhs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CanBo>().HasData(
            //    new CanBo() {
            //        ID = 1,
            //        HoTen = "Nguyễn Việt Hiếu",
            //        GioiTinh = true,
            //        NgaySinh = DateTime.Now,
            //        TonGiaoID = 1,
            //        DanTocID = 1,
            //        DonViID = 1,
            //        TrangThai = 1,
            //        NgayTuyen = DateTime.Now,
            //        NgayVeCQ =DateTime.Now,
            //        HinhThucThiTuyenID=1,
            //        KieuCanBo =1,
            //        TrinhDoID=1,
            //        ChucVuID=1
            //    });

            //modelBuilder.Entity<dmDonVi>().HasData(
            //    new dmDonVi() { ID = 1, TenDonVi = "Ban giám đốc" },
            //    new dmDonVi() { ID = 2, TenDonVi = "Ban thư kí" },
            //    new dmDonVi() { ID = 3, TenDonVi = "Nhân viên" });

            //modelBuilder.Entity<dmDonVi>().HasData(
            //    new NguoiDung() { ID = 1,UserName = "hieu", Password = "E10ADC3949BA59ABBE56E057F20F883E" },
            //    new NguoiDung() { ID = 2, UserName = "huy", Password = "E10ADC3949BA59ABBE56E057F20F883E" },
            //    new NguoiDung() { ID = 3, UserName = "anh", Password = "E10ADC3949BA59ABBE56E057F20F883E" });
            modelBuilder.Entity<dmChucVu>().HasData(
                new dmChucVu() { ID = 1, TenChucVu = "Trưởng phòng" }
                );
            modelBuilder.Entity<dmDanToc>().HasData(
               new dmDanToc() { ID = 1, TenDanToc = "Kinh" }
               );
            modelBuilder.Entity<dmTrinhDo>().HasData(
              new dmTrinhDo() { ID = 1, TenTrinhDo = "Tiến sĩ" }
              );
            modelBuilder.Entity<dmTrinhDoPT>().HasData(
              new dmTrinhDoPT() { ID = 1, TenTrinhDo = "12/12" }
              );
            
            modelBuilder.Entity<dmNgheNghiep>().HasData(
              new dmNgheNghiep() { ID = 1, TenNgheNghiep = "Phóng viên" }
              );
            modelBuilder.Entity<dmQuanHam>().HasData(
              new dmQuanHam() { ID = 1, TenQuanHam = "Thiếu tướng" }
              );
            modelBuilder.Entity<dmKieuCanBo>().HasData(
              new dmKieuCanBo() { ID = 1, TenKieuCanBo = "Công chức" }
              );
            modelBuilder.Entity<dmDonVi>().HasData(
              new dmDonVi() { ID = 1, TenDonVi = "Phòng kế hoạch" }
              );
            
            modelBuilder.Entity<dmHinhThucThiTuyen>().HasData(
             new dmHinhThucThiTuyen() { ID = 1, TenHinhThucTT = "Xét tuyển" }
             );
            modelBuilder.Entity<dmTonGiao>().HasData(
             new dmTonGiao() { ID = 1, TenTonGiao = "Không" }
             );
            modelBuilder.Entity<CanBo>().HasData(
            new CanBo() { ID = 1,
                Ma="NVH1",
                HoTen = "Nguyễn Việt Hiếu",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo =1,
                ChucVuID=1,
                TrinhDoID=1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID =1,
            },
            new CanBo()
            {
                ID = 2,
                Ma = "NQH1",
                HoTen = "Nguyễn Quang Huy",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 3,
                Ma = "NNA1",
                HoTen = "Ngô Ngọc Anh",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 4,
                Ma = "NQA1",
                HoTen = "Nguyễn Quang Anh",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 5,
                Ma = "NQC1",
                HoTen = "Nguyễn Quang Công",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 6,
                Ma = "TQT1",
                HoTen = "Trần Quang Thắng",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 7,
                Ma = "NVA1",
                HoTen = "Nguyễn Văn Anh",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 8,
                Ma = "NTQ1",
                HoTen = "Nguyễn Tuấn Quang",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 9,
                Ma = "LDA1",
                HoTen = "Lê Đức Anh",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = true,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 10,
                Ma = "TTT1",
                HoTen = "Trần Thị Thảo",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = false,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 11,
                Ma = "NMD1",
                HoTen = "Nguyễn Mộng Điệp",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = false,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            },
            new CanBo()
            {
                ID = 12,
                Ma = "NLT1",
                HoTen = "Nguyễn Lê Trang",
                NgaySinh = DateTime.Now,
                DanTocID = 1,
                GioiTinh = false,
                DonViID = 1,
                KieuCanBo = 1,
                ChucVuID = 1,
                TrinhDoID = 1,
                NgayTuyen = DateTime.Now,
                NgayVeCQ = DateTime.Now,
                NgayVe = DateTime.Now,
                HinhThucThiTuyenID = 1,
            }
            );


        }
       
        public DbSet<QLCBCore.Models.BaoCao.ReportSLCLCBTheoDoTuoi> ReportSLCLCBTheoDoTuoi { get; set; }
       
<<<<<<< HEAD
        public DbSet<QLCBCore.Models.BaoCao.ReportCBThiDua> ReportCBThiDua { get; set; }
       
        public DbSet<QLCBCore.Models.BaoCao.ReportCBKyLuat> ReportCBKyLuat { get; set; }
=======
        public DbSet<QLCBCore.ViewModels.CanBoSapHetHanChucVuVM> CanBoSapHetHanChucVuVM { get; set; }
       
        public DbSet<QLCBCore.ViewModels.CanBoNangLuongVM> CanBoNangLuongVM { get; set; }
>>>>>>> 7756ad3e7dd943e52f145ad15c3384b9dc91abb1
    }
}
