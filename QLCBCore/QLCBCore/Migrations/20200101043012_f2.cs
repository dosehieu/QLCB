using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class f2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayXuatNgu",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVeCQ",
                table: "CanBos",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVe",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVaoDang",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTuyen",
                table: "CanBos",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTuTran",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThongBaoNghiHuu",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThoiViec",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "CanBos",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayNhapNgu",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayNghiHuu",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayHuong",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayHetHanHD",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayGiuNgach",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayChuyenCtac",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayChinhThuc",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapCMT",
                table: "CanBos",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 1, 11, 30, 11, 681, DateTimeKind.Local).AddTicks(4172), new DateTime(2020, 1, 1, 11, 30, 11, 682, DateTimeKind.Local).AddTicks(5061), new DateTime(2020, 1, 1, 11, 30, 11, 682, DateTimeKind.Local).AddTicks(6751), new DateTime(2020, 1, 1, 11, 30, 11, 682, DateTimeKind.Local).AddTicks(7225) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayXuatNgu",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVeCQ",
                table: "CanBos",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVe",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayVaoDang",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTuyen",
                table: "CanBos",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTuTran",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThongBaoNghiHuu",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThoiViec",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "CanBos",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayNhapNgu",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayNghiHuu",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayHuong",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayHetHanHD",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayGiuNgach",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayChuyenCtac",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayChinhThuc",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapCMT",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 1, 11, 21, 9, 524, DateTimeKind.Local).AddTicks(1112), new DateTime(2020, 1, 1, 11, 21, 9, 525, DateTimeKind.Local).AddTicks(7159), new DateTime(2020, 1, 1, 11, 21, 9, 526, DateTimeKind.Local).AddTicks(5), new DateTime(2020, 1, 1, 11, 21, 9, 526, DateTimeKind.Local).AddTicks(589) });
        }
    }
}
