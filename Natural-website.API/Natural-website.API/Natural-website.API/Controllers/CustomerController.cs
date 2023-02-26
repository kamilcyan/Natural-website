using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Natural_website.API.DAL;
using Natural_website.API.Models;
using Natural_website.Application.Interfaces;

namespace Natural_website.API.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            //var customers = await _naturalDbContext.Customers.ToListAsync();
            //return Ok(customers);
            return Ok(await customerService.GetAllCustomers());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            //var customer = await _naturalDbContext.Customers.FindAsync(id);
            //return Ok(customer);
            return Ok(await customerService.GetCustomer(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customerRequest)
        {
            return Ok(await customerService.AddCustomer(customerRequest));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] Customer customerRequest)
        {
            return Ok(await customerService.UpdateCustomer(id, customerRequest)); ;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            return Ok(await customerService.DeleteCustomer(id));
        }
    }
}
