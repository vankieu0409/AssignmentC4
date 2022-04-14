using Microsoft.EntityFrameworkCore;
using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class ProductConfiguration:IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.ToTable("PRODUCT");
        builder.HasKey(c => c.IdProduct);
        builder.Property(p => p.IdProduct).IsRequired().ValueGeneratedOnAdd();
        builder.Property(p => p.NameProduct).HasMaxLength(50).ValueGeneratedOnAdd();
        builder.Property(c => c.Image).IsRequired();
        builder.Property(c => c.Price).IsRequired().HasDefaultValue(0);
        builder.Property(c => c.ImportPrice).IsRequired().HasDefaultValue(0);
       // builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(true);
      
    }
}