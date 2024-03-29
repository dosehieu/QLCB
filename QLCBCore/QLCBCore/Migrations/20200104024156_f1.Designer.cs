﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLCBCore.Models;

namespace QLCBCore.Migrations
{
    [DbContext(typeof(QLCBDbContext))]
    [Migration("20200104024156_f1")]
    partial class f1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("BacLuong");

                    b.Property<string>("CMTND")
                        .HasMaxLength(15);

                    b.Property<int?>("CanNang");

                    b.Property<int?>("ChieuCao");

                    b.Property<int?>("ChucVuID");

                    b.Property<string>("CongViecDuocGiao");

                    b.Property<string>("CoquanTuyenDung")
                        .HasMaxLength(100);

                    b.Property<int?>("DanTocID");

                    b.Property<int?>("DanhHieuCaoNhatID");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(15);

                    b.Property<int?>("DonViID");

                    b.Property<int?>("DonviOldID");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("GhiChu")
                        .HasMaxLength(250);

                    b.Property<int?>("GiaDinhCSID");

                    b.Property<bool?>("GioiTinh");

                    b.Property<string>("HKTT")
                        .HasMaxLength(300);

                    b.Property<int?>("HangThuongBinhID");

                    b.Property<double?>("HeSo");

                    b.Property<string>("HinhAnh")
                        .HasMaxLength(150);

                    b.Property<int?>("HinhThucThiTuyenID");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("HocHamID");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("KhenThuong")
                        .HasMaxLength(250);

                    b.Property<int?>("KieuCanBo");

                    b.Property<string>("KyLuat")
                        .HasMaxLength(250);

                    b.Property<string>("LichSuBanThan")
                        .HasMaxLength(2000);

                    b.Property<string>("Ma")
                        .HasMaxLength(50);

                    b.Property<int?>("NgachID");

