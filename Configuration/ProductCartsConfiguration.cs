using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class ProductCartsConfiguration:IEntityTypeConfiguration<ProductCarts>
{
    public void Configure(EntityTypeBuilder<ProductCarts> builder)
    {
        builder.ToTable("PRODUCT_CARTS");
        builder.HasKey(p => new { p.IdCart, p.IdProduct });
        builder.HasOne<Carts>(p => p.Carts)
            .WithMany(p => p.ProductsCarts)
            .HasForeignKey(p => p.IdCart)
            .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);
        builder.HasOne<Products>(p => p.Products)
            .WithMany(p => p.ProductCarts)
            .HasForeignKey(p => p.IdProduct)
            .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);
        builder.Property(p => p.Prime).HasDefaultValue(0.00);
        builder.Property(p => p.IsDeleted).HasDefaultValue(true);
    }
}