﻿using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface IApplicationService
    {
        int AddCustomer(string name);
        int AddProduct(string name);
        int AddSupplier(string name);
        int AddTruck(string platenumber);
        Customer GetCustomerByName(string name);
        List<Customer> GetCustomers();
        Product GetProductByName(string name);
        List<Product> GetProducts();
        Supplier GetSupplierByName(string name);
        List<Supplier> GetSuppliers();
        IEnumerable<WeighingTransaction> GetTransactionsByDate(DateTime startDate, DateTime endDate);
        Truck GetTruckByPlate(string platenumber);
        Weigher GetWeigherByName(string name);
        void InsertTransaction(WeighingTransaction transaction);
        void InsertWeigher(Weigher weigher);
        void UpdateTransaction(WeighingTransaction transaction);
    }
}