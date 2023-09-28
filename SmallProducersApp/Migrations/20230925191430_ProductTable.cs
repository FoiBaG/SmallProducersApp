using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallProducersApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "ProductCategory",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductCategory",
                newName: "CategoryID");

            migrationBuilder.AddColumn<float>(
                name: "Iva",
                table: "ProductCategory",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iva",
                table: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "ProductCategory",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "ProductCategory",
                newName: "Id");
        }
    }
}
