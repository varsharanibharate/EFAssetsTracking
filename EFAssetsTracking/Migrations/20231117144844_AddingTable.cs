using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFAssetsTracking.Migrations
{
    public partial class AddingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Electronics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Gadgets",
                newName: "PurchaseDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "Gadgets",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "Electronics",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "Electronics",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "Mobile" });

            migrationBuilder.InsertData(
                table: "Gadgets",
                columns: new[] { "Id", "Brand", "Currency", "Date", "ElectronicId", "Model", "Office", "Price" },
                values: new object[,]
                {
                    { 1, "MacBook", "SEK", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "SD", "Sweden", 300 },
                    { 2, "Samsung", "USD", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "SD", "USA", 100 },
                    { 3, "Motorolla", "INR", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "HD", "India", 3300 },
                    { 4, "Asus", "INR", new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "HD", "India", 8000 },
                    { 5, "HP", "SEK", new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Note", "Sweden", 300 }
                });
        }
    }
}
