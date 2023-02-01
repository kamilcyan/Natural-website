using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Natural_website.API.DAL;
using Natural_website.API.Models;

namespace Natural_website.API.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ProductsController : Controller
    {
        public NaturalDbContext _naturalDbContext { get; }

        public ProductsController(NaturalDbContext naturalDbContext)
        {
            _naturalDbContext = naturalDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _naturalDbContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _naturalDbContext.Products.FindAsync(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(List<string> data)
        {
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(List<string> data)
        {
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return View();
        }
    }
}
