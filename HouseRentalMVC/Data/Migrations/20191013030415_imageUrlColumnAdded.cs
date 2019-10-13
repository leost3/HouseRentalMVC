using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseRentalMVC.Data.Migrations
{
    public partial class imageUrlColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Houses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Houses");
        }
    }
}
