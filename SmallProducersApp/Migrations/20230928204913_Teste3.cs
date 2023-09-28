using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallProducersApp.Migrations
{
    /// <inheritdoc />
    public partial class Teste3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_CategoryID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Product",
                newName: "ProductCategoryCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                newName: "IX_Product_ProductCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryCategoryID",
                table: "Product",
                column: "ProductCategoryCategoryID",
                principalTable: "ProductCategory",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryCategoryID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryCategoryID",
                table: "Product",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductCategoryCategoryID",
                table: "Product",
                newName: "IX_Product_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "ProductCategory",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
