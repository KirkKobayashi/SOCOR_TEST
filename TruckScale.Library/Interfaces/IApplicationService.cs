using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface IApplicationService
    {
        List<Customer> GetCustomers();
        List<Product> GetProducts();
        List<Supplier> GetSuppliers();
        IEnumerable<WeighingTransaction> GetTransactionsByDate(DateTime startDate, DateTime endDate);
        Weigher GetWeigherByName(string name);
        void InsertCustomer(string name);
        void InsertProduct(string name);
        void InsertSupplier(string name);
        void InsertTransaction(WeighingTransaction transaction);
        void InsertTruck(string platenumber, int tareweight);
        void InsertWeigher(Weigher weigher);
        void UpdateTransaction(WeighingTransaction transaction);
    }
}