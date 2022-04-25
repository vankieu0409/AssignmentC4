using AssignmentC4.ViewModels.ModelCommand.Cart;
using AssignmentC4.ViewModels.Show;

namespace AssignmentC4.Service.Interface;

public interface ICartService
{
    Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> GetAllProductsInCartAsyn(Guid id);
    Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> GetProductsInCartAsyn(Guid idCart);
    Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> AddProductsToCartAsyn(ViewModels.ModelCommand.Cart.CartViewModels pro);
    Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> UpdateProductsToCartAsyn(ViewModels.ModelCommand.Cart.CartViewModels pro);
    Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> DeleteProductsInCartAsyn(ViewModels.ModelCommand.Cart.CartViewModels pro);
}