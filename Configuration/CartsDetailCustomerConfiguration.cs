using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class CartsDetailCustomerConfiguration:IEntityTypeConfiguration<CartsDetailCustomer>
{
    public void Configure(EntityTypeBuilder<CartsDetailCustomer> builder)
    {
        builder.ToTable("CARTS_CUSTOMER");
        builder.HasKey(p => new {p.IdCustomer,p.IdCarts });
        builder.HasOne<Customer>(p => p.Customeres)
            .WithMany(p => p.CartsDetailCustomers)
            .HasForeignKey(p => p.IdCustomer);
        builder.HasOne<Carts>(p=>p.Cartses)
            .WithMany(p=>p.CartsDetailCustomers)
            .HasForeignKey(p=>p.IdCarts)
            .OnDelete(DeleteBehavior.Cascade);

    }
}