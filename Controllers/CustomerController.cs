using System.Threading.Tasks;
using CustomerAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers {
   [Route("api/[controller]")]
   public class CustomerController : Controller {
      private readonly ICustomerService _customerService;

      public CustomerController(ICustomerService customerService) {
            _customerService = customerService;
      }

      [HttpGet]
      [Route("[action]/{customerId}")]
      public async Task<IActionResult> GetCustomers(int customerId) {
            var customer = await _customerService.GetCustomersAsync(customerId);
         return Ok(customer);
      }
   }
}
