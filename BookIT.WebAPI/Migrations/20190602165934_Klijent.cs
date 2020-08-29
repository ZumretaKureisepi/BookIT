using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class Klijent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ocjena",
                table: "SmjestajiOcjene",
                newName: "OcjenaVlasnikSmjestaja");

            migrationBuilder.AddColumn<double>(
                name: "FinalnaOcjena",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "KlijentId",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OcjenaCistoca",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OcjenaDodatneUsluge",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OcjenaIsplativost",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OcjenaLokacija",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OcjenaUdobnost",
                table: "SmjestajiOcjene",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SmjestajiOcjene_KlijentId",
                table: "SmjestajiOcjene",
                column: "KlijentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SmjestajiOcjene_Klijenti_KlijentId",
                table: "SmjestajiOcjene",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SmjestajiOcjene_Klijenti_KlijentId",
                table: "SmjestajiOcjene");

            migrationBuilder.DropIndex(
                name: "IX_SmjestajiOcjene_KlijentId",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "FinalnaOcjena",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "KlijentId",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "OcjenaCistoca",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "OcjenaDodatneUsluge",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "OcjenaIsplativost",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "OcjenaLokacija",
                table: "SmjestajiOcjene");

            migrationBuilder.DropColumn(
                name: "OcjenaUdobnost",
                table: "SmjestajiOcjene");

            migrationBuilder.RenameColumn(
                name: "OcjenaVlasnikSmjestaja",
                table: "SmjestajiOcjene",
                newName: "Ocjena");
        }
    }
}
