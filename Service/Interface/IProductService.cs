using AssignmentC4.ViewModels.DTOs;
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface IProductService
{
    IEnumerable<ProductViewModel> GetCollection();
    Task CreateProduct(ProductViewModel productNew);
    Task UpdateProduct(ProductInput productUpdate);
}