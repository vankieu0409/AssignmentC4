namespace AssignmentC4.ViewModels.ModelCommand.Cart;

public class AddProToCartViewModel
{
    public Guid idProduct { get; set; }
    public string NameProduct { get; set; }
    public Int64 Price { get; set; }
    public int Quantity { get; set; }

    public byte Image { get; set; }
}