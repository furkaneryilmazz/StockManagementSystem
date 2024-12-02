using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_StockQuantityUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockQuantityUnitId",
                table: "StockUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StockQuantityUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityUnit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockQuantityUnit", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockUnits_StockQuantityUnitId",
                table: "StockUnits",
                column: "StockQuantityUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_StockQuantityUnit_StockQuantityUnitId",
                table: "StockUnits",
                column: "StockQuantityUnitId",
                principalTable: "StockQuantityUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_StockQuantityUnit_StockQuantityUnitId",
                table: "StockUnits");

            migrationBuilder.DropTable(
                name: "StockQuantityUnit");

            migrationBuilder.DropIndex(
                name: "IX_StockUnits_StockQuantityUnitId",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "StockQuantityUnitId",
                table: "StockUnits");
        }
    }
}
