using Microsoft.AspNetCore.Mvc;
using Natural_website.API.Models;
using Natural_website.Application.Interfaces;

namespace Natural_website.API.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await productService.GetAllProducts());

            //try
            //{
            //    var products = await _naturalDbContext.Products.ToListAsync();
            //    return Ok(products);
            //}
            //catch (Exception e)
            //{

            //    return BadRequest();
            //}
        }

        [HttpGet]
        public async Task<IActionResult> Jucys()
        {
            return Ok(await productService.Jucys());

            //var products = await _naturalDbContext.Products.Where(x => x.Section == "Products") .ToListAsync();
            //return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> Handmades()
        {
            return Ok(await productService.Handmades());


            //var products = await _naturalDbContext.Products.Where(x => x.Section == "Handmade").ToListAsync();
            //return Ok(products);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            return Ok(await productService.GetProduct(id));


            //var product = await _naturalDbContext.Products.FindAsync(id);
            //return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product productRequest)
        {
            return Ok(await productService.AddProduct(productRequest));


            //await _naturalDbContext.Products.AddAsync(productRequest);
            //await _naturalDbContext.SaveChangesAsync();

            //return Ok(productRequest);
        }

        [HttpPut]
        [Route("{id:int}")]

        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product productRequest)
        {
            return Ok(await productService.UpdateProduct(id, productRequest));


            //var product = await _naturalDbContext.Products.FindAsync(id);

            //if (product == null)
            //{
            //    return NotFound();
            //}

            //product.Name = productRequest.Name;
            //product.Price = productRequest.Price;
            //product.Avaibility = productRequest.Avaibility;
            //product.Description = productRequest.Description;
            //product.Provide_Date = productRequest.Provide_Date;
            //product.Product_Discount = productRequest.Product_Discount;
            //product.Comment = productRequest.Comment;
            //product.Section = productRequest.Section;
            //product.Picture = productRequest.Picture;
            //product.Provider = productRequest.Provider;

            //await _naturalDbContext.SaveChangesAsync();

            //return Ok(product);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return Ok(await productService.DeleteProduct(id));
            //var product = await _naturalDbContext.Products.FindAsync(id);
            
            //if (product == null)
            //{
            //    return NotFound();
            //}

            //_naturalDbContext.Products.Remove(product);
            //await _naturalDbContext.SaveChangesAsync();

            //return Ok();
        }
    }
}
