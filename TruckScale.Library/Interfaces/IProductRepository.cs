using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface IProductRepository
    {
        void Delete(int id);
        void Dispose();
        Product? GetById(int id);
        List<Product> GetAll();
        void Insert(Product product);
    }
}
