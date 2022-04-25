using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentC4.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        List<int> _items = new List<int>();
        [DisableCors]
        [HttpPost]
        public IActionResult Add([FromBody] int item)
        {
            _items.Add(item);
            return Ok(_items);
        }
    }
}
