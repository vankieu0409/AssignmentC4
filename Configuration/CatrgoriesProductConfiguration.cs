using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class CategoriesProductConfiguration:IEntityTypeConfiguration<CategoryProduct>
{
    public void Configure(EntityTypeBuilder<CategoryProduct> builder)
    {
        builder.ToTable("CARTSGORIES_PRODUCT");
        builder.HasKey(p => new { p.IdCategory, p.IdProducts });
        builder.HasOne<Categories>(p=>p.Categories)
            .WithMany(p=>p.CategoryProducts)
            .HasForeignKey(p=>p.IdCategory)
            .OnDelete(deleteBehavior:DeleteBehavior.ClientSetNull);
        builder.HasOne<Products>(p => p.Products)
            .WithMany(p=>p.CategoryProducts)
            .HasForeignKey(p=>p.IdProducts)
            .OnDelete(deleteBehavior:DeleteBehavior.ClientSetNull);
      //  builder.Property(p => p.IsDeleted).HasDefaultValue(true);

    }
}