using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class Ocjene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SmjestajiOcjene",
                columns: table => new
                {
                    SmjestajOcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmjestajId = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    DatumOcjene = table.Column<DateTime>(nullable: false),
                    OcjenaOpisno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmjestajiOcjene", x => x.SmjestajOcjenaId);
                    table.ForeignKey(
                        name: "FK_SmjestajiOcjene_Smjestaji_SmjestajId",
                        column: x => x.SmjestajId,
                        principalTable: "Smjestaji",
                        principalColumn: "SmjestajId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SmjestajiOcjene_SmjestajId",
                table: "SmjestajiOcjene",
                column: "SmjestajId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmjestajiOcjene");
        }
    }
}
