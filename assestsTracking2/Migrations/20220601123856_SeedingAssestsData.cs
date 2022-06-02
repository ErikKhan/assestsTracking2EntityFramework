using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assestsTracking2.Migrations
{
    public partial class SeedingAssestsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assests",
                columns: new[] { "Id", "Brand", "Currency", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[] { 4, "Samsung", "EUR", "S5", "Norway", 500f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008), "Phone" });

            migrationBuilder.InsertData(
                table: "Assests",
                columns: new[] { "Id", "Brand", "Currency", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[] { 5, "MAc", "EUR", "i7", "Sweden", 500f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), "Laptop" });

            migrationBuilder.InsertData(
                table: "Assests",
                columns: new[] { "Id", "Brand", "Currency", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[] { 6, "Nokia", "EUR", "3310", "Germany", 500f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009), "Phone" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assests",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
