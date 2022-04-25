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
        [HttpGet("{id}")]
        public async Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> Get(Guid id)
        {
            var response = _cartService.GetAllProductsInCartAsyn(id);
            return response.Result;
        }
        [HttpPost]
        public async Task<IActionResult> Add(ViewModels.ModelCommand.Cart.CartViewModels pro)
        {
            await _cartService.AddProductsToCartAsyn(pro);
            var response = new
            {
                code = 200,
                status = "thêm thành công"
            };
            return Ok(response);
        }
    }
}
