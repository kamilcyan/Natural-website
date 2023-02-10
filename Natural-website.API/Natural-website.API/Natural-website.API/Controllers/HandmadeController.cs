using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Natural_website.API.DAL;

namespace Natural_website.API.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class HandmadeController : Controller
    {
        public NaturalDbContext _naturalDbContext { get; }

        public HandmadeController(NaturalDbContext naturalDbContext)
        {
            _naturalDbContext = naturalDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _naturalDbContext.Products.Where(x => x.Section == "Handmade").ToListAsync();
            return Ok(products);
        }
    }
}
