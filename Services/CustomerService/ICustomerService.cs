using e_commerce_api.Models;

namespace e_commerce_api.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<List<Customer>> Add(Customer customer);
        Task<List<Customer>> Update(Guid id, Customer customer);
        Task<List<Customer>> Delete(Guid id);
    }
}
