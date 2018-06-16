using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CookiClickerEF.Migrations
{
    public partial class Addmoneysystemtomodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Upgrade",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "GameUpgrade",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Money",
                table: "Game",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Upgrade");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "GameUpgrade");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "Game");
        }
    }
}
