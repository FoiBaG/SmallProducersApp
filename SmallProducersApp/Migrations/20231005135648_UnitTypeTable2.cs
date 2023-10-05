using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallProducersApp.Migrations
{
    /// <inheritdoc />
    public partial class UnitTypeTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitTypeID",
                table: "Product",
                column: "UnitTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitType_UnitTypeID",
                table: "Product",
                column: "UnitTypeID",
                principalTable: "UnitType",
                principalColumn: "UnitTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitType_UnitTypeID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UnitTypeID",
                table: "Product");
        }
    }
}
