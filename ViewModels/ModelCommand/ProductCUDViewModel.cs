namespace AssignmentC4.ViewModels.ModelCommand;

public class ProductCUDViewModel
{
    public Guid IdProduct { get; set; }
    public string NameProduct { get; set; }
    public Int64 Price { get; set; }
    public Int64 ImportPrice { get; set; }
    public byte Image { get; set; }
    public bool IsDeleted { get; set; }
}