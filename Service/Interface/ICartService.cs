using AssignmentC4.ViewModels.ModelCommand.Cart;
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface ICartService
{
    public Task<List<ProductViewModelsCart>> GetProductsInGioHang(Guid idCart);
    Task<List<ProductViewModelsCart>> AddProductsToGioHang(Guid idcart, AddProToCartViewModel pro);
    Task<List<ProductViewModelsCart>> UpdateProductsToGioHang(Guid idcart, AddProToCartViewModel pro);
    Task<List<ProductViewModelsCart>> DeleteProductsInGioHang(Guid idcart, AddProToCartViewModel pro);
    public Task<List<ProductViewModelsCart>> GetAllListCart();
}