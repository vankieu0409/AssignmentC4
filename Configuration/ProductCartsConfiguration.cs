using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class ProductCartsConfiguration : IEntityTypeConfiguration<ProductCarts>
{
    public void Configure(EntityTypeBuilder<ProductCarts> builder)
    {
        builder.ToTable("PRODUCT_CARTS");
        builder.HasKey(p => new { p.IdProduct, p.CustomerID });
        builder.Property(p => p.Price).HasDefaultValue(0.00);
        builder.Property(p => p.Quantity).HasDefaultValue(1);
        builder.Property(c => c.Quantity);
        builder.Property(p => p.IsDeleted).HasDefaultValue(true);
    }
}