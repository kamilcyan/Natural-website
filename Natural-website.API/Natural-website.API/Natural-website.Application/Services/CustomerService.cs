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
    internal class CustomerService : ICustomerService
    {
        private NaturalDbContext _naturalDbContext;
        public CustomerService(NaturalDbContext naturalDbContext)
        {
            _naturalDbContext = naturalDbContext;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var customers = await _naturalDbContext.Customers.ToListAsync();

            return customers;
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await _naturalDbContext.Customers.FindAsync(id);
        }

        public async Task<Customer> AddCustomer(Customer customerRequest)
        {
            await _naturalDbContext.Customers.AddAsync(customerRequest);
            await _naturalDbContext.SaveChangesAsync();
            return customerRequest;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customerRequest)
        {
            var customer = await _naturalDbContext.Customers.FindAsync(id);

            if (customer == null)
            {
                return customer;
            }

            customer.First_Name = customerRequest.First_Name;
            customer.Last_Name = customerRequest.Last_Name;
            customer.AddressLine1 = customerRequest.AddressLine1;
            customer.AddressLine2 = customerRequest.AddressLine2;
            customer.AddressLine3 = customerRequest.AddressLine3;
            customer.Phone = customerRequest.Phone;
            customer.Email = customerRequest.Email;
            customer.Status = customerRequest.Status;
            customer.Customer_Discount = customerRequest.Customer_Discount;
            customer.Comment = customerRequest.Comment;

            await _naturalDbContext.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _naturalDbContext.Customers.FindAsync(id);

            if (customer == null)
            {
                return customer;
            }

            _naturalDbContext.Customers.Remove(customer);
            await _naturalDbContext.SaveChangesAsync();

            return customer;
        }
    }
}
