using Natural_website.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_website.Application.Interfaces
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetAllCustomers();
        public Task<Customer> GetCustomer(int id);
        public Task<Customer> AddCustomer(Customer customerRequest);
        public Task<Customer> UpdateCustomer(int id, Customer customerRequest);
        public Task<Customer> DeleteCustomer(int id);
    }
}
