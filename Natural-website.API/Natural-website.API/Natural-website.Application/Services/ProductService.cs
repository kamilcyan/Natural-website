using Microsoft.EntityFrameworkCore;
using Natural_website.API.DAL;
using Natural_website.API.Models;
using Natural_website.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_website.Application.Services
{
    internal class ProductService : IProductService
    {
        private NaturalDbContext _naturalDbContext;
        public ProductService(NaturalDbContext naturalDbContext)
        {
            _naturalDbContext = naturalDbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await _naturalDbContext.Products.ToListAsync();

            return products;
        }

        public async Task<List<Product>> Jucys()
        {
            return await _naturalDbContext.Products.Where(x => x.Section == "Products").ToListAsync();
        }

        public async Task<List<Product>> Handmades()
        {
            return await _naturalDbContext.Products.Where(x => x.Section == "Handmade").ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _naturalDbContext.Products.FindAsync(id);
        }

        public async Task<Product> AddProduct(Product productRequest)
        {
            await _naturalDbContext.Products.AddAsync(productRequest);
            await _naturalDbContext.SaveChangesAsync();
            return productRequest;
        }

        public async Task<Product> UpdateProduct(int id, Product productRequest)
        {
            var product = await _naturalDbContext.Products.FindAsync(id);

            if (product == null)
            {
                return product;
            }

            product.Name = productRequest.Name;
            product.Price = productRequest.Price;
            product.Avaibility = productRequest.Avaibility;
            product.Description = productRequest.Description;
            product.Provide_Date = productRequest.Provide_Date;
            product.Product_Discount = productRequest.Product_Discount;
            product.Comment = productRequest.Comment;
            product.Section = productRequest.Section;
            product.Picture = productRequest.Picture;
            product.Provider = productRequest.Provider;

            await _naturalDbContext.SaveChangesAsync();

            return product;
        }

        public async Task<Product> DeleteProduct(int id)
        {
            var product = await _naturalDbContext.Products.FindAsync(id);

            if (product == null)
            {
                return product;
            }

            _naturalDbContext.Products.Remove(product);
            await _naturalDbContext.SaveChangesAsync();

            return product;
        }
    }
}
