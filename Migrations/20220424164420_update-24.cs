using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class update24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS");

            migrationBuilder.DropIndex(
                name: "IX_CARTS_CustomerID",
                table: "CARTS");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "price_Each",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CARTS");

            migrationBuilder.RenameColumn(
                name: "unit_Price",
                table: "OrderDetails",
                newName: "Price");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/24/2022 11:44:20 PM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/23/2022 9:00:39 AM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS",
                column: "IdCart",
                principalTable: "CARTS",
                principalColumn: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderDetails",
                newName: "unit_Price");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "OrderDetails",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "price_Each",
                table: "OrderDetails",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/23/2022 9:00:39 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/24/2022 11:44:20 PM");

            migrationBuilder.AddColumn<Guid>(
                name: "CartId",
                table: "CARTS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CARTS_CustomerID",
                table: "CARTS",
                column: "CustomerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS",
                column: "IdCart",
                principalTable: "CARTS",
                principalColumn: "CartId");
        }
    }
}
