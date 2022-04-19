using Microsoft.Data.SqlClient.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class ProductCarts
{
    public Guid IdProduct { get; set; }
    public Guid IdCart { get; set; }
    [Required]
    [Range(0,int.MaxValue)]
    public Int64 Price { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Products Products { get; set; }
    public virtual Carts Carts { get; set; }
}