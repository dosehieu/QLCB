using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class f3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenGoiKhac",
                table: "CanBos",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoHieu",
                table: "CanBos",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegionID",
                table: "CanBos",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "CanBos",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KyLuat",
                table: "CanBos",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KhenThuong",
                table: "CanBos",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 1, 11, 35, 21, 410, DateTimeKind.Local).AddTicks(6748), new DateTime(2020, 1, 1, 11, 35, 21, 411, DateTimeKind.Local).AddTicks(7632), new DateTime(2020, 1, 1, 11, 35, 21, 411, DateTimeKind.Local).AddTicks(9107), new DateTime(2020, 1, 1, 11, 35, 21, 411, DateTimeKind.Local).AddTicks(9418) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenGoiKhac",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoHieu",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegionID",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KyLuat",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KhenThuong",
                table: "CanBos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 1, 11, 30, 11, 681, DateTimeKind.Local).AddTicks(4172), new DateTime(2020, 1, 1, 11, 30, 11, 682, DateTimeKind.Local).AddTicks(5061), new DateTime(2020, 1, 1, 11, 30, 11, 682, DateTimeKind.Local).AddTicks(6751), new DateTime(2020, 1, 1, 11, 30, 11, 682, DateTimeKind.Local).AddTicks(7225) });
        }
    }
}
