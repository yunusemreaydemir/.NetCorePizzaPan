using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class mig_ourTeam_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialMedia2",
                table: "OurTeams",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "SocialMedia1",
                table: "OurTeams",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "OurTeams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "OurTeams");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "OurTeams",
                newName: "SocialMedia2");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "OurTeams",
                newName: "SocialMedia1");
        }
    }
}
