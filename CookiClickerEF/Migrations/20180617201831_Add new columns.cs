using Microsoft.EntityFrameworkCore.Migrations;

namespace CookiClickerEF.Migrations
{
    public partial class Addnewcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActiveAddition",
                table: "Upgrade",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Upgrade",
                nullable: true);
            

            migrationBuilder.AddColumn<int>(
                name: "PassiveAddition",
                table: "Upgrade",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Upgrade",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveAddition",
                table: "Upgrade");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Upgrade");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Upgrade");

            migrationBuilder.DropColumn(
                name: "PassiveAddition",
                table: "Upgrade");
        }
    }
}
