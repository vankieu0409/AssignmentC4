using AssignmentC4.Entities;
using AssignmentC4.Repositories.Interface;
using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.Show;
using AutoMapper;

namespace AssignmentC4.Service.Implement;

public class CustomerService:ICustomerService
{
    private readonly GenericInterface<Customer> _customer;
    private readonly IMapper _mapper;

    public CustomerService(GenericInterface<Customer> customer, IMapper mapper)
    {
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public IEnumerable<CustomerViewModel> GetCollection()
    {
        var listTemp = _customer.GetAll().Where(c => c.IsDeleted == true).ToList();
        return _mapper.Map<List<CustomerViewModel>>(listTemp);
        
    }


    public async Task CreateCustomer(CustomerViewModel ctmInput)
    {
        var CustomerTemp = _mapper.Map<Customer>(ctmInput);
        CustomerTemp.IdCustomer = Guid.NewGuid();
        CustomerTemp.IsDeleted = true;
        await _customer.AddAsync(CustomerTemp);


    }
    public async Task UpdateCustomer(CustomerViewModel customer)
    {
        var customerEditet = _mapper.Map<Customer>(customer);
        await _customer.UpdateAsync(customerEditet);
    }
    public async Task DeleteCustomer(CustomerViewModel customer)
    {
        var customerEditet = _mapper.Map<Customer>(customer);
        customerEditet.IsDeleted = false;
        await _customer.UpdateAsync(customerEditet);
    }

}