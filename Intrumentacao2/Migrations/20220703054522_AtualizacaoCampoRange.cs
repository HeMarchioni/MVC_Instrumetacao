using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intrumentacao2.Migrations
{
    public partial class AtualizacaoCampoRange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Range",
                table: "Intrumentos",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Range",
                table: "Intrumentos",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }
    }
}
