using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.EFDataAccess.Migrations
{
    public partial class Wish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Games");
        }
    }
}
