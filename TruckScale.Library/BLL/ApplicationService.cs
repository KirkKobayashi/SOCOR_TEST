using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.DTOs;
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
            using (var service = new CustomerRepository(dbContext))
            {
                return service.GetAll();
            }
        }

        public List<Supplier> GetSuppliers()
        {
            using (var service = new SupplierRepository(dbContext))
            {
                return service.GetAll();
            }
        }

        public List<Product> GetProducts()
        {
            using (var service = new ProductRepository(dbContext))
            {
                return service.GetAll();
            }
        }

        public List<Truck> GetTrucks()
        {
            using (var service = new TruckRepository(dbContext))
            {
                return service.GetAll();
            }
        }

        public Supplier GetSupplierByName(string name)
        {
            using (var service = new SupplierRepository(dbContext))
            {
                return service.GetSupplierByName(name);
            }
        }

        public Customer GetCustomerByName(string name)
        {
            using (var service = new CustomerRepository(dbContext))
            {
                return service.GetCustomerByName(name);
            }
        }

        public Truck GetTruckByPlate(string platenumber)
        {
            var service = new TruckRepository(dbContext);
            return service.GetTruckByPlateNumber(platenumber);
        }

        public Product GetProductByName(string name)
        {
            using (var service = new ProductRepository(dbContext))
            {
                return service.GetProductByName(name);
            }
        }

        public int AddSupplier(string name)
        {
            using (var service = new SupplierRepository(dbContext))
            {
                return service.Insert(new Supplier { Name = name, Active = true });
            }
                
        }

        public int AddCustomer(string name)
        {
            using (var service = new CustomerRepository(dbContext))
            {
                return service.Insert(new Customer { Name = name, Active = true });
            }
        }

        public int AddProduct(string name)
        {
            using (var service = new ProductRepository(dbContext))
            {
                return service.Insert(new Product { Name = name, Active = true });
            }
        }

        public int AddTruck(string platenumber)
        {
            var service = new TruckRepository(dbContext);
            return service.Insert(new Truck { PlateNumber = platenumber });
        }

        public int GetTicketNumber()
        {
            using (var service = new TransactionRepository(dbContext))
            {
                return service.GetTicketNumber();
            }
        }

        public void InsertTransaction(WeighingTransaction transaction)
        {
            using (var service = new TransactionRepository(dbContext))
            {
                service.Insert(transaction );
            }
        }

        public void UpdateTransaction(WeighingTransaction transaction)
        {
            dbContext.WeighingTransactions.Add(transaction);
            dbContext.WeighingTransactions.Attach(transaction);
            dbContext.Entry(transaction).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public WeighingTransaction GetTransaction(int id)
        {
            using (var service = new TransactionRepository(dbContext))
            {
                return service.GetById(id);
            }
        }

        public List<WeighingTransaction>? GetTransactionsByDate(DateTime startDate, DateTime endDate)
        {
            using (var service = new TransactionRepository(dbContext))
            {
                var trans = service.GetRangedRecords(startDate, endDate);
                return trans.ToList();
            }
        }

        public List<FlatWeighingTransaction> FlattenTransactionRecords(IQueryable<WeighingTransaction> weighingTransactions)
        {
            List<FlatWeighingTransaction> flatTransactions = new List<FlatWeighingTransaction>();

            foreach (var i in weighingTransactions)
            {
                flatTransactions.Add(new FlatWeighingTransaction
                {
                    TruckPlateNumber = i.Truck?.PlateNumber ?? string.Empty,
                    CustomerName = i.Customer?.Name ?? string.Empty,
                    SupplierName = i.Supplier?.Name ?? string.Empty,
                    ProductName = i.Product?.Name ?? string.Empty,
                    TicketNumber = i.TicketNumber,
                    FirstWeight = i.FirstWeight,
                    SecondWeight = i.SecondWeight,
                    Id = i.Id
                });
            }

            return flatTransactions;
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
