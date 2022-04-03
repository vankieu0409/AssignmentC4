using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AssignmentC4.Configuration;

public class CategoriesConfiguration:IEntityTypeConfiguration<Categories>
{
    public void Configure(EntityTypeBuilder<Categories> builder)
    {
        builder.ToTable("CATEGORIES");
        builder.HasKey(p => p.IdCategory);
        builder.Property(c => c.IdCategory).IsRequired().ValueGeneratedOnAdd();
        builder.Property(c => c.ICCategory).IsRequired().ValueGeneratedOnAdd();
        builder.Property(c => c.NameCategory).HasMaxLength(50);
    }
}