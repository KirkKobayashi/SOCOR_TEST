using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface ICustomerRepository
    {
        void Delete(int id);
        void Dispose();
        Customer? GetById(int id);
        List<Customer> GetAll();
        void Insert(Customer customer);
    }
}