using Microsoft.Data.SqlClient.Server;

namespace AssignmentC4.Entities;

public class ProductCarts
{
    public Guid IdProduct { get; set; }
    public Guid IdCart { get; set; }
    public int Quantity { get; set; }
    public Int64 Prime { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Products Products { get; set; }
    public virtual Carts Carts { get; set; }
}