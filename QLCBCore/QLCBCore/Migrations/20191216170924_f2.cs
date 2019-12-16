using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class f2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnNinhQP",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "CanNang",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "ChieuCao",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "ChucDanhKhoaHocID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "ChuyenNganhID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "DotTuyenDungID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "HSCLBL",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "HinhThucTDID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "IsShow",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "LyLuanChinhTriID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NgayNhapNgu",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NgayPhongHocHam",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NgayThamGiaBHXH",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NgayXuatNgu",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NgoaiNguID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NgoaiNguKhacID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NhomMauID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NoiCapSoBHXH",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "NoiDKBHYT",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "PhuCapKhac",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "QuanHamCaoNhatID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "QuanLyNNID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "SoBHXH",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "SoBHYT",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "SoTruongCongTac",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "SucKhoeID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "TinHocID",
                table: "CanBos");

            migrationBuilder.DropColumn(
                name: "TrangThaiTBNH",
                table: "CanBos");

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

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                column: "NgayCapNhat",
                value: new DateTime(2019, 12, 17, 0, 9, 23, 840, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 2,
                column: "NgayCapNhat",
                value: new DateTime(2019, 12, 17, 0, 9, 23, 841, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 3,
                column: "NgayCapNhat",
                value: new DateTime(2019, 12, 17, 0, 9, 23, 841, DateTimeKind.Local).AddTicks(3186));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.AddColumn<bool>(
                name: "AnNinhQP",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CanNang",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChieuCao",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChucDanhKhoaHocID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChuyenNganhID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DotTuyenDungID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HSCLBL",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HinhThucTDID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsShow",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LyLuanChinhTriID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayNhapNgu",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayPhongHocHam",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayThamGiaBHXH",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXuatNgu",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NgoaiNguID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NgoaiNguKhacID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NhomMauID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiCapSoBHXH",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiDKBHYT",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PhuCapKhac",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuanHamCaoNhatID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuanLyNNID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoBHXH",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoBHYT",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoTruongCongTac",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SucKhoeID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TinHocID",
                table: "CanBos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThaiTBNH",
                table: "CanBos",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "IsShow", "NgayCapNhat" },
                values: new object[] { true, new DateTime(2019, 12, 9, 0, 29, 50, 261, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "IsShow", "NgayCapNhat" },
                values: new object[] { true, new DateTime(2019, 12, 9, 0, 29, 50, 262, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "IsShow", "NgayCapNhat" },
                values: new object[] { true, new DateTime(2019, 12, 9, 0, 29, 50, 262, DateTimeKind.Local).AddTicks(9713) });
        }
    }
}
