using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intrumentacao2.Migrations
{
    public partial class AtualizaçãoInstrumentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Intrumentos_Tag",
                table: "Intrumentos",
                column: "Tag",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Intrumentos_Tag",
                table: "Intrumentos");
        }
    }
}
