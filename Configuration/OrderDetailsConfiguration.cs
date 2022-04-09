using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class OrderDetailsConfiguration:IEntityTypeConfiguration<OrderDetails>
{
    public void Configure(EntityTypeBuilder<OrderDetails> builder)
    {
        builder.ToTable("OrderDetails");
        builder.HasKey(p => new { p.id_Order, p.id_Product });
        builder.Property(p => p.id_Order).IsRequired().ValueGeneratedOnAdd();
        builder.HasOne<Order>(p=>p.Orders)
            .WithMany(p=>p.OrDerDetailses)
            .HasForeignKey(p=>p.id_Order)
            .OnDelete(deleteBehavior:DeleteBehavior.ClientSetNull);
        builder.HasOne<Products>(p => p.Products)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(p => p.id_Product)
            .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);
    }
}