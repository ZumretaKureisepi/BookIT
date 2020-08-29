using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class Migracijaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SobaId",
                table: "DodatneUslugeRezervacije",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUslugeRezervacije_SobaId",
                table: "DodatneUslugeRezervacije",
                column: "SobaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUslugeRezervacije_Sobe_SobaId",
                table: "DodatneUslugeRezervacije",
                column: "SobaId",
                principalTable: "Sobe",
                principalColumn: "SobaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUslugeRezervacije_Sobe_SobaId",
                table: "DodatneUslugeRezervacije");

            migrationBuilder.DropIndex(
                name: "IX_DodatneUslugeRezervacije_SobaId",
                table: "DodatneUslugeRezervacije");

            migrationBuilder.DropColumn(
                name: "SobaId",
                table: "DodatneUslugeRezervacije");
        }
    }
}
