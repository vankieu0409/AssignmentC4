using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.ModelCommand;
using AssignmentC4.ViewModels.Show;
using Microsoft.AspNetCore.Cors;
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

        [HttpGet("getProductForAdmin")]
        public Task<IEnumerable<ProductViewModel>> getProductForAdmin()
        {
            return _productService.GetCollectionAdminAsync();
        }

        [HttpGet]
        public Task <IEnumerable<ProductViewModel>> GetProduct()
        {
            var listProduct =  _productService.GetCollectionAsync();
            return listProduct;
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<ProductViewModel>> GetProducts(Guid id)
        {
            try
            {
                var resqponse = await _productService.GetProductsAsync(id);
                return resqponse;
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreatAsyncResult([FromBody] ProductViewModel productNew)
        {
            try
            {
                await _productService.CreateProductAsync(productNew);
                var response = Ok("Thêm Thành Công!");
                return response;
            }
            catch (Exception e)
            {
                return BadRequest($" Đang có lỗi nay {e}");
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdtaeActionResult([FromBody] ProductViewModel productupdate)
        {
            try
            {
                await _productService.UpdateProductAsync(productupdate);

                return Ok("Sửa Thành Công!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPut("Delete/{id}")]
        public async Task<IActionResult> DeleteActionResult(ProductViewModel productupdate)
        {
            try
            {
                await _productService.DeleteProductAsync(productupdate);

                return Ok("Xóa Thành Công!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
