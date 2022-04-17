﻿using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class CartsConfiguration:IEntityTypeConfiguration<Carts>
{
    public void Configure(EntityTypeBuilder<Carts> builder)
    {
        builder.ToTable("CARTS");
        builder.HasKey(p=>new { p.CartId, p.CustomerID });
        builder.Property(p => p.CartId).IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.TotalCost).HasDefaultValue(0.00);
    }
}