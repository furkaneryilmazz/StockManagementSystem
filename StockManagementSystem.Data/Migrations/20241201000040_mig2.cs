using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockTypes_StockTypeId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockUnits_StockUnitId",
                table: "Stocks");

            migrationBuilder.AlterColumn<int>(
                name: "StockUnitId",
                table: "Stocks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StockTypeId",
                table: "Stocks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockTypes_StockTypeId",
                table: "Stocks",
                column: "StockTypeId",
                principalTable: "StockTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockUnits_StockUnitId",
                table: "Stocks",
                column: "StockUnitId",
                principalTable: "StockUnits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockTypes_StockTypeId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockUnits_StockUnitId",
                table: "Stocks");

            migrationBuilder.AlterColumn<int>(
                name: "StockUnitId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StockTypeId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockTypes_StockTypeId",
                table: "Stocks",
                column: "StockTypeId",
                principalTable: "StockTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockUnits_StockUnitId",
                table: "Stocks",
                column: "StockUnitId",
                principalTable: "StockUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
