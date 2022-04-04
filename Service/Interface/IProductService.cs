
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface IProductService
{
    IEnumerable<ProductViewModel> GetCollection();
    Task CreateProduct(ProductViewModel productNew);
    Task UpdateProduct(ProductViewModel productUpdate);
    Task DeleteProduct(ProductViewModel productDelete);
}