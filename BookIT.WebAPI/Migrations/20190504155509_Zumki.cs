using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class Zumki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "SobeRezervacije",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "SobeRezervacije");
        }
    }
}
