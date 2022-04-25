using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class Products
{
    [Key]
    public Guid IdProduct { get; set; }
    [Required]
    [MinLength(5)]
    public string  NameProduct { get; set; }  
    [Required]
    [Range(0,int.MaxValue)]
    public Int64 Price { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public Int64 ImportPrice { get; set; }
    public string Image { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<ProductCarts> ProductCarts { get; set; }
    public virtual ICollection<OrderDetails> OrderDetails { get; set; }
}