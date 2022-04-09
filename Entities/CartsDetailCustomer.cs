namespace AssignmentC4.Entities;

public class CartsDetailCustomer
{
    public Guid  IdCarts { get; set; }
    public Guid  IdCustomer { get; set; }
   // public bool PaymentStatus { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Carts Cartses { get; set; }
    public virtual Customer Customeres { get; set; }
}