using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.Show;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentC4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService?? throw  new  ArgumentNullException(nameof(cartService));
        }

        [HttpGet("myCart/{idCart}")]
        public Task<List<ProductViewModelsCart>> GetProductInCart(Guid idCart)
        {
            return _cartService.GetProductsInGioHang(idCart);
        }
        //[HttpGet("historyCart")]
        //public Task<List<ProductViewModelsCart>> GetProductInGioHang(Guid idCart)
        //{
        //    var history = _cartService.
        //}
    }
}
