using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoSalao.Infra.Migrations
{
    public partial class addRoleToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Clientes");
        }
    }
}
