using AssignmentC4.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("ORDER");
        builder.HasKey(p => p.id_Order);
        builder.HasOne<Customer>(p => p.Customers)
            .WithMany(p => p.Orders)
            .HasForeignKey(p => p.id_Customer)
            .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);
        builder.Property(p => p.id_Order).ValueGeneratedOnAdd().IsRequired();
        builder.Property(p => p.id_Customer).IsRequired();

    }
}