using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoFinal.Migrations
{
    public partial class InitialCreatew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Produto_ProdutoId",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produto",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_ProdutoId",
                table: "Produto",
                newName: "IX_Produto_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Item_ItemId",
                table: "Produto",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Item_ItemId",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Produto",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_ItemId",
                table: "Produto",
                newName: "IX_Produto_ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Produto_ProdutoId",
                table: "Produto",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id");
        }
    }
}
