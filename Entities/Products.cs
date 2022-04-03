using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class Products
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdProduct { get; set; }  
    public Guid ICProduct { get; set; }  
    public string  NameProduct { get; set; }  
    public Int64 Price { get; set; }  
    public Int64 ImportPrice { get; set; }
    public byte Image { get; set; }
    public bool IsDeleted { get; set; }
    public  ICollection<ProductCarts> ProductCarts { get; set; }
    public  ICollection<CategoryProduct> CategoryProducts { get; set; }
}