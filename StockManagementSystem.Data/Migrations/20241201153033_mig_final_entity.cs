using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_final_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StockTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Stocks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StockUnits",
                newName: "StockUnitName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "StockUnits",
                newName: "StockUnitCode");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StockTypes",
                newName: "StockTypeName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Stocks",
                newName: "ShelfInformation");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Stocks",
                newName: "CabinetInformation");

            migrationBuilder.AddColumn<int>(
                name: "BuyingPrice",
                table: "StockUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyUnitId",
                table: "StockUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StockUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PaperWeight",
                table: "StockUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalePrice",
                table: "StockUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StockTypeId",
                table: "StockUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CriticalQuantity",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StockClassId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CurrencyUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyUnitMoney = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockClassName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockClass", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockUnits_CurrencyUnitId",
                table: "StockUnits",
                column: "CurrencyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUnits_StockTypeId",
                table: "StockUnits",
                column: "StockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockClassId",
                table: "Stocks",
                column: "StockClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockClass_StockClassId",
                table: "Stocks",
                column: "StockClassId",
                principalTable: "StockClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_CurrencyUnit_CurrencyUnitId",
                table: "StockUnits",
                column: "CurrencyUnitId",
                principalTable: "CurrencyUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockUnits_StockTypes_StockTypeId",
                table: "StockUnits",
                column: "StockTypeId",
                principalTable: "StockTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockClass_StockClassId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_CurrencyUnit_CurrencyUnitId",
                table: "StockUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_StockUnits_StockTypes_StockTypeId",
                table: "StockUnits");

            migrationBuilder.DropTable(
                name: "CurrencyUnit");

            migrationBuilder.DropTable(
                name: "StockClass");

            migrationBuilder.DropIndex(
                name: "IX_StockUnits_CurrencyUnitId",
                table: "StockUnits");

            migrationBuilder.DropIndex(
                name: "IX_StockUnits_StockTypeId",
                table: "StockUnits");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_StockClassId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "BuyingPrice",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "CurrencyUnitId",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "PaperWeight",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "StockTypeId",
                table: "StockUnits");

            migrationBuilder.DropColumn(
                name: "CriticalQuantity",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "StockClassId",
                table: "Stocks");

            migrationBuilder.RenameColumn(
                name: "StockUnitName",
                table: "StockUnits",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "StockUnitCode",
                table: "StockUnits",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "StockTypeName",
                table: "StockTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ShelfInformation",
                table: "Stocks",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CabinetInformation",
                table: "Stocks",
                newName: "Code");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StockUnits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StockTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
