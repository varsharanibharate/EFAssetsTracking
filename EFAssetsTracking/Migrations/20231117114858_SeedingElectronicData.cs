using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFAssetsTracking.Migrations
{
    /// <inheritdoc />
    public partial class SeedingElectronicData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Electronics",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Computer" },
                    { 2, "Mobile" }
                });
        }

        /// <inheritdoc />
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
