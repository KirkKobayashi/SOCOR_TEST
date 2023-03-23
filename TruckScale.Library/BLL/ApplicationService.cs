using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
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

        public void InsertSupplier(string name)
        {
            var supplier = dbContext.Suppliers.FirstOrDefault(x => x.Name == name);

            if (supplier is null)
            {
                dbContext.Suppliers.Add(new Supplier { Name = name, Active = true });
                dbContext.SaveChanges();
            }
        }

        public void InsertCustomer(string name)
        {
            var customer = dbContext.Customers.FirstOrDefault(x => x.Name == name);

            if (customer is null)
            {
                dbContext.Customers.Add(new Customer { Name = name, Active = true });
                dbContext.SaveChanges();
            }
        }

        public void InsertProduct(string name)
        {
            var product = dbContext.Products.FirstOrDefault(x => x.Name == name);

            if (product is null)
            {
                dbContext.Products.Add(new Product { Name = name, Active = true });
                dbContext.SaveChanges();
            }
        }

        public void InsertTruck(string platenumber, int tareweight)
        {
            var truck = dbContext.Trucks.FirstOrDefault(x => x.PlateNumber == platenumber);

            if (truck is null)
            {
                dbContext.Trucks.Add(new Truck { PlateNumber = platenumber, TareWeight = tareweight });
                dbContext.SaveChanges();
            }
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
