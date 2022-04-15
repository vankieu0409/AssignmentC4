using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentC4.Migrations
{
    public partial class kieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CARTS",
                columns: table => new
                {
                    IdCart = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameCarts = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    StatusCart = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTS", x => x.IdCart);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    IdCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIES", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "Customer in 15/4/2022 1:39:27 AM"),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    ImportPrice = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Image = table.Column<byte>(type: "tinyint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "CARTS_CUSTOMER",
                columns: table => new
                {
                    IdCarts = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTS_CUSTOMER", x => new { x.IdCustomer, x.IdCarts });
                    table.ForeignKey(
                        name: "FK_CARTS_CUSTOMER_CARTS_IdCarts",
                        column: x => x.IdCarts,
                        principalTable: "CARTS",
                        principalColumn: "IdCart",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CARTS_CUSTOMER_CUSTOMER_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "CUSTOMER",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    id_Order = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_Customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    discount = table.Column<decimal>(type: "money", nullable: false),
                    amount_Pay = table.Column<decimal>(type: "money", nullable: false),
                    paying_Customer = table.Column<decimal>(type: "money", nullable: false),
                    refunds = table.Column<decimal>(type: "money", nullable: false),
                    total_pay = table.Column<decimal>(type: "money", nullable: false),
                    payments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order_status = table.Column<int>(type: "int", nullable: false),
                    IsDetete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER", x => x.id_Order);
                    table.ForeignKey(
                        name: "FK_ORDER_CUSTOMER_id_Customer",
                        column: x => x.id_Customer,
                        principalTable: "CUSTOMER",
                        principalColumn: "IdCustomer");
                });

            migrationBuilder.CreateTable(
                name: "CARTSGORIES_PRODUCT",
                columns: table => new
                {
                    IdProducts = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTSGORIES_PRODUCT", x => new { x.IdCategory, x.IdProducts });
                    table.ForeignKey(
                        name: "FK_CARTSGORIES_PRODUCT_CATEGORIES_IdCategory",
                        column: x => x.IdCategory,
                        principalTable: "CATEGORIES",
                        principalColumn: "IdCategory");
                    table.ForeignKey(
                        name: "FK_CARTSGORIES_PRODUCT_PRODUCT_IdProducts",
                        column: x => x.IdProducts,
                        principalTable: "PRODUCT",
                        principalColumn: "IdProduct");
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_CARTS",
                columns: table => new
                {
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCart = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Prime = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_CARTS", x => new { x.IdCart, x.IdProduct });
                    table.ForeignKey(
                        name: "FK_PRODUCT_CARTS_CARTS_IdCart",
                        column: x => x.IdCart,
                        principalTable: "CARTS",
                        principalColumn: "IdCart");
                    table.ForeignKey(
                        name: "FK_PRODUCT_CARTS_PRODUCT_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "PRODUCT",
                        principalColumn: "IdProduct");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    id_Order = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unit_Price = table.Column<decimal>(type: "money", nullable: false),
                    price_Each = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.id_Order, x.id_Product });
                    table.ForeignKey(
                        name: "FK_OrderDetails_ORDER_id_Order",
                        column: x => x.id_Order,
                        principalTable: "ORDER",
                        principalColumn: "id_Order");
                    table.ForeignKey(
                        name: "FK_OrderDetails_PRODUCT_id_Product",
                        column: x => x.id_Product,
                        principalTable: "PRODUCT",
                        principalColumn: "IdProduct");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CARTS_CUSTOMER_IdCarts",
                table: "CARTS_CUSTOMER",
                column: "IdCarts");

            migrationBuilder.CreateIndex(
                name: "IX_CARTSGORIES_PRODUCT_IdProducts",
                table: "CARTSGORIES_PRODUCT",
                column: "IdProducts");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_id_Customer",
                table: "ORDER",
                column: "id_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_id_Product",
                table: "OrderDetails",
                column: "id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CARTS_IdProduct",
                table: "PRODUCT_CARTS",
                column: "IdProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CARTS_CUSTOMER");

            migrationBuilder.DropTable(
                name: "CARTSGORIES_PRODUCT");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PRODUCT_CARTS");

            migrationBuilder.DropTable(
                name: "CATEGORIES");

            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "CARTS");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "CUSTOMER");
        }
    }
}
