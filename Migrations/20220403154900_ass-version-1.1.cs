using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class assversion11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 3/4/2022 10:49:00 PM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 3/4/2022 5:43:34 PM");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "CUSTOMER",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "CUSTOMER");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Customer in 3/4/2022 5:43:34 PM",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Customer in 3/4/2022 10:49:00 PM");
        }
    }
}
