using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_tableTransfer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockClass_StockClassId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_CurrencyUnit_CurrencyUnitId",
                table: "StockUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_StockQuantityUnit_StockQuantityUnitId",
                table: "StockUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockQuantityUnit",
                table: "StockQuantityUnit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockClass",
                table: "StockClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyUnit",
                table: "CurrencyUnit");

            migrationBuilder.RenameTable(
                name: "StockQuantityUnit",
                newName: "StockQuantityUnits");

            migrationBuilder.RenameTable(
                name: "StockClass",
                newName: "StockClasses");

            migrationBuilder.RenameTable(
                name: "CurrencyUnit",
                newName: "CurrencyUnits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockQuantityUnits",
                table: "StockQuantityUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockClasses",
                table: "StockClasses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyUnits",
                table: "CurrencyUnits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockClasses_StockClassId",
                table: "Stocks",
                column: "StockClassId",
                principalTable: "StockClasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_CurrencyUnits_CurrencyUnitId",
                table: "StockUnits",
                column: "CurrencyUnitId",
                principalTable: "CurrencyUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_StockQuantityUnits_StockQuantityUnitId",
                table: "StockUnits",
                column: "StockQuantityUnitId",
                principalTable: "StockQuantityUnits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockClasses_StockClassId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_CurrencyUnits_CurrencyUnitId",
                table: "StockUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_StockQuantityUnits_StockQuantityUnitId",
                table: "StockUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockQuantityUnits",
                table: "StockQuantityUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockClasses",
                table: "StockClasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyUnits",
                table: "CurrencyUnits");

            migrationBuilder.RenameTable(
                name: "StockQuantityUnits",
                newName: "StockQuantityUnit");

            migrationBuilder.RenameTable(
                name: "StockClasses",
                newName: "StockClass");

            migrationBuilder.RenameTable(
                name: "CurrencyUnits",
                newName: "CurrencyUnit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockQuantityUnit",
                table: "StockQuantityUnit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockClass",
                table: "StockClass",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyUnit",
                table: "CurrencyUnit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockClass_StockClassId",
                table: "Stocks",
                column: "StockClassId",
                principalTable: "StockClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_CurrencyUnit_CurrencyUnitId",
                table: "StockUnits",
                column: "CurrencyUnitId",
                principalTable: "CurrencyUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_StockQuantityUnit_StockQuantityUnitId",
                table: "StockUnits",
                column: "StockQuantityUnitId",
                principalTable: "StockQuantityUnit",
                principalColumn: "Id");
        }
    }
}
