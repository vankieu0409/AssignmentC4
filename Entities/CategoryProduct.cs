namespace AssignmentC4.Entities;

public class CategoryProduct
{
    public Guid IdProducts { get; set; }
    public Guid IdCategory { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Products Products { get; set; }
    public virtual Categories Categories { get; set; }
}