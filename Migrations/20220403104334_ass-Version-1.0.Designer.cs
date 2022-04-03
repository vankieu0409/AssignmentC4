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
    [Migration("20220403104334_ass-Version-1.0")]
    partial class assVersion10
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
                    b.Property<Guid>("IdCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ICCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameCarts")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("IdCart");

                    b.ToTable("CARTS", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.CartsDetailCustomer", b =>
                {
                    b.Property<Guid>("IdCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCarts")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("IdCustomer", "IdCarts");

                    b.HasIndex("IdCarts");

                    b.ToTable("CARTS_CUSTOMER", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.Categories", b =>
                {
                    b.Property<Guid>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ICCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCategory");

                    b.ToTable("CATEGORIES", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.CategoryProduct", b =>
                {
                    b.Property<Guid>("IdCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProducts")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("IdCategory", "IdProducts");

                    b.HasIndex("IdProducts");

                    b.ToTable("CARTSGORIES_PRODUCT", (string)null);
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
                        .HasDefaultValue("Customer in 3/4/2022 5:43:34 PM");

                    b.Property<Guid>("ICCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<long>("Prime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdCart", "IdProduct");

                    b.HasIndex("IdProduct");

                    b.ToTable("PRODUCT_CARTS", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.Products", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ICProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Image")
                        .HasColumnType("tinyint");

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

                    b.HasKey("IdProduct");

                    b.ToTable("PRODUCT", (string)null);
                });

            modelBuilder.Entity("AssignmentC4.Entities.CartsDetailCustomer", b =>
                {
                    b.HasOne("AssignmentC4.Entities.Carts", "Cartses")
                        .WithMany("CartsDetailCustomers")
                        .HasForeignKey("IdCarts")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssignmentC4.Entities.Customer", "Customeres")
                        .WithMany("CartsDetailCustomers")
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cartses");

                    b.Navigation("Customeres");
                });

            modelBuilder.Entity("AssignmentC4.Entities.CategoryProduct", b =>
                {
                    b.HasOne("AssignmentC4.Entities.Categories", "Categories")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("IdCategory")
                        .IsRequired();

                    b.HasOne("AssignmentC4.Entities.Products", "Products")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("IdProducts")
                        .IsRequired();

                    b.Navigation("Categories");

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
                    b.Navigation("CartsDetailCustomers");

                    b.Navigation("ProductsCarts");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Categories", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Customer", b =>
                {
                    b.Navigation("CartsDetailCustomers");
                });

            modelBuilder.Entity("AssignmentC4.Entities.Products", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("ProductCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
