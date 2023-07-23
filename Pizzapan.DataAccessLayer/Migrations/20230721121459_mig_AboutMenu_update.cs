using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class mig_AboutMenu_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutContent",
                table: "aboutMenus");

            migrationBuilder.DropColumn(
                name: "AboutTitle",
                table: "aboutMenus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutContent",
                table: "aboutMenus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutTitle",
                table: "aboutMenus",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
