using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class CartsConfiguration:IEntityTypeConfiguration<Carts>
{
    public void Configure(EntityTypeBuilder<Carts> builder)
    {
        builder.ToTable("CARTS");
        builder.HasKey(p=>p.IdCart);
        builder.Property(p => p.IdCart).IsRequired().ValueGeneratedOnAdd();
        builder.Property(p => p.NameCarts).HasMaxLength(25);
        
    }
}