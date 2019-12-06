using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class addHoten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HoTen",
                table: "CanBos",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1,
                column: "HoTen",
                value: "John");

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 2,
                column: "HoTen",
                value: "Chris");

            migrationBuilder.UpdateData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 3,
                column: "HoTen",
                value: "Mukesh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoTen",
                table: "CanBos");
        }
    }
}
