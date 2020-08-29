using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class dodatneuslugesobe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DodatneUslugeSobe",
                columns: table => new
                {
                    DodatnaUslugaSobaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DodatnaUslugaId = table.Column<int>(nullable: false),
                    SobaId = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatneUslugeSobe", x => x.DodatnaUslugaSobaId);
                    table.ForeignKey(
                        name: "FK_DodatneUslugeSobe_DodatneUsluge_DodatnaUslugaId",
                        column: x => x.DodatnaUslugaId,
                        principalTable: "DodatneUsluge",
                        principalColumn: "DodatnaUslugaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DodatneUslugeSobe_Sobe_SobaId",
                        column: x => x.SobaId,
                        principalTable: "Sobe",
                        principalColumn: "SobaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUslugeSobe_DodatnaUslugaId",
                table: "DodatneUslugeSobe",
                column: "DodatnaUslugaId");

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUslugeSobe_SobaId",
                table: "DodatneUslugeSobe",
                column: "SobaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DodatneUslugeSobe");
        }
    }
}
