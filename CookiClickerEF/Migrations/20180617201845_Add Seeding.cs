using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookiClickerEF.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "CreatedAt", "Money", "ParentId" },
                values: new object[] { 1, new DateTime(2018, 6, 17, 22, 18, 44, 963, DateTimeKind.Local), 0, null });

            migrationBuilder.InsertData(
                table: "Upgrade",
                columns: new[] { "Id", "ActiveAddition", "DependencyId", "FileName", "Name", "PassiveAddition", "Price" },
                values: new object[] { 1, 1, null, "upgrades/pointer.png", "Pointer", 0, 25 });

            migrationBuilder.InsertData(
                table: "Upgrade",
                columns: new[] { "Id", "ActiveAddition", "DependencyId", "FileName", "Name", "PassiveAddition", "Price" },
                values: new object[] { 2, 0, null, "upgrades/vbucks.png", "V-Bucks Generator", 1, 100 });

            migrationBuilder.InsertData(
                table: "Upgrade",
                columns: new[] { "Id", "ActiveAddition", "DependencyId", "FileName", "Name", "PassiveAddition", "Price" },
                values: new object[] { 3, 0, null, "upgrades/grandma.png", "Grandma", 5, 450 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Upgrade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Upgrade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Upgrade",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
