using Microsoft.Data.SqlClient.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class ProductCarts
{
    public Guid IdProduct { get; set; }
    public Guid CustomerID { get; set; }
    [MinLength(5)]
    public string ProductName { get; set; }
    [Required]
    [Range(0,int.MaxValue)]
    public float Price { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    public bool IsDeleted { get; set; }
}