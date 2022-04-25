using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class update242 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropTable(
                name: "CARTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCT_CARTS",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCT_CARTS_IdProduct",
                table: "PRODUCT_CARTS");

            migrationBuilder.RenameColumn(
                name: "IdCart",
                table: "PRODUCT_CARTS",
                newName: "CustomerID");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "PRODUCT_CARTS",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "PRODUCT_CARTS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                oldDefaultValue: "Customer in 4/24/2022 11:44:20 PM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCT_CARTS",
                table: "PRODUCT_CARTS",
                columns: new[] { "IdProduct", "CustomerID" });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CARTS_CustomerID",
                table: "PRODUCT_CARTS",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CUSTOMER_CustomerID",
                table: "PRODUCT_CARTS",
                column: "CustomerID",
                principalTable: "CUSTOMER",
                principalColumn: "IdCustomer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_CARTS_CUSTOMER_CustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCT_CARTS",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCT_CARTS_CustomerID",
                table: "PRODUCT_CARTS");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "PRODUCT_CARTS");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "PRODUCT_CARTS",
                newName: "IdCart");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "PRODUCT_CARTS",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(float),
                oldType: "real",
                oldDefaultValue: 0f);

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
                oldDefaultValue: "Customer in 4/25/2022 2:41:11 AM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCT_CARTS",
                table: "PRODUCT_CARTS",
                columns: new[] { "IdCart", "IdProduct" });

            migrationBuilder.CreateTable(
                name: "CARTS",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartStatus = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TotalCost = table.Column<float>(type: "real", nullable: false, defaultValue: 0f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTS", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_CARTS_CUSTOMER_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CUSTOMER",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CARTS_IdProduct",
                table: "PRODUCT_CARTS",
                column: "IdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                table: "PRODUCT_CARTS",
                column: "IdCart",
                principalTable: "CARTS",
                principalColumn: "CustomerID");
        }
    }
}
