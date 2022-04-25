using AssignmentC4.Entities;

namespace AssignmentC4.ViewModels.Show;

public class CartViewModels
{
    public Guid CartID { get; set; }
    public Guid CustomerID { get; set; }
    public float TotalCost { get; set; }
    public bool IsDeleted { get; set; }
}