using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFAssetsTracking.Migrations
{
    public partial class SeedingDataToGadget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gadgets",
                columns: new[] { "Id", "Brand", "Currency", "ElectronicId", "Model", "Office", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { 1, "MacBook", "SEK", 1, "SD", "Sweden", 300, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Samsung", "USD", 2, "SD", "USA", 100, new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Motorolla", "INR", 2, "HD", "India", 3300, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Asus", "INR", 1, "HD", "India", 8000, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "HP", "SEK", 1, "Note", "Sweden", 300, new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

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
