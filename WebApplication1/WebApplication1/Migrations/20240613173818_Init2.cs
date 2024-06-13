using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character_Titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 13, 17, 38, 18, 499, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Character_Titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 13, 17, 38, 18, 499, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[,]
                {
                    { 3, "Item 3", 5 },
                    { 4, "Item 4", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Character_Titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 13, 12, 13, 48, 451, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Character_Titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 13, 12, 13, 48, 451, DateTimeKind.Utc).AddTicks(7228));
        }
    }
}
