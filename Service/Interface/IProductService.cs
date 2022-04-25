
using AssignmentC4.ViewModels.ModelCommand;
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface IProductService
{
    Task<IEnumerable<ProductViewModel>> GetCollectionAsync();
    Task<IEnumerable<ProductViewModel>> GetCollectionAdminAsync();
    Task<IEnumerable<ProductViewModel>> GetProductsAsync(Guid id);
    Task CreateProductAsync(ProductViewModel productNew);
    Task UpdateProductAsync(ProductViewModel productUpdate);
    Task DeleteProductAsync(ProductViewModel productDelete);
}