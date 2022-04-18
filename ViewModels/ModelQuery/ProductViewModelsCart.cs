using AssignmentC4.Entities;

namespace AssignmentC4.ViewModels.Show;

public class ProductViewModelsCart
{
    public Guid CartID { get; set; }
    public float TotalCost { get; set; }
    public int CartStatus { get; set; }
    public bool IsDeleted { get; set; }
    public List<ProductCarts> LstProducts { get; set; }
}