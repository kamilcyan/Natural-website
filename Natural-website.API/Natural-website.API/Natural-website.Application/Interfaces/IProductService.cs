using Natural_website.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_website.Application.Interfaces
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProducts();
        public Task<List<Product>> Jucys();
        public Task<List<Product>> Handmades();
        public Task<Product> GetProduct(int id);
        public Task<Product> AddProduct(Product productRequest);
        public Task<Product> UpdateProduct(int id, Product productRequest);
        public Task<Product> DeleteProduct(int id);
    }
}
