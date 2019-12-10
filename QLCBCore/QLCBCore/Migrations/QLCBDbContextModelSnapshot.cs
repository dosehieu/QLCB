﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLCBCore.Models;

namespace QLCBCore.Migrations
{
    [DbContext(typeof(QLCBDbContext))]
    partial class QLCBDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLCBCore.Models.CanBo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AnNinhQP");

                    b.Property<int?>("BacLuong");

                    b.Property<string>("CMTND");

                    b.Property<int?>("CanNang");

                    b.Property<int?>("ChieuCao");

                    b.Property<int?>("ChucDanhKhoaHocID");

                    b.Property<int?>("ChucVuID");

                    b.Property<int?>("ChuyenNganhID");

                    b.Property<string>("CongViecChinh");

                    b.Property<int?>("DanTocID");

                    b.Property<int?>("DanhHieuCaoNhatID");

                    b.Property<string>("DienThoai");

                    b.Property<int?>("DonViID");

                    b.Property<int?>("DonviOldID");

                    b.Property<int?>("DotTuyenDungID");

                    b.Property<string>("Email");

                    b.Property<string>("GhiChu");

                    b.Property<int?>("GiaDinhCSID");

                    b.Property<bool?>("GioiTinh");

                    b.Property<string>("HKTT");

                    b.Property<double?>("HSCLBL");

                    b.Property<int?>("HangThuongBinhID");

                    b.Property<double?>("HeSo");

                    b.Property<string>("HinhAnh");

                    b.Property<int?>("HinhThucTDID");

                    b.Property<string>("HoTen");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsShow");

                    b.Property<string>("KhenThuong");

                    b.Property<int?>("KieuCanBo");

                    b.Property<string>("KyLuat");

                    b.Property<string>("LichSuBanThan");

                    b.Property<int?>("LyLuanChinhTriID");

                    b.Property<string>("Ma");

                    b.Property<int?>("NgachID");

                    b.Property<DateTime?>("NgayCapCMT");

                    b.Property<DateTime?>("NgayCapNhat");

                    b.Property<DateTime?>("NgayChinhThuc");

                    b.Property<DateTime?>("NgayChuyenCtac");

                    b.Property<DateTime?>("NgayGiuNgach");

                    b.Property<DateTime?>("NgayHetHanHD");

                    b.Property<DateTime?>("NgayHuong");

                    b.Property<DateTime?>("NgayNghiHuu");

                    b.Property<DateTime?>("NgayNhapNgu");

                    b.Property<DateTime?>("NgayPhongHocHam");

                    b.Property<DateTime?>("NgaySinh");

                    b.Property<DateTime?>("NgayTD");

                    b.Property<DateTime?>("NgayThamGiaBHXH");

                    b.Property<DateTime?>("NgayThoiViec");

                    b.Property<DateTime?>("NgayThongBaoNghiHuu");

                    b.Property<DateTime?>("NgayTuTran");

                    b.Property<DateTime?>("NgayVaoDang");

                    b.Property<DateTime?>("NgayVe");

                    b.Property<DateTime?>("NgayXuatNgu");

                    b.Property<int?>("NgheNghiepID");

                    b.Property<int?>("NgoaiNguID");

                    b.Property<int?>("NgoaiNguKhacID");

                    b.Property<string>("NhanXetDanhGia");

                    b.Property<int?>("NhomMauID");

                    b.Property<string>("NoiCapCMT");

                    b.Property<string>("NoiCapSoBHXH");

                    b.Property<string>("NoiDKBHYT");

                    b.Property<string>("NoiO");

                    b.Property<string>("NoiSinhID");

                    b.Property<double?>("PhuCapChucVu");

                    b.Property<double?>("PhuCapKhac");

                    b.Property<int?>("QuanHamCaoNhatID");

                    b.Property<int?>("QuanLyNNID");

                    b.Property<string>("QueQuanID");

                    b.Property<string>("RegionID");

                    b.Property<string>("SoBHXH");

                    b.Property<string>("SoBHYT");

                    b.Property<string>("SoHieu");

                    b.Property<string>("SoTruongCongTac");

                    b.Property<int?>("SucKhoeID");

                    b.Property<int?>("TDPhoThongID");

                    b.Property<string>("TenGoiKhac");

                    b.Property<int?>("TinHocID");

                    b.Property<int?>("TonGiaoID");

                    b.Property<int?>("TrangThai");

                    b.Property<bool?>("TrangThaiTBNH");

                    b.Property<int?>("TrinhDoID");