                    b.Property<DateTime?>("NgayCapCMT")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayChinhThuc")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayChuyenCtac")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayGiuNgach")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayHetHanHD")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayHuong")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayNghiHuu")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayNhapNgu")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayThoiViec")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayThongBaoNghiHuu")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayTuTran")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayTuyen")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayVaoDang")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayVe")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayVeCQ")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayXuatNgu")
                        .HasColumnType("DateTime");

                    b.Property<int?>("NgheNghiepID");

                    b.Property<string>("NhanXetDanhGia")
                        .HasMaxLength(500);

                    b.Property<int?>("NhomMauID");

                    b.Property<string>("NoiCapCMT")
                        .HasMaxLength(300);

                    b.Property<string>("NoiCapSoBHXH")
                        .HasMaxLength(250);

                    b.Property<string>("NoiO")
                        .HasMaxLength(300);

                    b.Property<string>("NoiSinhID")
                        .HasMaxLength(500);

                    b.Property<double?>("PhuCapChucVu");

                    b.Property<double?>("PhuCapKhac");

                    b.Property<int?>("QuanHamCaoNhatID");

                    b.Property<string>("QueQuanID")
                        .HasMaxLength(500);

                    b.Property<string>("RegionID")
                        .HasMaxLength(30);

                    b.Property<string>("SoBHXH")
                        .HasMaxLength(30);

                    b.Property<string>("SoBHYT")
                        .HasMaxLength(30);

                    b.Property<string>("SoHieu")
                        .HasMaxLength(50);

                    b.Property<string>("SoTruongCongTac");

                    b.Property<int?>("SucKhoeID");

                    b.Property<int?>("TDPhoThongID");

                    b.Property<string>("TenGoiKhac")
                        .HasMaxLength(100);

                    b.Property<int?>("TonGiaoID");

                    b.Property<int?>("TrangThai");

                    b.Property<int?>("TrinhDoID");

                    b.HasKey("ID");

                    b.HasIndex("ChucVuID");

                    b.HasIndex("DanTocID");

                    b.HasIndex("DonViID");

                    b.HasIndex("GiaDinhCSID");

                    b.HasIndex("HangThuongBinhID");

                    b.HasIndex("HocHamID");

                    b.HasIndex("KieuCanBo");

                    b.HasIndex("NgheNghiepID");

                    b.HasIndex("NhomMauID");

                    b.HasIndex("QuanHamCaoNhatID");

                    b.HasIndex("TDPhoThongID");

                    b.HasIndex("TonGiaoID");

                    b.HasIndex("TrinhDoID");

                    b.ToTable("CanBos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ChucVuID = 1,
                            DanTocID = 1,
                            DonViID = 1,
                            GioiTinh = true,
                            HinhThucThiTuyenID = 1,
                            HoTen = "Nguyễn Việt Hiếu",
                            IsDeleted = false,
                            KieuCanBo = 1,
                            NgayCapNhat = new DateTime(2020, 1, 4, 9, 41, 55, 745, DateTimeKind.Local).AddTicks(2223),
                            NgaySinh = new DateTime(2020, 1, 4, 9, 41, 55, 746, DateTimeKind.Local).AddTicks(3034),
                            NgayTuyen = new DateTime(2020, 1, 4, 9, 41, 55, 746, DateTimeKind.Local).AddTicks(5058),
                            NgayVeCQ = new DateTime(2020, 1, 4, 9, 41, 55, 746, DateTimeKind.Local).AddTicks(5468),
                            TonGiaoID = 1,
                            TrangThai = 1,
                            TrinhDoID = 1
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

                    b.Property<DateTime?>("NgayBoNhiem");

                    b.Property<string>("NguoiKy");

                    b.Property<int?>("PhongBanID");

                    b.Property<float?>("PhuCapChucVu");

                    b.Property<string>("SoQuyetDinh");

                    b.Property<DateTime?>("TuNgay");

                    b.Property<bool?>("isLeader");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("ChucVuID");

                    b.HasIndex("PhongBanID");

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

                    b.Property<bool?>("isTapSu");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("NgachID");

                    b.ToTable("DienBienNgachBacs");
                });

            modelBuilder.Entity("QLCBCore.Models.NguoiDung", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday");

                    b.Property<int?>("DonViID");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<bool?>("Gender");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("NguoiDungs");
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

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("HinhThucKhenThuongID");

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

                    b.Property<byte?>("KyLuatID");

                    b.Property<DateTime?>("NgayKyLuat");

                    b.Property<string>("NoiDung");

                    b.Property<string>("SoQuyetDinh");

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("KyLuatID");

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

                    b.HasKey("ID");

                    b.HasIndex("CanBoID");

                    b.HasIndex("QuanHeGDID");

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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenChucVu = "Trưởng phòng"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenDanToc = "Kinh"
                        });
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
                            TenDonVi = "Phòng kế hoạch"
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.dmGiaDinhCS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenGiaDinhCS");

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

            modelBuilder.Entity("QLCBCore.Models.dmHinhThucThiTuyen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenHinhThucTT");

                    b.HasKey("ID");

                    b.ToTable("dmHinhThucThiTuyens");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenHinhThucTT = "Xét tuyển"
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.dmHocHam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenHocHam");

                    b.HasKey("ID");

                    b.ToTable("dmHocHams");
                });

            modelBuilder.Entity("QLCBCore.Models.dmKieuCanBo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenKieuCanBo");

                    b.HasKey("ID");

                    b.ToTable("dmKieuCanBo");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenKieuCanBo = "Công chức"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenNgheNghiep = "Phóng viên"
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.dmNhomMau", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenNhomMau");

                    b.HasKey("ID");

                    b.ToTable("dmNhomMaus");
                });

            modelBuilder.Entity("QLCBCore.Models.dmQuanHam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenQuanHam");

                    b.HasKey("ID");

                    b.ToTable("dmQuanHams");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenQuanHam = "Thiếu tướng"
                        });
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

            modelBuilder.Entity("QLCBCore.Models.dmTinhTrangSucKhoe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenTTSK");

                    b.HasKey("ID");

                    b.ToTable("dmTinhTrangSucKhoes");
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenTonGiao = "Không"
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.dmTrinhDo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("TenTrinhDo");

                    b.HasKey("ID");

                    b.ToTable("dmTrinhDos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenTrinhDo = "Tiến sĩ"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsDeleted = false,
                            TenTrinhDo = "12/12"
                        });
                });

            modelBuilder.Entity("QLCBCore.Models.CanBo", b =>
                {
                    b.HasOne("QLCBCore.Models.dmChucVu", "dmChucVu")
                        .WithMany()
                        .HasForeignKey("ChucVuID");

                    b.HasOne("QLCBCore.Models.dmDanToc", "dmDanToc")
                        .WithMany("CanBo")
                        .HasForeignKey("DanTocID");

                    b.HasOne("QLCBCore.Models.dmDonVi", "dmDonVi")
                        .WithMany("CanBo")
                        .HasForeignKey("DonViID");

                    b.HasOne("QLCBCore.Models.dmGiaDinhCS", "dmGiaDinhCS")
                        .WithMany("CanBo")
                        .HasForeignKey("GiaDinhCSID");

                    b.HasOne("QLCBCore.Models.dmHangThuongBinh", "dmHangThuongBinh")
                        .WithMany("CanBo")
                        .HasForeignKey("HangThuongBinhID");

                    b.HasOne("QLCBCore.Models.dmHocHam", "dmHocHam")
                        .WithMany()
                        .HasForeignKey("HocHamID");

                    b.HasOne("QLCBCore.Models.dmKieuCanBo", "dmKieuCanBo")
                        .WithMany("CanBo")
                        .HasForeignKey("KieuCanBo");

                    b.HasOne("QLCBCore.Models.dmNgheNghiep", "dmNgheNghiep")
                        .WithMany("CanBo")
                        .HasForeignKey("NgheNghiepID");

                    b.HasOne("QLCBCore.Models.dmNhomMau", "dmNhomMau")
                        .WithMany("CanBo")
                        .HasForeignKey("NhomMauID");

                    b.HasOne("QLCBCore.Models.dmQuanHam", "dmQuanHam")
                        .WithMany()
                        .HasForeignKey("QuanHamCaoNhatID");

                    b.HasOne("QLCBCore.Models.dmTrinhDoPT", "dmTrinhDoPT")
                        .WithMany("CanBo")
                        .HasForeignKey("TDPhoThongID");

                    b.HasOne("QLCBCore.Models.dmTonGiao", "dmTonGiao")
                        .WithMany("CanBo")
                        .HasForeignKey("TonGiaoID");

                    b.HasOne("QLCBCore.Models.dmTrinhDo", "dmTrinhDo")
                        .WithMany("CanBo")
                        .HasForeignKey("TrinhDoID");
                });

            modelBuilder.Entity("QLCBCore.Models.DienBienChucVu", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("DienBienChucVu")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmChucVu", "dmChucVu")
                        .WithMany("DienBienChucVu")
                        .HasForeignKey("ChucVuID");

                    b.HasOne("QLCBCore.Models.dmDonVi", "dmDonVi")
                        .WithMany("DienBienChucVu")
                        .HasForeignKey("PhongBanID");
                });

            modelBuilder.Entity("QLCBCore.Models.DienBienNgachBac", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("DienBienNgachBac")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmNgach", "dmNgach")
                        .WithMany("DienBienNgachBac")
                        .HasForeignKey("NgachID");
                });

            modelBuilder.Entity("QLCBCore.Models.QTCongTac", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QTCongTac")
                        .HasForeignKey("CanBoID");
                });

            modelBuilder.Entity("QLCBCore.Models.QTKhenThuong", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QTKhenThuong")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmHinhThucKhenThuong", "dmHinhThucKhenThuong")
                        .WithMany("QTKhenThuong")
                        .HasForeignKey("HinhThucKhenThuongID");
                });

            modelBuilder.Entity("QLCBCore.Models.QTKyLuat", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QTKyLuat")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmKyLuat", "dmKyLuat")
                        .WithMany("QTKyLuat")
                        .HasForeignKey("KyLuatID");
                });

            modelBuilder.Entity("QLCBCore.Models.QuanHeGiaDinh", b =>
                {
                    b.HasOne("QLCBCore.Models.CanBo", "CanBo")
                        .WithMany("QuanHeGiaDinh")
                        .HasForeignKey("CanBoID");

                    b.HasOne("QLCBCore.Models.dmQuanHeGiaDinh", "dmQuanHeGiaDinh")
                        .WithMany("QuanHeGiaDinh")
                        .HasForeignKey("QuanHeGDID");
                });
#pragma warning restore 612, 618
        }
    }
}
