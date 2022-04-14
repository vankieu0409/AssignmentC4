
using AssignmentC4.ViewModels.ModelCommand;
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface IProductService
{
    IEnumerable<ProductViewModel> GetCollection();
    Task CreateProduct(ProductViewModel productNew);
    Task UpdateProduct(ProductCUDViewModel productUpdate);
    Task DeleteProduct(ProductCUDViewModel productDelete);
}