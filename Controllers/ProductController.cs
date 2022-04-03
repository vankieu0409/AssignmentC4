using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.DTOs;
using AssignmentC4.ViewModels.Show;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentC4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet]
        public List<ProductViewModel> GetProduct()
        {
            return _productService.GetCollection().ToList();
        }

        [HttpPost]
        public IActionResult CreatAsyncResult(ProductViewModel productNew)
        {
            try
            {
                _productService.CreateProduct(productNew);
                return Ok("Thêm Thành Công!");
            }
            catch (Exception e)
            {
                return BadRequest($" Đang có lỗi nay {e}");
            }
        }

        [HttpPut("")]
        public IActionResult UpdtaeActionResult(Guid Id, string name)
        {
            try
            {
               // var productNewName =_productService.GetCollection().FirstOrDefault(c=>c.)
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
