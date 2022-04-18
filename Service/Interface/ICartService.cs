using AssignmentC4.ViewModels.ModelCommand.Cart;
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface ICartService
{
     Task<List<CartProductFake>> GetProductsInGioHang(Guid idCart);
    Task<List<CartProductFake>> AddProductsToGioHang(Guid idcart, AddProToCartViewModel pro);
    Task<List<CartProductFake>> UpdateProductsToGioHang(Guid idcart, AddProToCartViewModel pro);
    Task<List<CartProductFake>> DeleteProductsInGioHang(Guid idcart, AddProToCartViewModel pro);
   // public Task<List<ViewModels.Show.CartViewModels>> GetAllListCart();
}