                    b.Property<int?>("dmDanTocID");

                    b.Property<int?>("dmDonViID");

                    b.Property<int?>("dmGiaDinhCSID");

                    b.Property<int?>("dmHangThuongBinhID");

                    b.Property<int?>("dmNgheNghiepID");

                    b.Property<int?>("dmTonGiaoID");

                    b.Property<int?>("dmTrinhDoPTID");

                    b.HasKey("ID");

                    b.HasIndex("dmDanTocID");

                    b.HasIndex("dmDonViID");

                    b.HasIndex("dmGiaDinhCSID");

                    b.HasIndex("dmHangThuongBinhID");

                    b.HasIndex("dmNgheNghiepID");

                    b.HasIndex("dmTonGiaoID");

                    b.HasIndex("dmTrinhDoPTID");

                    b.ToTable("CanBos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            HoTen = "John",
                            IsDeleted = false,
                            IsShow = true,
                            NgayCapNhat = new DateTime(2019, 12, 9, 0, 29, 50, 261, DateTimeKind.Local).AddTicks(9112)
                        },
                        new
                        {
                            ID = 2,
                            HoTen = "Chris",
                            IsDeleted = false,
                            IsShow = true,
                            NgayCapNhat = new DateTime(2019, 12, 9, 0, 29, 50, 262, DateTimeKind.Local).AddTicks(9681)
                        },
                        new
                        {
                            ID = 3,
                            HoTen = "Mukesh",
                            IsDeleted = false,
                            IsShow = true,
                            NgayCapNhat = new DateTime(2019, 12, 9, 0, 29, 50, 262, DateTimeKind.Local).AddTicks(9713)
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.DienBienChucVu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CanBoID");

                    b.Property<int?>("ChucVuID");

                    b.Property<bool?>("Curent");

                    b.Property<DateTime?>("DenNgay");

                    b.Property<bool?>("IsDangDoan");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsShow");

                    b.Property<DateTime?>("NgayBoNhiem");

                    b.Property<string>("NguoiKy");

                    b.Property<int?>("PhongBanID");

                    b.Property<float?>("PhuCapChucVu");

                    b.Property<string>("SoQuyetDinh");

                    b.Property<DateTime?>("TuNgay");

                    b.Property<int?>("dmChucVuID");

                    b.Property<bool?>("isLeader");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("dmChucVuID");

                    b.ToTable("DienBienChucVus");
                });

            modelBuilder.Entity("QLCBCore.Models.DienBienNgachBac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BacLuong");

                    b.Property<bool?>("BatDauGiuNgach");

                    b.Property<int?>("CanBoID");

                    b.Property<bool?>("Curent");

                    b.Property<bool?>("DaVuotKhung");

                    b.Property<decimal?>("DonGiaDocHai");

                    b.Property<string>("GhiChu");

                    b.Property<double?>("HSCLBL");

                    b.Property<float?>("HeSo");

                    b.Property<decimal?>("HeSoChenhLechBaoLuu");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsShow");

                    b.Property<int?>("Kieu");

                    b.Property<decimal?>("LuongCoBan");

                    b.Property<int?>("NgachCuID");

                    b.Property<int?>("NgachID");

                    b.Property<DateTime?>("NgayBatDauGiuNgach");

                    b.Property<DateTime?>("NgayHuong");

                    b.Property<DateTime?>("NgayKetThuc");

                    b.Property<DateTime?>("NgayKy");

                    b.Property<string>("NguoiKy");

                    b.Property<decimal?>("PhuCapChucVu");

                    b.Property<decimal?>("PhuCapDacBiet");

                    b.Property<decimal?>("PhuCapDocHai");

                    b.Property<decimal?>("PhuCapKhac");

                    b.Property<decimal?>("PhuCapKhuVuc");

                    b.Property<decimal?>("PhuCapLuuDong");

                    b.Property<decimal?>("PhuCapThamNien");

                    b.Property<decimal?>("PhuCapThuHut");

                    b.Property<decimal?>("PhuCapTrachNhiem");

                    b.Property<decimal?>("PhuCapUuDai");

                    b.Property<decimal?>("PhuCapVuotKhung");

                    b.Property<string>("SoQD");

                    b.Property<double?>("ThamNienVungKhoKhan");

                    b.Property<int?>("ThoiGianTapSu");

                    b.Property<int?>("ThoiHanNangBac");

                    b.Property<int?>("dmNgachID");

                    b.Property<bool?>("isTapSu");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("dmNgachID");

                    b.ToTable("DienBienNgachBacs");
                });

            modelBuilder.Entity("QLCBCore.Models.QTCongTac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CanBoID");

                    b.Property<string>("DenThangNam");

                    b.Property<string>("GhiChu");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TuThangNam");

                    b.Property<bool?>("isChuyenCT");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.ToTable("QTCongTacs");
                });

            modelBuilder.Entity("QLCBCore.Models.QTKhenThuong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CanBoID");

                    b.Property<string>("CoQuanBanHanhQD");

                    b.Property<byte?>("HinhThucKhenThuongID");

                    b.Property<bool?>("IsCaoNhat");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsKhenThuong");

                    b.Property<int?>("MucKhenThuong");

                    b.Property<string>("NgayKhenThuong");

                    b.Property<DateTime?>("NgayKy");

                    b.Property<string>("NoiDung");

                    b.Property<string>("SoQuyetDinh");

                    b.Property<byte?>("dmHinhThucKhenThuongID");

                    b.HasKey("ID");

                    b.HasIndex("dmHinhThucKhenThuongID");

                    b.ToTable("QTKhenThuongs");
                });

            modelBuilder.Entity("QLCBCore.Models.QTKyLuat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CanBoID");

                    b.Property<string>("CoQuanBanHanhQD");

                    b.Property<bool?>("IsCaoNhat");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsShow");

                    b.Property<byte?>("KyLuatID");

                    b.Property<DateTime?>("NgayKyLuat");

                    b.Property<string>("NoiDung");

                    b.Property<string>("SoQuyetDinh");

                    b.Property<byte?>("dmKyLuatID");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("dmKyLuatID");

                    b.ToTable("QTKyLuats");
                });

            modelBuilder.Entity("QLCBCore.Models.QuanHeGiaDinh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CanBoID");

                    b.Property<string>("ChucVu");

                    b.Property<string>("CoQuan");

                    b.Property<string>("DiaChi");

                    b.Property<string>("GhiChu");

                    b.Property<string>("HoKhau");

                    b.Property<string>("HoTen");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("NamSinh");

                    b.Property<string>("NgheNghiep");

                    b.Property<int?>("QuanHeGDID");

                    b.Property<string>("QueQuan");

                    b.Property<string>("ThongTinKhac");

                    b.Property<string>("ThongTinTCXH");

                    b.Property<int?>("Type");

                    b.Property<int?>("dmQuanHeGiaDinhID");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("dmQuanHeGiaDinhID");

                    b.ToTable("QuanHeGiaDinhs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmChucVu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("HeSoPhuCap");

                    b.Property<bool?>("IsDangDoan");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("MaChucVu");

                    b.Property<int?>("STT");

                    b.Property<string>("TenChucVu");

                    b.Property<string>("TenVietTat");

                    b.Property<byte?>("iKieu");

                    b.Property<byte?>("iTruongPho");

                    b.HasKey("ID");

                    b.ToTable("dmChucVus");
                });

            modelBuilder.Entity("QLCBCore.Models.dmDanToc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("DanTocItNguoi");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenDanToc");

                    b.HasKey("ID");

                    b.ToTable("dmDanTocs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmDonVi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonViAllID");

                    b.Property<bool?>("IsDeleted");

                    b.Property<byte?>("KieuDonvi");

                    b.Property<int?>("Leve");

                    b.Property<int?>("MaCha");

                    b.Property<string>("MaDonVi");

                    b.Property<string>("RegionID");

                    b.Property<int?>("STT");

                    b.Property<string>("TenDonVi");

                    b.Property<string>("TenVietTat");

                    b.HasKey("ID");

                    b.ToTable("dmDonVis");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenDonVi = "Ban giám đốc"
                        },
                        new
                        {
                            ID = 2,
                            IsDeleted = false,
                            TenDonVi = "Ban thư kí"
                        },
                        new
                        {
                            ID = 3,
                            IsDeleted = false,
                            TenDonVi = "Nhân viên"
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.dmGiaDinhCS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenGiaDinhChinhSach");

                    b.HasKey("ID");

                    b.ToTable("dmGiaDinhCSs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmHangThuongBinh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenHangThuongBinh");

                    b.HasKey("ID");

                    b.ToTable("dmHangThuongBinhs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmHinhThucKhenThuong", b =>
                {
                    b.Property<byte>("ID");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsKhenThuong");

                    b.Property<string>("MaHinhThucKhenThuong");

                    b.Property<string>("TenHinhThucKhenThuong");

                    b.HasKey("ID");

                    b.ToTable("dmHinhThucKhenThuongs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmKyLuat", b =>
                {
                    b.Property<byte>("ID");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("MaKyLuat");

                    b.Property<string>("TenKyLuat");

                    b.HasKey("ID");

                    b.ToTable("dmKyLuats");
                });

            modelBuilder.Entity("QLCBCore.Models.dmNgach", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("LoaiNgach");

                    b.Property<string>("MaNgach");

                    b.Property<int?>("NhomNgachID");

                    b.Property<int?>("PCVK");

                    b.Property<string>("TenNgach");

                    b.HasKey("ID");

                    b.ToTable("dmNgachs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmNgheNghiep", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("MaNgheNghiep");

                    b.Property<int?>("STT");

                    b.Property<string>("TenNgheNghiep");

                    b.HasKey("ID");

                    b.ToTable("dmNgheNghieps");
                });

            modelBuilder.Entity("QLCBCore.Models.dmQuanHeGiaDinh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenQuanHeGD");

                    b.Property<int?>("ThuTu");

                    b.HasKey("ID");

                    b.ToTable("dmQuanHeGiaDinhs");
                });

            modelBuilder.Entity("QLCBCore.Models.dmTonGiao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenTonGiao");

                    b.HasKey("ID");

                    b.ToTable("dmTonGiaos");
                });

            modelBuilder.Entity("QLCBCore.Models.dmTrinhDoPT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenTrinhDo");

                    b.HasKey("ID");

                    b.ToTable("dmTrinhDoPTs");
                });

            modelBuilder.Entity("QLCBCore.Models.CanBo", b =>
                {
                    b.HasOne("QLCBCore.Models.dmDanToc", "dmDanToc")
                        .WithMany("CanBo")
                        .HasForeignKey("dmDanTocID");

                    b.HasOne("QLCBCore.Models.dmDonVi", "dmDonVi")
                        .WithMany("CanBo")
                        .HasForeignKey("dmDonViID");

                    b.HasOne("QLCBCore.Models.dmGiaDinhCS", "dmGiaDinhCS")
                        .WithMany("CanBo")
                        .HasForeignKey("dmGiaDinhCSID");

                    b.HasOne("QLCBCore.Models.dmHangThuongBinh", "dmHangThuongBinh")
                        .WithMany("CanBo")
                        .HasForeignKey("dmHangThuongBinhID");

                    b.HasOne("QLCBCore.Models.dmNgheNghiep", "dmNgheNghiep")
                        .WithMany("CanBo")
                        .HasForeignKey("dmNgheNghiepID");

                    b.HasOne("QLCBCore.Models.dmTonGiao", "dmTonGiao")
                        .WithMany("CanBo")
                        .HasForeignKey("dmTonGiaoID");

                    b.HasOne("QLCBCore.Models.dmTrinhDoPT", "dmTrinhDoPT")
                        .WithMany("CanBo")
                        .HasForeignKey("dmTrinhDoPTID");
                });

            modelBuilder.Entity("QLCBCore.Models.DienBienChucVu", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("DienBienChucVu")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmChucVu", "dmChucVu")
                        .WithMany("DienBienChucVu")
                        .HasForeignKey("dmChucVuID");
                });

            modelBuilder.Entity("QLCBCore.Models.DienBienNgachBac", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("DienBienNgachBac")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmNgach", "dmNgach")
                        .WithMany()
                        .HasForeignKey("dmNgachID");
                });

            modelBuilder.Entity("QLCBCore.Models.QTCongTac", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QTCongTac")
                        .HasForeignKey("CanBoID");
                });

            modelBuilder.Entity("QLCBCore.Models.QTKhenThuong", b =>
                {
                    b.HasOne("QLCBCore.Models.dmHinhThucKhenThuong", "dmHinhThucKhenThuong")
                        .WithMany("QTKhenThuong")
                        .HasForeignKey("dmHinhThucKhenThuongID");
                });

            modelBuilder.Entity("QLCBCore.Models.QTKyLuat", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QTKyLuat")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmKyLuat", "dmKyLuat")
                        .WithMany("QTKyLuat")
                        .HasForeignKey("dmKyLuatID");
                });

            modelBuilder.Entity("QLCBCore.Models.QuanHeGiaDinh", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QuanHeGiaDinh")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmQuanHeGiaDinh", "dmQuanHeGiaDinh")
                        .WithMany("QuanHeGiaDinh")
                        .HasForeignKey("dmQuanHeGiaDinhID");
                });
#pragma warning restore 612, 618
        }
    }
}
