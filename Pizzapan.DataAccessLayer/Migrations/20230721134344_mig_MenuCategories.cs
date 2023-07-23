using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class mig_MenuCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuCategoryID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    MenuCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.MenuCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenuCategoryID",
                table: "Products",
                column: "MenuCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MenuCategories_MenuCategoryID",
                table: "Products",
                column: "MenuCategoryID",
                principalTable: "MenuCategories",
                principalColumn: "MenuCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MenuCategories_MenuCategoryID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_MenuCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MenuCategoryID",
                table: "Products");
        }
    }
}
