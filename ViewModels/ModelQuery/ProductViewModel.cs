namespace AssignmentC4.ViewModels.Show;

public class ProductViewModel
{
    public Guid IdProduct { get; set; }
    public string NameProduct { get; set; }
    public Int64 Price { get; set; }
    public int Quantity { get; set; }
    public Int64 ImportPrice { get; set; }
    public string Image { get; set; }
    public bool IsDeleted { get; set; }
}