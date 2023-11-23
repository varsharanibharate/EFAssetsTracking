using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFAssetsTracking.Migrations
{
    public partial class SeedingDataToElectronic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Electronics",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "Electronics",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "Mobile" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
