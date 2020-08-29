using Microsoft.EntityFrameworkCore.Migrations;

namespace BookIT.WebAPI.Migrations
{
    public partial class zumra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUslugeSmjestaji_DodatneUsluge_DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji");

            migrationBuilder.DropColumn(
                name: "DodatnaUslugId",
                table: "DodatneUslugeSmjestaji");

            migrationBuilder.AlterColumn<int>(
                name: "DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUslugeSmjestaji_DodatneUsluge_DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji",
                column: "DodatnaUslugaId",
                principalTable: "DodatneUsluge",
                principalColumn: "DodatnaUslugaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUslugeSmjestaji_DodatneUsluge_DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji");

            migrationBuilder.AlterColumn<int>(
                name: "DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DodatnaUslugId",
                table: "DodatneUslugeSmjestaji",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUslugeSmjestaji_DodatneUsluge_DodatnaUslugaId",
                table: "DodatneUslugeSmjestaji",
                column: "DodatnaUslugaId",
                principalTable: "DodatneUsluge",
                principalColumn: "DodatnaUslugaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
