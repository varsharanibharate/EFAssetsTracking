using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFAssetsTracking.Migrations
{
    /// <inheritdoc />
    public partial class SeedingGadgetData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gadgets",
                columns: new[] { "Id", "Brand", "Currency", "ElectronicId", "Model", "Office", "Price" },
                values: new object[,]
                {
                    { 1, "MacBook", "SEK", 1, "SD", "Sweden", 300 },
                    { 2, "Samsung", "USD", 2, "SD", "USA", 100 },
                    { 3, "Motorolla", "INR", 2, "HD", "India", 3300 },
                    { 4, "Asus", "INR", 1, "HD", "India", 8000 },
                    { 5, "HP", "SEK", 1, "Note", "Sweden", 300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
