using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class update194v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_CartsCartId_CartsCustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCT_CARTS_CartsCartId_CartsCustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS");

            migrationBuilder.DropIndex(
                name: "IX_CARTS_CustomerID",
                table: "CARTS");

            migrationBuilder.DropColumn(
                name: "CartsCartId",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropColumn(
                name: "CartsCustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/19/2022 1:07:39 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/19/2022 12:50:07 AM");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                table: "PRODUCT_CARTS",
                column: "IdProduct",
                principalTable: "PRODUCT",
                principalColumn: "IdProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS");

            migrationBuilder.DropIndex(
                name: "IX_CARTS_CustomerID",
                table: "CARTS");

            migrationBuilder.AddColumn<Guid>(
                name: "CartsCartId",
                table: "PRODUCT_CARTS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CartsCustomerID",
                table: "PRODUCT_CARTS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/19/2022 12:50:07 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/19/2022 1:07:39 AM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CARTS",
                table: "CARTS",
                columns: new[] { "CartId", "CustomerID" });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CARTS_CartsCartId_CartsCustomerID",
                table: "PRODUCT_CARTS",
                columns: new[] { "CartsCartId", "CartsCustomerID" });

            migrationBuilder.CreateIndex(
                name: "IX_CARTS_CustomerID",
                table: "CARTS",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_CartsCartId_CartsCustomerID",
                table: "PRODUCT_CARTS",
                columns: new[] { "CartsCartId", "CartsCustomerID" },
                principalTable: "CARTS",
                principalColumns: new[] { "CartId", "CustomerID" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                table: "PRODUCT_CARTS",
                column: "IdProduct",
                principalTable: "PRODUCT",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
