﻿using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class ProductCartsConfiguration:IEntityTypeConfiguration<ProductCarts>
{
    public void Configure(EntityTypeBuilder<ProductCarts> builder)
    {
        builder.ToTable("PRODUCT_CARTS");
        builder.HasKey(p => new { p.IdCart, p.IdProduct });
        builder.Property(p => p.Price).HasDefaultValue(0.00);
        builder.Property(p => p.Quantity).HasDefaultValue(1);
        builder.Property(c => c.Quantity);
        builder.Property(p => p.IsDeleted).HasDefaultValue(true);
        builder.HasOne<Products>(c => c.Products).WithMany(c => c.ProductCarts).HasForeignKey(c => c.IdProduct)
            .OnDelete(DeleteBehavior.ClientSetNull);
        builder.HasOne<Carts>(c => c.Carts).WithMany(c => c.ProductsCarts).HasForeignKey(c => c.IdCart)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}