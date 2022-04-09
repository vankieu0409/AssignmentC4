using AssignmentC4.Configuration;
using AssignmentC4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace AssignmentC4.DbContext;

public class ApplicationDbContext:Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }

    public DbSet<Carts> Carts{ get; set; }
    public DbSet<Categories> Categories{ get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<CartsDetailCustomer> CartsDetailCustomeres { get; set; }
    public DbSet<CategoryProduct> CategoryProductes { get; set; }
    public DbSet<ProductCarts> ProductCartses { get; set; }
    public DbSet<Products> Products{ get; set; }
    public DbSet<Order> Orders{ get; set; }
    public DbSet<OrderDetails> OrderDetails{ get; set; }
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductCartsConfiguration());
        modelBuilder.ApplyConfiguration(new CartsConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        modelBuilder.ApplyConfiguration(new CustomersConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriesProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new CartsDetailCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());


    }
}