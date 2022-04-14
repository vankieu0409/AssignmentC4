using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentC4.Configuration;

public class CustomersConfiguration:IEntityTypeConfiguration<Customer>
{
    private DateTime a = DateTime.Now;
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("CUSTOMER");
        builder.HasKey(p => p.IdCustomer);
        builder.Property(p => p.Sex).IsRequired().HasDefaultValue(null);
        builder.Property(p => p.IdCustomer).IsRequired().ValueGeneratedOnAdd();

        builder.Property(p => p.CustomerName).HasMaxLength(100).HasDefaultValue($"Customer in {a}");

    }
}