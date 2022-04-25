namespace AssignmentC4.ViewModels.ModelCommand.Cart;

public class CartViewModels
{
    public Guid ProductID { get; set; }
    public Guid CustomerID { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public bool IsDeleted { get; set; }
    public float Price { get; set; }
}