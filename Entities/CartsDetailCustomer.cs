namespace AssignmentC4.Entities;

public class CartsDetailCustomer
{
    public Guid  IdCarts { get; set; }
    public Guid  IdCustomer { get; set; }
   // public bool PaymentStatus { get; set; }
    public bool IsDeleted { get; set; }
    public Carts  Cartses { get; set; }
    public Customer  Customeres { get; set; }
}