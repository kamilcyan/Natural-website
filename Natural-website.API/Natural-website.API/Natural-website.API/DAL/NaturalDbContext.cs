using Microsoft.EntityFrameworkCore;
using Natural_website.API.Models;

namespace Natural_website.API.DAL
{
    public class NaturalDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public NaturalDbContext(DbContextOptions<NaturalDbContext> options)
        : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}
    }
}
