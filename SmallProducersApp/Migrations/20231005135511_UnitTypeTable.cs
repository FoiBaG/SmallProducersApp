using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallProducersApp.Migrations
{
    /// <inheritdoc />
    public partial class UnitTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitType",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "UnitTypeID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UnitType",
                columns: table => new
                {
                    UnitTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitTypeNumber = table.Column<int>(type: "int", nullable: false),
                    UnitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.UnitTypeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitType");

            migrationBuilder.DropColumn(
                name: "UnitTypeID",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "UnitType",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
