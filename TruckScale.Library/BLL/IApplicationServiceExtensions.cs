using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.BLL
{
    public interface IApplicationServiceExtensions
    {
        void DeleteTransaction(int id);
        List<FlatWeighingTransaction> FlattenTransactionRecords(List<WeighingTransaction> weighingTransactions);
        WeighingTransaction GetById(int id);
        List<Customer> GetCustomers();
        FlatWeighingTransaction GetDisplayTransaction(int id);
        List<Product> GetProducts();
        List<FlatWeighingTransaction> GetRangedTransactions(DateTime startDate, DateTime endDate);
        List<Supplier> GetSuppliers();
        int GetTicketNumber();
        List<WeighingTransaction>? GetTransactionsByDate(DateTime startDate, DateTime endDate);
        void InsertNewTransaction(FlatWeighingTransaction transaction);
        void SeedWeigher(Weigher weigher);
        void UpdateTransaction(FlatWeighingTransaction transaction);
        Customer ValidateCustomer(string name);
        Product ValidateProduct(string name);
        Supplier ValidateSupplier(string name);
        Truck ValidateTruck(string plateNumber);
        Weigher ValidateUser(string username);
    }
}