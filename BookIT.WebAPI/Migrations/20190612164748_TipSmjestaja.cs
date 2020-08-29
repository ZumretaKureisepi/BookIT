using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class TipSmjestaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SmjestajiTipDestinacija",
                columns: table => new
                {
                    SmjestajTipDestinacijeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmjestajId = table.Column<int>(nullable: false),
                    TipDestinacije = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmjestajiTipDestinacija", x => x.SmjestajTipDestinacijeId);
                    table.ForeignKey(
                        name: "FK_SmjestajiTipDestinacija_Smjestaji_SmjestajId",
                        column: x => x.SmjestajId,
                        principalTable: "Smjestaji",
                        principalColumn: "SmjestajId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SmjestajiTipDestinacija_SmjestajId",
                table: "SmjestajiTipDestinacija",
                column: "SmjestajId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmjestajiTipDestinacija");
        }
    }
}
