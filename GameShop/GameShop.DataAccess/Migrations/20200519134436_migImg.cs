using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.EFDataAccess.Migrations
{
    public partial class migImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgPath",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "Games",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "imgPath",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
