using Microsoft.EntityFrameworkCore.Migrations;

namespace QLCBCore.Migrations
{
    public partial class addedDonViID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DonViID",
                table: "CanBos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "CanBos",
                columns: new[] { "ID", "DonViID" },
                values: new object[] { 1, 0 });

            migrationBuilder.InsertData(
                table: "CanBos",
                columns: new[] { "ID", "DonViID" },
                values: new object[] { 2, 0 });

            migrationBuilder.InsertData(
                table: "CanBos",
                columns: new[] { "ID", "DonViID" },
                values: new object[] { 3, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DonViID",
                table: "CanBos");
        }
    }
}
