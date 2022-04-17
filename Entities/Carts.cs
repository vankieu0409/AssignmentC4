using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class Carts
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CustomerID { get; set; }
    public Guid CartId { get; set; }
    [Range(0,double.MaxValue)]
    public float TotalCost { get; set; }
    public int CartStatus { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual ICollection<ProductCarts> ProductsCarts { get; set; }
}