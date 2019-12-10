using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class addmigrationf1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dmChucVus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenChucVu = table.Column<string>(nullable: true),
                    STT = table.Column<int>(nullable: true),
                    HeSoPhuCap = table.Column<decimal>(nullable: true),
                    TenVietTat = table.Column<string>(nullable: true),
                    iKieu = table.Column<byte>(nullable: true),
                    iTruongPho = table.Column<byte>(nullable: true),
                    MaChucVu = table.Column<string>(nullable: true),
                    IsDangDoan = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChucVus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmDanTocs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenDanToc = table.Column<string>(nullable: true),
                    DanTocItNguoi = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDanTocs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmDonVis",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaDonVi = table.Column<string>(nullable: true),
                    TenDonVi = table.Column<string>(nullable: true),
                    RegionID = table.Column<string>(nullable: true),
                    MaCha = table.Column<int>(nullable: true),
                    Leve = table.Column<int>(nullable: true),
                    STT = table.Column<int>(nullable: true),
                    TenVietTat = table.Column<string>(nullable: true),
                    KieuDonvi = table.Column<byte>(nullable: true),
                    DonViAllID = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDonVis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmGiaDinhCSs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenGiaDinhChinhSach = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmGiaDinhCSs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmHangThuongBinhs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenHangThuongBinh = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHangThuongBinhs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucKhenThuongs",
                columns: table => new
                {
                    ID = table.Column<byte>(nullable: false),
                    MaHinhThucKhenThuong = table.Column<string>(nullable: true),
                    TenHinhThucKhenThuong = table.Column<string>(nullable: true),
                    IsKhenThuong = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucKhenThuongs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmKyLuats",
                columns: table => new
                {
                    ID = table.Column<byte>(nullable: false),
                    MaKyLuat = table.Column<string>(nullable: true),
                    TenKyLuat = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmKyLuats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmNgachs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NhomNgachID = table.Column<int>(nullable: true),
                    MaNgach = table.Column<string>(nullable: true),
                    TenNgach = table.Column<string>(nullable: true),
                    LoaiNgach = table.Column<string>(nullable: true),
                    PCVK = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNgachs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmNgheNghieps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenNgheNghiep = table.Column<string>(nullable: true),
                    STT = table.Column<int>(nullable: true),
                    MaNgheNghiep = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNgheNghieps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmQuanHeGiaDinhs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenQuanHeGD = table.Column<string>(nullable: true),
                    ThuTu = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmQuanHeGiaDinhs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmTonGiaos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTonGiao = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTonGiaos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmTrinhDoPTs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTrinhDo = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrinhDoPTs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QTKhenThuongs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBoID = table.Column<int>(nullable: true),
                    HinhThucKhenThuongID = table.Column<byte>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    NgayKhenThuong = table.Column<string>(nullable: true),
                    IsCaoNhat = table.Column<bool>(nullable: true),
                    SoQuyetDinh = table.Column<string>(nullable: true),
                    NgayKy = table.Column<DateTime>(nullable: true),
                    CoQuanBanHanhQD = table.Column<string>(nullable: true),
                    IsKhenThuong = table.Column<bool>(nullable: true),
                    MucKhenThuong = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    dmHinhThucKhenThuongID = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QTKhenThuongs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QTKhenThuongs_dmHinhThucKhenThuongs_dmHinhThucKhenThuongID",
                        column: x => x.dmHinhThucKhenThuongID,
                        principalTable: "dmHinhThucKhenThuongs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CanBos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ma = table.Column<string>(nullable: true),
                    SoHieu = table.Column<string>(nullable: true),
                    HoTen = table.Column<string>(nullable: true),
                    TenGoiKhac = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: true),
                    GioiTinh = table.Column<bool>(nullable: true),
                    NoiSinhID = table.Column<string>(nullable: true),
                    QueQuanID = table.Column<string>(nullable: true),
                    DanTocID = table.Column<int>(nullable: true),
                    TonGiaoID = table.Column<int>(nullable: true),
                    HKTT = table.Column<string>(nullable: true),
                    NoiO = table.Column<string>(nullable: true),
                    NgheNghiepID = table.Column<int>(nullable: true),
                    NgayTD = table.Column<DateTime>(nullable: true),
                    CongViecChinh = table.Column<string>(nullable: true),
                    ChucVuID = table.Column<int>(nullable: true),
                    BacLuong = table.Column<int>(nullable: true),
                    NgachID = table.Column<int>(nullable: true),
                    HeSo = table.Column<double>(nullable: true),
                    NgayHuong = table.Column<DateTime>(nullable: true),
                    PhuCapChucVu = table.Column<double>(nullable: true),
                    PhuCapKhac = table.Column<double>(nullable: true),
                    TDPhoThongID = table.Column<int>(nullable: true),
                    TrinhDoID = table.Column<int>(nullable: true),
                    ChuyenNganhID = table.Column<int>(nullable: true),
                    LyLuanChinhTriID = table.Column<int>(nullable: true),
                    QuanLyNNID = table.Column<int>(nullable: true),
                    NgoaiNguID = table.Column<int>(nullable: true),
                    NgoaiNguKhacID = table.Column<int>(nullable: true),
                    TinHocID = table.Column<int>(nullable: true),
                    NgayVaoDang = table.Column<DateTime>(nullable: true),
                    NgayChinhThuc = table.Column<DateTime>(nullable: true),
                    RegionID = table.Column<string>(nullable: true),
                    DonViID = table.Column<int>(nullable: true),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    HinhThucTDID = table.Column<int>(nullable: true),
                    HSCLBL = table.Column<double>(nullable: true),
                    ChucDanhKhoaHocID = table.Column<int>(nullable: true),
                    NgayNhapNgu = table.Column<DateTime>(nullable: true),
                    NgayXuatNgu = table.Column<DateTime>(nullable: true),
                    QuanHamCaoNhatID = table.Column<int>(nullable: true),
                    DanhHieuCaoNhatID = table.Column<int>(nullable: true),
                    SoTruongCongTac = table.Column<string>(nullable: true),
                    KhenThuong = table.Column<string>(nullable: true),
                    KyLuat = table.Column<string>(nullable: true),
                    SucKhoeID = table.Column<int>(nullable: true),
                    ChieuCao = table.Column<int>(nullable: true),
                    CanNang = table.Column<int>(nullable: true),
                    NhomMauID = table.Column<int>(nullable: true),
                    HangThuongBinhID = table.Column<int>(nullable: true),
                    GiaDinhCSID = table.Column<int>(nullable: true),
                    CMTND = table.Column<string>(nullable: true),
                    NgayVe = table.Column<DateTime>(nullable: true),
                    NgayThamGiaBHXH = table.Column<DateTime>(nullable: true),
                    NgayCapCMT = table.Column<DateTime>(nullable: true),
                    NoiCapCMT = table.Column<string>(nullable: true),
                    SoBHXH = table.Column<string>(nullable: true),
                    SoBHYT = table.Column<string>(nullable: true),
                    NoiDKBHYT = table.Column<string>(nullable: true),
                    LichSuBanThan = table.Column<string>(nullable: true),
                    NhanXetDanhGia = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: true),
                    KieuCanBo = table.Column<int>(nullable: true),
                    NgayThongBaoNghiHuu = table.Column<DateTime>(nullable: true),
                    NgayNghiHuu = table.Column<DateTime>(nullable: true),
                    TrangThaiTBNH = table.Column<bool>(nullable: true),
                    AnNinhQP = table.Column<bool>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    NoiCapSoBHXH = table.Column<string>(nullable: true),
                    NgayGiuNgach = table.Column<DateTime>(nullable: true),
                    NgayThoiViec = table.Column<DateTime>(nullable: true),
                    NgayChuyenCtac = table.Column<DateTime>(nullable: true),
                    NgayTuTran = table.Column<DateTime>(nullable: true),
                    DonviOldID = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DienThoai = table.Column<string>(nullable: true),
                    NgayHetHanHD = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    IsShow = table.Column<bool>(nullable: true),
                    NgayPhongHocHam = table.Column<DateTime>(nullable: true),
                    DotTuyenDungID = table.Column<int>(nullable: true),
                    dmDanTocID = table.Column<int>(nullable: true),
                    dmDonViID = table.Column<int>(nullable: true),
                    dmGiaDinhCSID = table.Column<int>(nullable: true),
                    dmHangThuongBinhID = table.Column<int>(nullable: true),
                    dmNgheNghiepID = table.Column<int>(nullable: true),
                    dmTonGiaoID = table.Column<int>(nullable: true),
                    dmTrinhDoPTID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanBos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CanBos_dmDanTocs_dmDanTocID",
                        column: x => x.dmDanTocID,
                        principalTable: "dmDanTocs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmDonVis_dmDonViID",
                        column: x => x.dmDonViID,
                        principalTable: "dmDonVis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmGiaDinhCSs_dmGiaDinhCSID",
                        column: x => x.dmGiaDinhCSID,
                        principalTable: "dmGiaDinhCSs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmHangThuongBinhs_dmHangThuongBinhID",
                        column: x => x.dmHangThuongBinhID,
                        principalTable: "dmHangThuongBinhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmNgheNghieps_dmNgheNghiepID",
                        column: x => x.dmNgheNghiepID,
                        principalTable: "dmNgheNghieps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmTonGiaos_dmTonGiaoID",
                        column: x => x.dmTonGiaoID,
                        principalTable: "dmTonGiaos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmTrinhDoPTs_dmTrinhDoPTID",
                        column: x => x.dmTrinhDoPTID,
                        principalTable: "dmTrinhDoPTs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DienBienChucVus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBoID = table.Column<int>(nullable: true),
                    TuNgay = table.Column<DateTime>(nullable: true),
                    DenNgay = table.Column<DateTime>(nullable: true),
                    ChucVuID = table.Column<int>(nullable: true),
                    PhuCapChucVu = table.Column<float>(nullable: true),
                    Curent = table.Column<bool>(nullable: true),
                    isLeader = table.Column<bool>(nullable: true),
                    NgayBoNhiem = table.Column<DateTime>(nullable: true),
                    SoQuyetDinh = table.Column<string>(nullable: true),
                    NguoiKy = table.Column<string>(nullable: true),
                    PhongBanID = table.Column<int>(nullable: true),
                    IsDangDoan = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    IsShow = table.Column<bool>(nullable: true),
                    dmChucVuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienBienChucVus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DienBienChucVus_CanBos_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "CanBos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DienBienChucVus_dmChucVus_dmChucVuID",
                        column: x => x.dmChucVuID,
                        principalTable: "dmChucVus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DienBienNgachBacs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBoID = table.Column<int>(nullable: true),
                    NgachID = table.Column<int>(nullable: true),
                    BacLuong = table.Column<int>(nullable: true),
                    NgayHuong = table.Column<DateTime>(nullable: true),
                    NgayKetThuc = table.Column<DateTime>(nullable: true),
                    ThoiHanNangBac = table.Column<int>(nullable: true),
                    DaVuotKhung = table.Column<bool>(nullable: true),
                    SoQD = table.Column<string>(nullable: true),
                    NguoiKy = table.Column<string>(nullable: true),
                    NgayKy = table.Column<DateTime>(nullable: true),
                    HSCLBL = table.Column<double>(nullable: true),
                    HeSo = table.Column<float>(nullable: true),
                    PhuCapVuotKhung = table.Column<decimal>(nullable: true),
                    PhuCapKhac = table.Column<decimal>(nullable: true),
                    LuongCoBan = table.Column<decimal>(nullable: true),
                    Kieu = table.Column<int>(nullable: true),
                    Curent = table.Column<bool>(nullable: true),
                    NgachCuID = table.Column<int>(nullable: true),
                    PhuCapChucVu = table.Column<decimal>(nullable: true),
                    PhuCapTrachNhiem = table.Column<decimal>(nullable: true),
                    PhuCapKhuVuc = table.Column<decimal>(nullable: true),
                    BatDauGiuNgach = table.Column<bool>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    isTapSu = table.Column<bool>(nullable: true),
                    PhuCapUuDai = table.Column<decimal>(nullable: true),
                    DonGiaDocHai = table.Column<decimal>(nullable: true),
                    PhuCapDocHai = table.Column<decimal>(nullable: true),
                    NgayBatDauGiuNgach = table.Column<DateTime>(nullable: true),
                    ThoiGianTapSu = table.Column<int>(nullable: true),
                    PhuCapThuHut = table.Column<decimal>(nullable: true),
                    PhuCapLuuDong = table.Column<decimal>(nullable: true),
                    HeSoChenhLechBaoLuu = table.Column<decimal>(nullable: true),
                    PhuCapDacBiet = table.Column<decimal>(nullable: true),
                    PhuCapThamNien = table.Column<decimal>(nullable: true),
                    ThamNienVungKhoKhan = table.Column<double>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    IsShow = table.Column<bool>(nullable: true),
                    dmNgachID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienBienNgachBacs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DienBienNgachBacs_CanBos_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "CanBos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DienBienNgachBacs_dmNgachs_dmNgachID",
                        column: x => x.dmNgachID,
                        principalTable: "dmNgachs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QTCongTacs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBoID = table.Column<int>(nullable: true),
                    TuThangNam = table.Column<string>(nullable: true),
                    DenThangNam = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    isChuyenCT = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QTCongTacs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QTCongTacs_CanBos_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "CanBos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QTKyLuats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBoID = table.Column<int>(nullable: true),
                    NgayKyLuat = table.Column<DateTime>(nullable: true),
                    KyLuatID = table.Column<byte>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    IsCaoNhat = table.Column<bool>(nullable: true),
                    SoQuyetDinh = table.Column<string>(nullable: true),
                    CoQuanBanHanhQD = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    IsShow = table.Column<bool>(nullable: true),
                    dmKyLuatID = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QTKyLuats", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QTKyLuats_CanBos_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "CanBos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QTKyLuats_dmKyLuats_dmKyLuatID",
                        column: x => x.dmKyLuatID,
                        principalTable: "dmKyLuats",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuanHeGiaDinhs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBoID = table.Column<int>(nullable: true),
                    QuanHeGDID = table.Column<int>(nullable: true),
                    HoTen = table.Column<string>(nullable: true),
                    NamSinh = table.Column<string>(nullable: true),
                    NgheNghiep = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    ThongTinKhac = table.Column<string>(nullable: true),
                    ThongTinTCXH = table.Column<string>(nullable: true),
                    QueQuan = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ChucVu = table.Column<string>(nullable: true),
                    CoQuan = table.Column<string>(nullable: true),
                    HoKhau = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    dmQuanHeGiaDinhID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHeGiaDinhs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QuanHeGiaDinhs_CanBos_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "CanBos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuanHeGiaDinhs_dmQuanHeGiaDinhs_dmQuanHeGiaDinhID",
                        column: x => x.dmQuanHeGiaDinhID,
                        principalTable: "dmQuanHeGiaDinhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CanBos",
                columns: new[] { "ID", "AnNinhQP", "BacLuong", "CMTND", "CanNang", "ChieuCao", "ChucDanhKhoaHocID", "ChucVuID", "ChuyenNganhID", "CongViecChinh", "DanTocID", "DanhHieuCaoNhatID", "DienThoai", "DonViID", "DonviOldID", "DotTuyenDungID", "Email", "GhiChu", "GiaDinhCSID", "GioiTinh", "HKTT", "HSCLBL", "HangThuongBinhID", "HeSo", "HinhAnh", "HinhThucTDID", "HoTen", "IsDeleted", "IsShow", "KhenThuong", "KieuCanBo", "KyLuat", "LichSuBanThan", "LyLuanChinhTriID", "Ma", "NgachID", "NgayCapCMT", "NgayCapNhat", "NgayChinhThuc", "NgayChuyenCtac", "NgayGiuNgach", "NgayHetHanHD", "NgayHuong", "NgayNghiHuu", "NgayNhapNgu", "NgayPhongHocHam", "NgaySinh", "NgayTD", "NgayThamGiaBHXH", "NgayThoiViec", "NgayThongBaoNghiHuu", "NgayTuTran", "NgayVaoDang", "NgayVe", "NgayXuatNgu", "NgheNghiepID", "NgoaiNguID", "NgoaiNguKhacID", "NhanXetDanhGia", "NhomMauID", "NoiCapCMT", "NoiCapSoBHXH", "NoiDKBHYT", "NoiO", "NoiSinhID", "PhuCapChucVu", "PhuCapKhac", "QuanHamCaoNhatID", "QuanLyNNID", "QueQuanID", "RegionID", "SoBHXH", "SoBHYT", "SoHieu", "SoTruongCongTac", "SucKhoeID", "TDPhoThongID", "TenGoiKhac", "TinHocID", "TonGiaoID", "TrangThai", "TrangThaiTBNH", "TrinhDoID", "dmDanTocID", "dmDonViID", "dmGiaDinhCSID", "dmHangThuongBinhID", "dmNgheNghiepID", "dmTonGiaoID", "dmTrinhDoPTID" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "John", false, true, null, null, null, null, null, null, null, null, new DateTime(2019, 12, 9, 0, 29, 50, 261, DateTimeKind.Local).AddTicks(9112), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "Chris", false, true, null, null, null, null, null, null, null, null, new DateTime(2019, 12, 9, 0, 29, 50, 262, DateTimeKind.Local).AddTicks(9681), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "Mukesh", false, true, null, null, null, null, null, null, null, null, new DateTime(2019, 12, 9, 0, 29, 50, 262, DateTimeKind.Local).AddTicks(9713), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "dmDonVis",
                columns: new[] { "ID", "DonViAllID", "IsDeleted", "KieuDonvi", "Leve", "MaCha", "MaDonVi", "RegionID", "STT", "TenDonVi", "TenVietTat" },
                values: new object[,]
                {
                    { 1, null, false, null, null, null, null, null, null, "Ban giám đốc", null },
                    { 2, null, false, null, null, null, null, null, null, "Ban thư kí", null },
                    { 3, null, false, null, null, null, null, null, null, "Nhân viên", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmDanTocID",
                table: "CanBos",
                column: "dmDanTocID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmDonViID",
                table: "CanBos",
                column: "dmDonViID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmGiaDinhCSID",
                table: "CanBos",
                column: "dmGiaDinhCSID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmHangThuongBinhID",
                table: "CanBos",
                column: "dmHangThuongBinhID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmNgheNghiepID",
                table: "CanBos",
                column: "dmNgheNghiepID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmTonGiaoID",
                table: "CanBos",
                column: "dmTonGiaoID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_dmTrinhDoPTID",
                table: "CanBos",
                column: "dmTrinhDoPTID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienChucVus_CanBoID",
                table: "DienBienChucVus",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienChucVus_dmChucVuID",
                table: "DienBienChucVus",
                column: "dmChucVuID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienNgachBacs_CanBoID",
                table: "DienBienNgachBacs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienNgachBacs_dmNgachID",
                table: "DienBienNgachBacs",
                column: "dmNgachID");

            migrationBuilder.CreateIndex(
                name: "IX_QTCongTacs_CanBoID",
                table: "QTCongTacs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKhenThuongs_dmHinhThucKhenThuongID",
                table: "QTKhenThuongs",
                column: "dmHinhThucKhenThuongID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKyLuats_CanBoID",
                table: "QTKyLuats",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKyLuats_dmKyLuatID",
                table: "QTKyLuats",
                column: "dmKyLuatID");

            migrationBuilder.CreateIndex(
                name: "IX_QuanHeGiaDinhs_CanBoID",
                table: "QuanHeGiaDinhs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QuanHeGiaDinhs_dmQuanHeGiaDinhID",
                table: "QuanHeGiaDinhs",
                column: "dmQuanHeGiaDinhID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DienBienChucVus");

            migrationBuilder.DropTable(
                name: "DienBienNgachBacs");

            migrationBuilder.DropTable(
                name: "QTCongTacs");

            migrationBuilder.DropTable(
                name: "QTKhenThuongs");

            migrationBuilder.DropTable(
                name: "QTKyLuats");

            migrationBuilder.DropTable(
                name: "QuanHeGiaDinhs");

            migrationBuilder.DropTable(
                name: "dmChucVus");

            migrationBuilder.DropTable(
                name: "dmNgachs");

            migrationBuilder.DropTable(
                name: "dmHinhThucKhenThuongs");

            migrationBuilder.DropTable(
                name: "dmKyLuats");

            migrationBuilder.DropTable(
                name: "CanBos");

            migrationBuilder.DropTable(
                name: "dmQuanHeGiaDinhs");

            migrationBuilder.DropTable(
                name: "dmDanTocs");

            migrationBuilder.DropTable(
                name: "dmDonVis");

            migrationBuilder.DropTable(
                name: "dmGiaDinhCSs");

            migrationBuilder.DropTable(
                name: "dmHangThuongBinhs");

            migrationBuilder.DropTable(
                name: "dmNgheNghieps");

            migrationBuilder.DropTable(
                name: "dmTonGiaos");

            migrationBuilder.DropTable(
                name: "dmTrinhDoPTs");
        }
    }
}
