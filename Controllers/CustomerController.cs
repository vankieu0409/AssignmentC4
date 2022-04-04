using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.Show;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentC4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<CustomerViewModel> Get()
        {
            try
            {
                return _customerService.GetCollection().ToList();
            }
            catch (Exception e)
            {
                throw e;
            };
        }
        [HttpGet("SignIn/{acc}")]
        public IActionResult SignIn(string acc, string pass)
        {
            var PersonSignIn = _customerService.GetCollection()
                .Any(c => string.Equals(c.Account, acc) && string.Equals(c.Password, pass));
            if (PersonSignIn)
            {
                return Ok(" Dăng nhập thành công!");
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public IActionResult CreatCustomer(CustomerViewModel aModel)
        {

            _customerService.CreateCustomer(aModel);
            return Ok(" Thêm thành Công!");
        }
        [HttpPut]
        public IActionResult UpdateCustomer(CustomerViewModel aModel)
        {

            _customerService.UpdateCustomer(aModel);
            return Ok(" Thêm thành Công!");
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(CustomerViewModel aModel)
        {

            _customerService.DeleteCustomer(aModel);
            return Ok(" Thêm thành Công!");
        }
    }
}
