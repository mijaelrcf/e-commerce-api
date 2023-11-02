using e_commerce_api.Data;
using e_commerce_api.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_api.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;

        public CustomerService(DataContext context)
        {
            _context = context;
        }
        public Task<List<Customer>> Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> Update(Guid id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
