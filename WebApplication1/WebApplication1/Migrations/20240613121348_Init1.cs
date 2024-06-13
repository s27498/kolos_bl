using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 1, 1 },
                column: "Amount",
                value: 2);

            migrationBuilder.InsertData(
                table: "Backpacks",
                columns: new[] { "CharacterId", "ItemId", "Amount" },
                values: new object[] { 2, 2, 1 });

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

            migrationBuilder.UpdateData(
                table: "CharactersEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentWei", "MaxWeight" },
                values: new object[] { 10, 20 });

            migrationBuilder.UpdateData(
                table: "CharactersEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentWei", "MaxWeight" },
                values: new object[] { 15, 25 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Item 1");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Item 2");

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Title 1");

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Title 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 1, 1 },
                column: "Amount",
                value: 1);

            migrationBuilder.InsertData(
                table: "Backpacks",
                columns: new[] { "CharacterId", "ItemId", "Amount" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Character_Titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 3, 13, 39, 40, 812, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Character_Titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 8, 13, 39, 40, 812, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "CharactersEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentWei", "MaxWeight" },
                values: new object[] { 50, 100 });

            migrationBuilder.UpdateData(
                table: "CharactersEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentWei", "MaxWeight" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sword");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Staff");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { 3, "Shield", 8 });

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "King");

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Knight");

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Mage" });

            migrationBuilder.InsertData(
                table: "Backpacks",
                columns: new[] { "CharacterId", "ItemId", "Amount" },
                values: new object[] { 2, 3, 1 });
        }
    }
}
