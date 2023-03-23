using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;

namespace TruckScale.Library.BLL
{
    public class ApplicationService : IApplicationService
    {
        private readonly ScaleDbContext? dbContext;

        public ApplicationService(ScaleDbContext? dbContext)
        {
            this.dbContext = dbContext;
        }
        #region Weighing

        public List<Customer> GetCustomers()
        {
            return dbContext.Customers.ToList();
        }

        public List<Supplier> GetSuppliers()
        {
            return dbContext.Suppliers.ToList();
        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Supplier GetSupplierByName(string name)
        {
            var service = new SupplierRepository(dbContext);
            return service.GetSupplierByName(name);
        }

        public Customer GetCustomerByName(string name)
        {
            var service = new CustomerRepository(dbContext);
            return service.GetCustomerByName(name);
        }

        public Truck GetTruckByPlate(string platenumber)
        {
            var service = new TruckRepository(dbContext);
            return service.GetTruckByPlateNumber(platenumber);
        }

        public Product GetProductByName(string name)
        {
            var service = new ProductRepository(dbContext);
            return service.GetProductByName(name);
        }

        public int AddSupplier(string name)
        {
            var service = new SupplierRepository(dbContext);
            return service.Insert(new Supplier { Name = name, Active = true });
        }

        public int AddCustomer(string name)
        {
            var service = new CustomerRepository(dbContext);
            return service.Insert(new Customer { Name = name, Active = true });
        }

        public int AddProduct(string name)
        {
            var service = new ProductRepository(dbContext);
            return service.Insert(new Product { Name = name, Active = true });
        }

        public int AddTruck(string platenumber)
        {
            var service = new TruckRepository(dbContext);
            return service.Insert(new Truck { PlateNumber = platenumber });
        }

        public void InsertTransaction(WeighingTransaction transaction)
        {
            dbContext.WeighingTransactions.Add(transaction);
            dbContext.SaveChanges();
        }

        public void UpdateTransaction(WeighingTransaction transaction)
        {
            dbContext.WeighingTransactions.Add(transaction);
            dbContext.WeighingTransactions.Attach(transaction);
            dbContext.Entry(transaction).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public IEnumerable<WeighingTransaction> GetTransactionsByDate(DateTime startDate, DateTime endDate)
        {
            return dbContext.WeighingTransactions.Where(t => t.FirstWeightDate >= startDate && t.FirstWeightDate <= endDate);
        }
        #endregion

        #region Weigher
        public Weigher GetWeigherByName(string name)
        {
            var db = new WeigherRepository(dbContext);

            if (name != null)
            {
                return db.GetByName(name);
            }
            return null;
            
        }

        public void InsertWeigher(Weigher weigher)
        {
            var rec = dbContext.Weighers.FirstOrDefault(x => x.UserName == weigher.UserName);

            if (rec is null)
            {
                dbContext.Weighers.Add(weigher);
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Weighers.Add(rec);
                dbContext.Weighers.Attach(weigher);
                dbContext.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        #endregion
    }
}
