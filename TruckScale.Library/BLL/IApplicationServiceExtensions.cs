using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.BLL
{
    public interface IApplicationServiceExtensions
    {
        void DeleteTransaction(int id);
        List<TransacionDTO> FlattenTransactionRecords(List<WeighingTransaction> weighingTransactions);
        WeighingTransaction GetById(int id);
        List<Customer> GetCustomers();
        TransacionDTO GetDisplayTransaction(int id);
        List<Product> GetProducts();
        List<TransacionDTO> GetRangedTransactions(DateTime startDate, DateTime endDate);
        List<Supplier> GetSuppliers();
        int GetTicketNumber();
        List<WeighingTransaction>? GetTransactionsByDate(DateTime startDate, DateTime endDate);
        void InsertNewTransaction(TransacionDTO transaction);
        void SeedWeigher(Weigher weigher);
        void UpdateTransaction(TransacionDTO transaction);
        Customer ValidateCustomer(string name);
        Product ValidateProduct(string name);
        Supplier ValidateSupplier(string name);
        Truck ValidateTruck(string plateNumber);
        Weigher ValidateUser(string username);
    }
}