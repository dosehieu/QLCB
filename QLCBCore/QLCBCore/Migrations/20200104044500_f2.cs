using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class f2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 4, 11, 44, 59, 627, DateTimeKind.Local).AddTicks(1913), new DateTime(2020, 1, 4, 11, 44, 59, 628, DateTimeKind.Local).AddTicks(3000), new DateTime(2020, 1, 4, 11, 44, 59, 628, DateTimeKind.Local).AddTicks(5112), new DateTime(2020, 1, 4, 11, 44, 59, 628, DateTimeKind.Local).AddTicks(5548) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "NgayCapNhat", "NgaySinh", "NgayTuyen", "NgayVeCQ" },
                values: new object[] { new DateTime(2020, 1, 4, 11, 44, 6, 3, DateTimeKind.Local).AddTicks(377), new DateTime(2020, 1, 4, 11, 44, 6, 4, DateTimeKind.Local).AddTicks(337), new DateTime(2020, 1, 4, 11, 44, 6, 4, DateTimeKind.Local).AddTicks(2371), new DateTime(2020, 1, 4, 11, 44, 6, 4, DateTimeKind.Local).AddTicks(2793) });
        }
    }
}
