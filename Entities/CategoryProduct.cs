namespace AssignmentC4.Entities;

public class CategoryProduct
{
    public Guid IdProducts { get; set; }
    public Guid IdCategory { get; set; }
    public bool IsDeleted { get; set; }
    public Products Products { get; set; }
    public Categories Categories { get; set; }
}