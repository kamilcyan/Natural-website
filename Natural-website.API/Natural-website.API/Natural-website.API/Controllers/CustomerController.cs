using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Natural_website.API.DAL;
using Natural_website.API.Models;

namespace Natural_website.API.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class CustomerController : Controller
    {
        public NaturalDbContext _naturalDbContext { get; }

        public CustomerController()
        {
            //_naturalDbContext = naturalDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            //var customers = await _naturalDbContext.Customers.ToListAsync();
            //return Ok(customers);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer(int id)
        {
            //var customer = await _naturalDbContext.Customers.FindAsync(id);
            //return Ok(customer);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(List<string> data)
        {
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(List<string> data)
        {
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            return View();
        }
    }
}
