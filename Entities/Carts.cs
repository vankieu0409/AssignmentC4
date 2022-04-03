using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class Carts
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdCart { get; set; }
    public Guid ICCart { get; set; }
    public string NameCarts { get; set; }
    public bool IsDeleted { get; set; }
  
    public ICollection<CartsDetailCustomer> CartsDetailCustomers{ get; set; }
    public virtual ICollection<ProductCarts> ProductsCarts{ get; set; }
}