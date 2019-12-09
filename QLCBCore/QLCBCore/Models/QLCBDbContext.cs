using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QLCBDbContext : DbContext
    {
        public QLCBDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<CanBo> CanBos { get; set; }
        public DbSet<DienBienChucVu> DienBienChucVus { get; set; }
        public DbSet<DienBienNgachBac> DienBienNgachBacs { get; set; }
        public DbSet<dmChucVu> dmChucVus { get; set; }
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
        public DbSet<QTCongTac> QTCongTacs { get; set; }
        public DbSet<QTKhenThuong> QTKhenThuongs { get; set; }
        public DbSet<QTKyLuat> QTKyLuats { get; set; }
        public DbSet<QuanHeGiaDinh> QuanHeGiaDinhs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CanBo>().HasData(
                new CanBo() { ID = 1, HoTen = "John" },
                new CanBo() { ID = 2, HoTen = "Chris" },
                new CanBo() { ID = 3, HoTen = "Mukesh"});

            modelBuilder.Entity<dmDonVi>().HasData(
                new dmDonVi() { ID = 1, TenDonVi = "Ban giám đốc" },
                new dmDonVi() { ID = 2, TenDonVi = "Ban thư kí" },
                new dmDonVi() { ID = 3, TenDonVi = "Nhân viên" });
        }
    }
}
