using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class CustomerRepository : IDisposable, ICustomerRepository
    {
        private ScaleDbContext dbContext;

        public CustomerRepository(ScaleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Customer> GetAll()
        {
            return dbContext.Customers.ToList();
        }

        public void Insert(Customer customer)
        {
            dbContext.Customers.Add(customer);
        }

        public Customer? GetById(int id)
        {
            return dbContext.Customers.Find(id);
        }

        public void Delete(int id)
        {
            Customer customer = dbContext.Customers.Find(id);
            dbContext.Customers.Remove(customer);
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
