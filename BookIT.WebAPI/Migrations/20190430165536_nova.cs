using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatnaUslugaRezervacija_DodatnaUsluga_DodatnaUslugaId",
                table: "DodatnaUslugaRezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_DodatnaUslugaRezervacija_Rezervacija_RezervacijaId",
                table: "DodatnaUslugaRezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Klijenti_KlijentId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Smjestaji_SmjestajId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_SobaRezervacija_Rezervacija_RezervacijaId",
                table: "SobaRezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_SobaRezervacija_Sobe_SobaId",
                table: "SobaRezervacija");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SobaRezervacija",
                table: "SobaRezervacija");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervacija",
                table: "Rezervacija");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DodatnaUslugaRezervacija",
                table: "DodatnaUslugaRezervacija");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DodatnaUsluga",
                table: "DodatnaUsluga");

            migrationBuilder.RenameTable(
                name: "SobaRezervacija",
                newName: "SobeRezervacije");

            migrationBuilder.RenameTable(
                name: "Rezervacija",
                newName: "Rezervacije");

            migrationBuilder.RenameTable(
                name: "DodatnaUslugaRezervacija",
                newName: "DodatneUslugeRezervacije");

            migrationBuilder.RenameTable(
                name: "DodatnaUsluga",
                newName: "DodatneUsluge");

            migrationBuilder.RenameIndex(
                name: "IX_SobaRezervacija_SobaId",
                table: "SobeRezervacije",
                newName: "IX_SobeRezervacije_SobaId");

            migrationBuilder.RenameIndex(
                name: "IX_SobaRezervacija_RezervacijaId",
                table: "SobeRezervacije",
                newName: "IX_SobeRezervacije_RezervacijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_SmjestajId",
                table: "Rezervacije",
                newName: "IX_Rezervacije_SmjestajId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_KlijentId",
                table: "Rezervacije",
                newName: "IX_Rezervacije_KlijentId");

            migrationBuilder.RenameIndex(
                name: "IX_DodatnaUslugaRezervacija_RezervacijaId",
                table: "DodatneUslugeRezervacije",
                newName: "IX_DodatneUslugeRezervacije_RezervacijaId");

            migrationBuilder.RenameIndex(
                name: "IX_DodatnaUslugaRezervacija_DodatnaUslugaId",
                table: "DodatneUslugeRezervacije",
                newName: "IX_DodatneUslugeRezervacije_DodatnaUslugaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SobeRezervacije",
                table: "SobeRezervacije",
                column: "SobaRezervacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervacije",
                table: "Rezervacije",
                column: "RezervacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DodatneUslugeRezervacije",
                table: "DodatneUslugeRezervacije",
                column: "DodatnaUslugaRezervacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DodatneUsluge",
                table: "DodatneUsluge",
                column: "DodatnaUslugaId");

            migrationBuilder.CreateTable(
                name: "DodatneUslugeSmjestaji",
                columns: table => new
                {
                    DodatnaUslugaSmjestajId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DodatnaUslugaId = table.Column<int>(nullable: true),
                    DodatnaUslugId = table.Column<int>(nullable: false),
                    SmjestajId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatneUslugeSmjestaji", x => x.DodatnaUslugaSmjestajId);
                    table.ForeignKey(
                        name: "FK_DodatneUslugeSmjestaji_DodatneUsluge_DodatnaUslugaId",
                        column: x => x.DodatnaUslugaId,
                        principalTable: "DodatneUsluge",
                        principalColumn: "DodatnaUslugaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DodatneUslugeSmjestaji_Smjestaji_SmjestajId",
                        column: x => x.SmjestajId,
                        principalTable: "Smjestaji",
                        principalColumn: "SmjestajId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fakture",
                columns: table => new
                {
                    FakturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Iznos = table.Column<double>(nullable: false),
                    RezervacijaId = table.Column<int>(nullable: false),
                    DatumFakture = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakture", x => x.FakturaId);
                    table.ForeignKey(
                        name: "FK_Fakture_Rezervacije_RezervacijaId",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUslugeSmjestaji_DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji",
                column: "DodatnaUslugaId");

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUslugeSmjestaji_SmjestajId",
                table: "DodatneUslugeSmjestaji",
                column: "SmjestajId");

            migrationBuilder.CreateIndex(
                name: "IX_Fakture_RezervacijaId",
                table: "Fakture",
                column: "RezervacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUslugeRezervacije_DodatneUsluge_DodatnaUslugaId",
                table: "DodatneUslugeRezervacije",
                column: "DodatnaUslugaId",
                principalTable: "DodatneUsluge",
                principalColumn: "DodatnaUslugaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUslugeRezervacije_Rezervacije_RezervacijaId",
                table: "DodatneUslugeRezervacije",
                column: "RezervacijaId",
                principalTable: "Rezervacije",
                principalColumn: "RezervacijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Klijenti_KlijentId",
                table: "Rezervacije",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Smjestaji_SmjestajId",
                table: "Rezervacije",
                column: "SmjestajId",
                principalTable: "Smjestaji",
                principalColumn: "SmjestajId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeRezervacije_Rezervacije_RezervacijaId",
                table: "SobeRezervacije",
                column: "RezervacijaId",
                principalTable: "Rezervacije",
                principalColumn: "RezervacijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeRezervacije_Sobe_SobaId",
                table: "SobeRezervacije",
                column: "SobaId",
                principalTable: "Sobe",
                principalColumn: "SobaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUslugeRezervacije_DodatneUsluge_DodatnaUslugaId",
                table: "DodatneUslugeRezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUslugeRezervacije_Rezervacije_RezervacijaId",
                table: "DodatneUslugeRezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Klijenti_KlijentId",
                table: "Rezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Smjestaji_SmjestajId",
                table: "Rezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeRezervacije_Rezervacije_RezervacijaId",
                table: "SobeRezervacije");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeRezervacije_Sobe_SobaId",
                table: "SobeRezervacije");

            migrationBuilder.DropTable(
                name: "DodatneUslugeSmjestaji");

            migrationBuilder.DropTable(
                name: "Fakture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SobeRezervacije",
                table: "SobeRezervacije");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervacije",
                table: "Rezervacije");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DodatneUslugeRezervacije",
                table: "DodatneUslugeRezervacije");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DodatneUsluge",
                table: "DodatneUsluge");

            migrationBuilder.RenameTable(
                name: "SobeRezervacije",
                newName: "SobaRezervacija");

            migrationBuilder.RenameTable(
                name: "Rezervacije",
                newName: "Rezervacija");

            migrationBuilder.RenameTable(
                name: "DodatneUslugeRezervacije",
                newName: "DodatnaUslugaRezervacija");

            migrationBuilder.RenameTable(
                name: "DodatneUsluge",
                newName: "DodatnaUsluga");

            migrationBuilder.RenameIndex(
                name: "IX_SobeRezervacije_SobaId",
                table: "SobaRezervacija",
                newName: "IX_SobaRezervacija_SobaId");

            migrationBuilder.RenameIndex(
                name: "IX_SobeRezervacije_RezervacijaId",
                table: "SobaRezervacija",
                newName: "IX_SobaRezervacija_RezervacijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacije_SmjestajId",
                table: "Rezervacija",
                newName: "IX_Rezervacija_SmjestajId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacije_KlijentId",
                table: "Rezervacija",
                newName: "IX_Rezervacija_KlijentId");

            migrationBuilder.RenameIndex(
                name: "IX_DodatneUslugeRezervacije_RezervacijaId",
                table: "DodatnaUslugaRezervacija",
                newName: "IX_DodatnaUslugaRezervacija_RezervacijaId");

            migrationBuilder.RenameIndex(
                name: "IX_DodatneUslugeRezervacije_DodatnaUslugaId",
                table: "DodatnaUslugaRezervacija",
                newName: "IX_DodatnaUslugaRezervacija_DodatnaUslugaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SobaRezervacija",
                table: "SobaRezervacija",
                column: "SobaRezervacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervacija",
                table: "Rezervacija",
                column: "RezervacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DodatnaUslugaRezervacija",
                table: "DodatnaUslugaRezervacija",
                column: "DodatnaUslugaRezervacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DodatnaUsluga",
                table: "DodatnaUsluga",
                column: "DodatnaUslugaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DodatnaUslugaRezervacija_DodatnaUsluga_DodatnaUslugaId",
                table: "DodatnaUslugaRezervacija",
                column: "DodatnaUslugaId",
                principalTable: "DodatnaUsluga",
                principalColumn: "DodatnaUslugaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DodatnaUslugaRezervacija_Rezervacija_RezervacijaId",
                table: "DodatnaUslugaRezervacija",
                column: "RezervacijaId",
                principalTable: "Rezervacija",
                principalColumn: "RezervacijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Klijenti_KlijentId",
                table: "Rezervacija",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Smjestaji_SmjestajId",
                table: "Rezervacija",
                column: "SmjestajId",
                principalTable: "Smjestaji",
                principalColumn: "SmjestajId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobaRezervacija_Rezervacija_RezervacijaId",
                table: "SobaRezervacija",
                column: "RezervacijaId",
                principalTable: "Rezervacija",
                principalColumn: "RezervacijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobaRezervacija_Sobe_SobaId",
                table: "SobaRezervacija",
                column: "SobaId",
                principalTable: "Sobe",
                principalColumn: "SobaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
