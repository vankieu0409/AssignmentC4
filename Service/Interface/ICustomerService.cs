using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface ICustomerService
{
    IEnumerable<CustomerViewModel> GetCollection();
    Task CreateCustomer(CustomerViewModel ctmInput);
    Task UpdateCustomer(CustomerViewModel ctmInput);
    Task DeleteCustomer(CustomerViewModel ctmInput);
}