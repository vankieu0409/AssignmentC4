using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class Ass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "PRODUCT_CARTS",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "PRODUCT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/18/2022 2:07:30 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/18/2022 1:55:06 AM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PRODUCT");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "PRODUCT_CARTS",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 4/18/2022 1:55:06 AM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 4/18/2022 2:07:30 AM");
        }
    }
}
