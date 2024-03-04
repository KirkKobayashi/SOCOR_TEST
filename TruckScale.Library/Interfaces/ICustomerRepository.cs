using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface ICustomerRepository
    {
        void Delete(int id);
        void Dispose();
        Customer? GetById(int id);
        List<Customer> GetAll();
        int Insert(Customer customer);
        Customer GetCustomerByName(string name);
        void Update(Customer customer);
    }
}