using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CookiClickerEF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Game",
                        column: x => x.ParentId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Upgrade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DependencyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upgrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Upgrade_Upgrade",
                        column: x => x.DependencyId,
                        principalTable: "Upgrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameUpgrade",
                columns: table => new
                {
                    UpgradeId = table.Column<int>(nullable: false),
                    GameStateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameUpgrade", x => new { x.UpgradeId, x.GameStateId });
                    table.ForeignKey(
                        name: "FK_GameUpgrade_Game",
                        column: x => x.GameStateId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameUpgrade_Upgrade",
                        column: x => x.UpgradeId,
                        principalTable: "Upgrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_ParentId",
                table: "Game",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GameUpgrade_GameStateId",
                table: "GameUpgrade",
                column: "GameStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrade_DependencyId",
                table: "Upgrade",
                column: "DependencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameUpgrade");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Upgrade");
        }
    }
}
