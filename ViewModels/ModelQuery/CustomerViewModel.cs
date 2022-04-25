namespace AssignmentC4.ViewModels.Show;

public class CustomerViewModel
{
    public Guid ICCustomer { get; set; } = Guid.NewGuid(); 
    public string CustomerName { get; set; }
    public bool? Sex { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
    public string? NumberPhone { get; set; }
    public bool IsAdmin { get; set; }
}