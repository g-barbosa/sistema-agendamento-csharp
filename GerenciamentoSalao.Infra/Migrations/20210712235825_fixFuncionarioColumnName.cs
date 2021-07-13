using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoSalao.Infra.Migrations
{
    public partial class fixFuncionarioColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Saída",
                table: "Funcionarios",
                newName: "Saida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Saida",
                table: "Funcionarios",
                newName: "Saída");
        }
    }
}
