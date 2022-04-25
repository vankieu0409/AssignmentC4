using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class update25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CUSTOMER_CustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductsIdProduct",
                table: "PRODUCT_CARTS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/25/2022 3:43:34 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/25/2022 2:41:11 AM");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CARTS_ProductsIdProduct",
                table: "PRODUCT_CARTS",
                column: "ProductsIdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CUSTOMER_CustomerID",
                table: "PRODUCT_CARTS",
                column: "CustomerID",
                principalTable: "CUSTOMER",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_ProductsIdProduct",
                table: "PRODUCT_CARTS",
                column: "ProductsIdProduct",
                principalTable: "PRODUCT",
                principalColumn: "IdProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CUSTOMER_CustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_ProductsIdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCT_CARTS_ProductsIdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropColumn(
                name: "ProductsIdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/25/2022 2:41:11 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/25/2022 3:43:34 AM");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CUSTOMER_CustomerID",
                table: "PRODUCT_CARTS",
                column: "CustomerID",
                principalTable: "CUSTOMER",
                principalColumn: "IdCustomer");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                table: "PRODUCT_CARTS",
                column: "IdProduct",
                principalTable: "PRODUCT",
                principalColumn: "IdProduct");
        }
    }
}
