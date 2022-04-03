using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdCustomer { get; set; }
    public Guid ICCustomer { get; set; }
    public string CustomerName { get; set; }
    public bool? Sex { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
    public string? NumberPhone { get; set; }
    public bool IsDeleted { get; set; }
   
    public ICollection<CartsDetailCustomer> CartsDetailCustomers { get; set; }
   
}