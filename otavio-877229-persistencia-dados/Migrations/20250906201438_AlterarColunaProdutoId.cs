using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otavio_877229_persistencia_dados.Migrations
{
    /// <inheritdoc />
    public partial class AlterarColunaProdutoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produtos",
                newName: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produtos",
                newName: "Id");
        }
    }
}
