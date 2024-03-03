using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface IApplicationService
    {
        int AddCustomer(string name);
        int AddProduct(string name);
        int AddSupplier(string name);
        int AddTruck(string platenumber);
        List<FlatWeighingTransaction> FlattenTransactionRecords(IQueryable<WeighingTransaction> weighingTransactions);
        Customer GetCustomerByName(string name);
        List<Customer> GetCustomers();
        FlatWeighingTransaction GetDisplayTransaction(int id);
        Product GetProductByName(string name);
        List<Product> GetProducts();
        Supplier GetSupplierByName(string name);
        List<Supplier> GetSuppliers();
        int GetTicketNumber();
        WeighingTransaction GetTransaction(int id);
        List<WeighingTransaction> GetTransactionsByDate(DateTime startDate, DateTime endDate);
        Truck GetTruckByPlate(string platenumber);
        List<Truck> GetTrucks();
        Weigher GetWeigherByName(string name);
        void InsertTransaction(WeighingTransaction transaction);
        void InsertWeigher(Weigher weigher);
        void SeedWeigher(Weigher weigher);
        void UpdateTransaction(WeighingTransaction transaction);
    }
}