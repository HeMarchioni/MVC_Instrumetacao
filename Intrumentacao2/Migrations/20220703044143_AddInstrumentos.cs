using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intrumentacao2.Migrations
{
    public partial class AddInstrumentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intrumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: false),
                    Principio = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Range = table.Column<float>(type: "real", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: false),
                    Protocolo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Quadratica = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intrumentos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intrumentos");
        }
    }
}
