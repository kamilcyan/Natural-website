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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>
                (x => x.ToTable("PRODUCT"));
            modelBuilder.Entity<Product>()
                .HasKey(b => b.Product_Id);

            modelBuilder.Entity<Customer>
                (x => x.ToTable("Customer"));
            modelBuilder.Entity<Customer>()
                .HasKey(b => b.Customer_Id);

            modelBuilder.Entity<Order>
                (x => x.ToTable("Order"));
            modelBuilder.Entity<Order>()
                .HasKey(b => b.Order_Id);
        }
    }
}
