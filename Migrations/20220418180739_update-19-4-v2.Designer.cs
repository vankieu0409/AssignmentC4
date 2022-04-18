﻿// <auto-generated />
using System;
using AssignmentC4.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentC4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220418180739_update-19-4-v2")]
    partial class update194v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AssignmentC4.Entities.Carts", b =>
                {
                    b.Property<Guid>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CartStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<float>("TotalCost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(0f);

                    b.HasKey("CartId");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("CARTS", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.Customer", b =>
                {
                    b.Property<Guid>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValue("Customer in 4/19/2022 1:07:39 AM");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Sex")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("IdCustomer");

                    b.ToTable("CUSTOMER", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.Order", b =>
                {
                    b.Property<Guid>("id_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDetete")
                        .HasColumnType("bit");

                    b.Property<decimal>("amount_Pay")
                        .HasColumnType("money");

                    b.Property<decimal>("discount")
                        .HasColumnType("money");

                    b.Property<Guid>("id_Customer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("order_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("order_status")
                        .HasColumnType("int");

                    b.Property<decimal>("paying_Customer")
                        .HasColumnType("money");

                    b.Property<string>("payments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("refunds")
                        .HasColumnType("money");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("total_pay")
                        .HasColumnType("money");

                    b.HasKey("id_Order");

                    b.HasIndex("id_Customer");

                    b.ToTable("ORDER", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.OrderDetails", b =>
                {
                    b.Property<Guid>("id_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Discount")
                        .HasColumnType("money");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<decimal>("price_Each")
                        .HasColumnType("money");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("unit_Price")
                        .HasColumnType("money");

                    b.HasKey("id_Order", "id_Product");

                    b.HasIndex("id_Product");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.ProductCarts", b =>
                {
                    b.Property<Guid>("IdCart")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValue(0m);

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("IdCart", "IdProduct");

                    b.HasIndex("IdProduct");

                    b.ToTable("PRODUCT_CARTS", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.Products", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ImportPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdProduct");

                    b.ToTable("PRODUCT", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.Carts", b =>
                {
                    b.HasOne("AssignmentC4.Entities.Customer", "Customer")
                        .WithOne("Carts")
                        .HasForeignKey("AssignmentC4.Entities.Carts", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Order", b =>
                {
                    b.HasOne("AssignmentC4.Entities.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("id_Customer")
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("AssignmentC4.Entities.OrderDetails", b =>
                {
                    b.HasOne("AssignmentC4.Entities.Order", "Orders")
                        .WithMany("OrDerDetailses")
                        .HasForeignKey("id_Order")
                        .IsRequired();

                    b.HasOne("AssignmentC4.Entities.Products", "Products")
                        .WithMany("OrderDetails")
                        .HasForeignKey("id_Product")
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("AssignmentC4.Entities.ProductCarts", b =>
                {
                    b.HasOne("AssignmentC4.Entities.Carts", "Carts")
                        .WithMany("ProductsCarts")
                        .HasForeignKey("IdCart")
                        .IsRequired();

                    b.HasOne("AssignmentC4.Entities.Products", "Products")
                        .WithMany("ProductCarts")
                        .HasForeignKey("IdProduct")
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Carts", b =>
                {
                    b.Navigation("ProductsCarts");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Customer", b =>
                {
                    b.Navigation("Carts")
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Order", b =>
                {
                    b.Navigation("OrDerDetailses");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Products", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
