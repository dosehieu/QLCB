using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class f4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 2, 17, 3, 15, 129, DateTimeKind.Local).AddTicks(333), new DateTime(2020, 1, 2, 17, 3, 15, 130, DateTimeKind.Local).AddTicks(2941), new DateTime(2020, 1, 2, 17, 3, 15, 130, DateTimeKind.Local).AddTicks(6052), new DateTime(2020, 1, 2, 17, 3, 15, 130, DateTimeKind.Local).AddTicks(6662) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 1, 11, 35, 21, 410, DateTimeKind.Local).AddTicks(6748), new DateTime(2020, 1, 1, 11, 35, 21, 411, DateTimeKind.Local).AddTicks(7632), new DateTime(2020, 1, 1, 11, 35, 21, 411, DateTimeKind.Local).AddTicks(9107), new DateTime(2020, 1, 1, 11, 35, 21, 411, DateTimeKind.Local).AddTicks(9418) });
        }
    }
}
