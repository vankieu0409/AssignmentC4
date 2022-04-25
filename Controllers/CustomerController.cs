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

        [HttpGet("getAllCustomer")]
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
        [HttpPost("SignIn/{acc}/{pass}")]
        public IActionResult SignIn([FromRoute] string acc, string pass)
        {
            try
            {
                var PersonSignIn = _customerService.GetCollection()
                    .FirstOrDefault(c => string.Equals(c.Account, acc) && string.Equals(c.Password, pass));
                if (PersonSignIn != null)
                {
                    var obj = new
                    {
                        code = 200,
                        id = PersonSignIn.Account,
                        role = PersonSignIn.IsAdmin,
                        status = "Đăng nhập thành công !"
                    };
                    return Ok(obj);
                }
                else
                {
                    var obj = new
                    {
                        code = 404,
                        id = "",
                        role = "",
                        status = "Đăng nhập thành công !"
                    };
                    return Ok(obj);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw new Exception(e.Message);
            }
        }

        [HttpPost("createCustomer")]
        public IActionResult CreatCustomer(CustomerViewModel aModel)
        {
            try
            {
                _customerService.CreateCustomer(aModel);
                var response = new
                {
                    code = 200,
                    status = " Thêm thành Công!"
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw new Exception(e.Message);
            }
        }
        [HttpPut("updateCustomer")]
        public IActionResult UpdateCustomer(CustomerViewModel aModel)
        {
            try
            {
                _customerService.UpdateCustomer(aModel);
                var response = new
                {
                    code = 200,
                    status = " cập nhật thành Công!"
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message); 
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(CustomerViewModel aModel)
        {
            try
            {
                _customerService.DeleteCustomer(aModel);
                return Ok("đã xóa thành Công!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
