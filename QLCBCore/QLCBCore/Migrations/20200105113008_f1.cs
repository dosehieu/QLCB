using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class f1 : Migration
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
                    MaDonVi = table.Column<string>(maxLength: 30, nullable: true),
                    TenDonVi = table.Column<string>(maxLength: 150, nullable: true),
                    RegionID = table.Column<string>(nullable: true),
                    MaCha = table.Column<int>(nullable: true),
                    Leve = table.Column<int>(nullable: true),
                    STT = table.Column<int>(nullable: true),
                    TenVietTat = table.Column<string>(maxLength: 150, nullable: true),
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
                    TenGiaDinhCS = table.Column<string>(nullable: true),
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
                name: "dmHinhThucThiTuyens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenHinhThucTT = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucThiTuyens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmHocHams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenHocHam = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHocHams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmKieuCanBo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenKieuCanBo = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmKieuCanBo", x => x.ID);
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
                name: "dmNhomMaus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenNhomMau = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNhomMaus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dmQuanHams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenQuanHam = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmQuanHams", x => x.ID);
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
                name: "dmTinhTrangSucKhoes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTTSK = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTinhTrangSucKhoes", x => x.ID);
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
                name: "dmTrinhDos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTrinhDo = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrinhDos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<bool>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DonViID = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReportSLCLCBTheoDoTuoi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenDonVi = table.Column<string>(nullable: true),
                    TongSo = table.Column<int>(nullable: true),
                    PhuNu = table.Column<int>(nullable: true),
                    Nam = table.Column<int>(nullable: true),
                    Total20den30 = table.Column<int>(nullable: true),
                    Nam20den30 = table.Column<int>(nullable: true),
                    Nu20den30 = table.Column<int>(nullable: true),
                    Total30den50 = table.Column<int>(nullable: true),
                    Nam30den50 = table.Column<int>(nullable: true),
                    Nu30den50 = table.Column<int>(nullable: true),
                    Totaltren50 = table.Column<int>(nullable: true),
                    Namtren50 = table.Column<int>(nullable: true),
                    Nutren50 = table.Column<int>(nullable: true),
                    STT = table.Column<int>(nullable: true),
                    DonViID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportSLCLCBTheoDoTuoi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CanBos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ma = table.Column<string>(maxLength: 50, nullable: true),
                    SoHieu = table.Column<string>(maxLength: 50, nullable: true),
                    HoTen = table.Column<string>(maxLength: 100, nullable: false),
                    TenGoiKhac = table.Column<string>(maxLength: 100, nullable: true),
                    GioiTinh = table.Column<bool>(nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DanTocID = table.Column<int>(nullable: true),
                    TonGiaoID = table.Column<int>(nullable: true),
                    DonViID = table.Column<int>(nullable: true),
                    TrangThai = table.Column<int>(nullable: true),
                    DienThoai = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    CMTND = table.Column<string>(maxLength: 15, nullable: true),
                    NgayCapCMT = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NoiCapCMT = table.Column<string>(maxLength: 300, nullable: true),
                    NoiSinhID = table.Column<string>(maxLength: 500, nullable: true),
                    QueQuanID = table.Column<string>(maxLength: 500, nullable: true),
                    HKTT = table.Column<string>(maxLength: 300, nullable: true),
                    NoiO = table.Column<string>(maxLength: 300, nullable: true),
                    TDPhoThongID = table.Column<int>(nullable: true),
                    HocHamID = table.Column<int>(nullable: true),
                    HinhAnh = table.Column<string>(maxLength: 150, nullable: true),
                    NgheNghiepID = table.Column<int>(nullable: true),
                    CoquanTuyenDung = table.Column<string>(maxLength: 100, nullable: true),
                    NgayTuyen = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayVeCQ = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HinhThucThiTuyenID = table.Column<int>(nullable: true),
                    KieuCanBo = table.Column<int>(nullable: true),
                    NgayHetHanHD = table.Column<DateTime>(type: "DateTime", nullable: true),
                    CongViecDuocGiao = table.Column<string>(nullable: true),
                    SoTruongCongTac = table.Column<string>(nullable: true),
                    NgayVaoDang = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayChinhThuc = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayNhapNgu = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayXuatNgu = table.Column<DateTime>(type: "DateTime", nullable: true),
                    QuanHamCaoNhatID = table.Column<int>(nullable: true),
                    HangThuongBinhID = table.Column<int>(nullable: true),
                    GiaDinhCSID = table.Column<int>(nullable: true),
                    SucKhoeID = table.Column<int>(nullable: true),
                    ChieuCao = table.Column<int>(nullable: true),
                    CanNang = table.Column<int>(nullable: true),
                    NhomMauID = table.Column<int>(nullable: true),
                    SoBHXH = table.Column<string>(maxLength: 30, nullable: true),
                    NoiCapSoBHXH = table.Column<string>(maxLength: 250, nullable: true),
                    SoBHYT = table.Column<string>(maxLength: 30, nullable: true),
                    LichSuBanThan = table.Column<string>(maxLength: 2000, nullable: true),
                    GhiChu = table.Column<string>(maxLength: 250, nullable: true),
                    NhanXetDanhGia = table.Column<string>(maxLength: 500, nullable: true),
                    ChucVuID = table.Column<int>(nullable: true),
                    BacLuong = table.Column<int>(nullable: true),
                    NgachID = table.Column<int>(nullable: true),
                    HeSo = table.Column<double>(nullable: true),
                    NgayHuong = table.Column<DateTime>(type: "DateTime", nullable: true),
                    PhuCapChucVu = table.Column<double>(nullable: true),
                    PhuCapKhac = table.Column<double>(nullable: true),
                    TrinhDoID = table.Column<int>(nullable: true),
                    RegionID = table.Column<string>(maxLength: 30, nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DanhHieuCaoNhatID = table.Column<int>(nullable: true),
                    KhenThuong = table.Column<string>(maxLength: 250, nullable: true),
                    KyLuat = table.Column<string>(maxLength: 250, nullable: true),
                    NgayVe = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayThongBaoNghiHuu = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayNghiHuu = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayGiuNgach = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayThoiViec = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayChuyenCtac = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayTuTran = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DonviOldID = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanBos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CanBos_dmChucVus_ChucVuID",
                        column: x => x.ChucVuID,
                        principalTable: "dmChucVus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmDanTocs_DanTocID",
                        column: x => x.DanTocID,
                        principalTable: "dmDanTocs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmDonVis_DonViID",
                        column: x => x.DonViID,
                        principalTable: "dmDonVis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmGiaDinhCSs_GiaDinhCSID",
                        column: x => x.GiaDinhCSID,
                        principalTable: "dmGiaDinhCSs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmHangThuongBinhs_HangThuongBinhID",
                        column: x => x.HangThuongBinhID,
                        principalTable: "dmHangThuongBinhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmHocHams_HocHamID",
                        column: x => x.HocHamID,
                        principalTable: "dmHocHams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmKieuCanBo_KieuCanBo",
                        column: x => x.KieuCanBo,
                        principalTable: "dmKieuCanBo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmNgheNghieps_NgheNghiepID",
                        column: x => x.NgheNghiepID,
                        principalTable: "dmNgheNghieps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmNhomMaus_NhomMauID",
                        column: x => x.NhomMauID,
                        principalTable: "dmNhomMaus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmQuanHams_QuanHamCaoNhatID",
                        column: x => x.QuanHamCaoNhatID,
                        principalTable: "dmQuanHams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmTrinhDoPTs_TDPhoThongID",
                        column: x => x.TDPhoThongID,
                        principalTable: "dmTrinhDoPTs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmTonGiaos_TonGiaoID",
                        column: x => x.TonGiaoID,
                        principalTable: "dmTonGiaos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CanBos_dmTrinhDos_TrinhDoID",
                        column: x => x.TrinhDoID,
                        principalTable: "dmTrinhDos",
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
                    TuNgay = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "DateTime", nullable: true),
                    ChucVuID = table.Column<int>(nullable: true),
                    PhuCapChucVu = table.Column<float>(nullable: true),
                    Curent = table.Column<bool>(nullable: true),
                    isLeader = table.Column<bool>(nullable: true),
                    NgayBoNhiem = table.Column<DateTime>(type: "DateTime", nullable: true),
                    SoQuyetDinh = table.Column<string>(nullable: true),
                    NguoiKy = table.Column<string>(nullable: true),
                    PhongBanID = table.Column<int>(nullable: true),
                    IsDangDoan = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
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
                        name: "FK_DienBienChucVus_dmChucVus_ChucVuID",
                        column: x => x.ChucVuID,
                        principalTable: "dmChucVus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DienBienChucVus_dmDonVis_PhongBanID",
                        column: x => x.PhongBanID,
                        principalTable: "dmDonVis",
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
                    NgayHuong = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "DateTime", nullable: true),
                    ThoiHanNangBac = table.Column<int>(nullable: true),
                    DaVuotKhung = table.Column<bool>(nullable: true),
                    SoQD = table.Column<string>(nullable: true),
                    NguoiKy = table.Column<string>(nullable: true),
                    NgayKy = table.Column<DateTime>(type: "DateTime", nullable: true),
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
                    IsDeleted = table.Column<bool>(nullable: true)
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
                        name: "FK_DienBienNgachBacs_dmNgachs_NgachID",
                        column: x => x.NgachID,
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
                    NgayKyLuat = table.Column<DateTime>(type: "DateTime", nullable: true),
                    KyLuatID = table.Column<byte>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    IsCaoNhat = table.Column<bool>(nullable: true),
                    SoQuyetDinh = table.Column<string>(nullable: true),
                    CoQuanBanHanhQD = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
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
                        name: "FK_QTKyLuats_dmKyLuats_KyLuatID",
                        column: x => x.KyLuatID,
                        principalTable: "dmKyLuats",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    NgayKy = table.Column<DateTime>(type: "DateTime", nullable: true),
                    CoQuanBanHanhQD = table.Column<string>(nullable: true),
                    IsKhenThuong = table.Column<bool>(nullable: true),
                    MucKhenThuong = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QTKhenThuongs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QTKhenThuongs_CanBos_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "CanBos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QTKhenThuongs_dmHinhThucKhenThuongs_HinhThucKhenThuongID",
                        column: x => x.HinhThucKhenThuongID,
                        principalTable: "dmHinhThucKhenThuongs",
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
                    DiaChi = table.Column<string>(nullable: true)
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
                        name: "FK_QuanHeGiaDinhs_dmQuanHeGiaDinhs_QuanHeGDID",
                        column: x => x.QuanHeGDID,
                        principalTable: "dmQuanHeGiaDinhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "dmChucVus",
                columns: new[] { "ID", "HeSoPhuCap", "IsDangDoan", "IsDeleted", "MaChucVu", "STT", "TenChucVu", "TenVietTat", "iKieu", "iTruongPho" },
                values: new object[] { 1, null, null, false, null, null, "Trưởng phòng", null, null, null });

            migrationBuilder.InsertData(
                table: "dmDanTocs",
                columns: new[] { "ID", "DanTocItNguoi", "IsDeleted", "TenDanToc" },
                values: new object[] { 1, null, false, "Kinh" });

            migrationBuilder.InsertData(
                table: "dmDonVis",
                columns: new[] { "ID", "DonViAllID", "IsDeleted", "KieuDonvi", "Leve", "MaCha", "MaDonVi", "RegionID", "STT", "TenDonVi", "TenVietTat" },
                values: new object[] { 1, null, false, null, null, null, null, null, null, "Phòng kế hoạch", null });

            migrationBuilder.InsertData(
                table: "dmHinhThucThiTuyens",
                columns: new[] { "ID", "IsDeleted", "TenHinhThucTT" },
                values: new object[] { 1, false, "Xét tuyển" });

            migrationBuilder.InsertData(
                table: "dmKieuCanBo",
                columns: new[] { "ID", "IsDeleted", "TenKieuCanBo" },
                values: new object[] { 1, false, "Công chức" });

            migrationBuilder.InsertData(
                table: "dmNgheNghieps",
                columns: new[] { "ID", "IsDeleted", "MaNgheNghiep", "STT", "TenNgheNghiep" },
                values: new object[] { 1, false, null, null, "Phóng viên" });

            migrationBuilder.InsertData(
                table: "dmQuanHams",
                columns: new[] { "ID", "IsDeleted", "TenQuanHam" },
                values: new object[] { 1, false, "Thiếu tướng" });

            migrationBuilder.InsertData(
                table: "dmTonGiaos",
                columns: new[] { "ID", "IsDeleted", "TenTonGiao" },
                values: new object[] { 1, false, "Không" });

            migrationBuilder.InsertData(
                table: "dmTrinhDoPTs",
                columns: new[] { "ID", "IsDeleted", "TenTrinhDo" },
                values: new object[] { 1, false, "12/12" });

            migrationBuilder.InsertData(
                table: "dmTrinhDos",
                columns: new[] { "ID", "IsDeleted", "TenTrinhDo" },
                values: new object[] { 1, false, "Tiến sĩ" });

            migrationBuilder.InsertData(
                table: "CanBos",
                columns: new[] { "ID", "BacLuong", "CMTND", "CanNang", "ChieuCao", "ChucVuID", "CongViecDuocGiao", "CoquanTuyenDung", "DanTocID", "DanhHieuCaoNhatID", "DienThoai", "DonViID", "DonviOldID", "Email", "GhiChu", "GiaDinhCSID", "GioiTinh", "HKTT", "HangThuongBinhID", "HeSo", "HinhAnh", "HinhThucThiTuyenID", "HoTen", "HocHamID", "IsDeleted", "KhenThuong", "KieuCanBo", "KyLuat", "LichSuBanThan", "Ma", "NgachID", "NgayCapCMT", "NgayCapNhat", "NgayChinhThuc", "NgayChuyenCtac", "NgayGiuNgach", "NgayHetHanHD", "NgayHuong", "NgayNghiHuu", "NgayNhapNgu", "NgaySinh", "NgayThoiViec", "NgayThongBaoNghiHuu", "NgayTuTran", "NgayTuyen", "NgayVaoDang", "NgayVe", "NgayVeCQ", "NgayXuatNgu", "NgheNghiepID", "NhanXetDanhGia", "NhomMauID", "NoiCapCMT", "NoiCapSoBHXH", "NoiO", "NoiSinhID", "PhuCapChucVu", "PhuCapKhac", "QuanHamCaoNhatID", "QueQuanID", "RegionID", "SoBHXH", "SoBHYT", "SoHieu", "SoTruongCongTac", "SucKhoeID", "TDPhoThongID", "TenGoiKhac", "TonGiaoID", "TrangThai", "TrinhDoID" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Nguyễn Việt Hiếu", null, false, null, 1, null, null, "NVH1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 135, DateTimeKind.Local).AddTicks(7430), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 137, DateTimeKind.Local).AddTicks(4114), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 137, DateTimeKind.Local).AddTicks(9777), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(1402), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(611), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 2, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Nguyễn Quang Huy", null, false, null, 1, null, null, "NQH1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(2984), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3046), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3095), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3110), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3102), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 3, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Ngô Ngọc Anh", null, false, null, 1, null, null, "NNA1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3125), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3130), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3133), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3135), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3134), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 4, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Nguyễn Quang Anh", null, false, null, 1, null, null, "NQA1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3138), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3141), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3144), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3147), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3145), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 5, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Nguyễn Quang Công", null, false, null, 1, null, null, "NQC1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3182), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3186), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3187), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3191), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3190), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 6, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Trần Quang Thắng", null, false, null, 1, null, null, "TQT1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3193), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3197), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3200), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3201), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3201), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 7, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Nguyễn Văn Anh", null, false, null, 1, null, null, "NVA1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3202), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3206), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3207), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3210), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3208), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 8, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Nguyễn Tuấn Quang", null, false, null, 1, null, null, "NTQ1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3212), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3215), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3216), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3220), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3219), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 9, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, true, null, null, null, null, 1, "Lê Đức Anh", null, false, null, 1, null, null, "LDA1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3222), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3225), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3227), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3229), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3228), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 10, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, false, null, null, null, null, 1, "Trần Thị Thảo", null, false, null, 1, null, null, "TTT1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3230), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3233), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3234), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3236), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3235), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 11, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, false, null, null, null, null, 1, "Nguyễn Mộng Điệp", null, false, null, 1, null, null, "NMD1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3237), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3240), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3242), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3244), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3244), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 },
                    { 12, null, null, null, null, 1, null, null, 1, null, null, 1, null, null, null, null, false, null, null, null, null, 1, "Nguyễn Lê Trang", null, false, null, 1, null, null, "NLT1", null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3254), null, null, null, null, null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3257), null, null, null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3260), null, new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3261), new DateTime(2020, 1, 5, 18, 30, 7, 138, DateTimeKind.Local).AddTicks(3260), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_ChucVuID",
                table: "CanBos",
                column: "ChucVuID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_DanTocID",
                table: "CanBos",
                column: "DanTocID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_DonViID",
                table: "CanBos",
                column: "DonViID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_GiaDinhCSID",
                table: "CanBos",
                column: "GiaDinhCSID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_HangThuongBinhID",
                table: "CanBos",
                column: "HangThuongBinhID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_HocHamID",
                table: "CanBos",
                column: "HocHamID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_KieuCanBo",
                table: "CanBos",
                column: "KieuCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_NgheNghiepID",
                table: "CanBos",
                column: "NgheNghiepID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_NhomMauID",
                table: "CanBos",
                column: "NhomMauID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_QuanHamCaoNhatID",
                table: "CanBos",
                column: "QuanHamCaoNhatID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_TDPhoThongID",
                table: "CanBos",
                column: "TDPhoThongID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_TonGiaoID",
                table: "CanBos",
                column: "TonGiaoID");

            migrationBuilder.CreateIndex(
                name: "IX_CanBos_TrinhDoID",
                table: "CanBos",
                column: "TrinhDoID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienChucVus_CanBoID",
                table: "DienBienChucVus",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienChucVus_ChucVuID",
                table: "DienBienChucVus",
                column: "ChucVuID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienChucVus_PhongBanID",
                table: "DienBienChucVus",
                column: "PhongBanID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienNgachBacs_CanBoID",
                table: "DienBienNgachBacs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_DienBienNgachBacs_NgachID",
                table: "DienBienNgachBacs",
                column: "NgachID");

            migrationBuilder.CreateIndex(
                name: "IX_QTCongTacs_CanBoID",
                table: "QTCongTacs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKyLuats_CanBoID",
                table: "QTKyLuats",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKyLuats_KyLuatID",
                table: "QTKyLuats",
                column: "KyLuatID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKhenThuongs_CanBoID",
                table: "QTKhenThuongs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QTKhenThuongs_HinhThucKhenThuongID",
                table: "QTKhenThuongs",
                column: "HinhThucKhenThuongID");

            migrationBuilder.CreateIndex(
                name: "IX_QuanHeGiaDinhs_CanBoID",
                table: "QuanHeGiaDinhs",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_QuanHeGiaDinhs_QuanHeGDID",
                table: "QuanHeGiaDinhs",
                column: "QuanHeGDID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DienBienChucVus");

            migrationBuilder.DropTable(
                name: "DienBienNgachBacs");

            migrationBuilder.DropTable(
                name: "dmHinhThucThiTuyens");

            migrationBuilder.DropTable(
                name: "dmTinhTrangSucKhoes");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "QTCongTacs");

            migrationBuilder.DropTable(
                name: "QTKyLuats");

            migrationBuilder.DropTable(
                name: "QTKhenThuongs");

            migrationBuilder.DropTable(
                name: "QuanHeGiaDinhs");

            migrationBuilder.DropTable(
                name: "ReportSLCLCBTheoDoTuoi");

            migrationBuilder.DropTable(
                name: "dmNgachs");

            migrationBuilder.DropTable(
                name: "dmKyLuats");

            migrationBuilder.DropTable(
                name: "dmHinhThucKhenThuongs");

            migrationBuilder.DropTable(
                name: "CanBos");

            migrationBuilder.DropTable(
                name: "dmQuanHeGiaDinhs");

            migrationBuilder.DropTable(
                name: "dmChucVus");

            migrationBuilder.DropTable(
                name: "dmDanTocs");

            migrationBuilder.DropTable(
                name: "dmDonVis");

            migrationBuilder.DropTable(
                name: "dmGiaDinhCSs");

            migrationBuilder.DropTable(
                name: "dmHangThuongBinhs");

            migrationBuilder.DropTable(
                name: "dmHocHams");

            migrationBuilder.DropTable(
                name: "dmKieuCanBo");

            migrationBuilder.DropTable(
                name: "dmNgheNghieps");

            migrationBuilder.DropTable(
                name: "dmNhomMaus");

            migrationBuilder.DropTable(
                name: "dmQuanHams");

            migrationBuilder.DropTable(
                name: "dmTrinhDoPTs");

            migrationBuilder.DropTable(
                name: "dmTonGiaos");

            migrationBuilder.DropTable(
                name: "dmTrinhDos");
        }
    }
}
