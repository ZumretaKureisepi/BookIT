using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cijena",
                table: "DodatneUslugeSmjestaji",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "DodatneUslugeSmjestaji");
        }
    }
}
