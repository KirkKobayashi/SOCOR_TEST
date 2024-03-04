using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class SupplierRepository : ISupplierRepository, IDisposable
    {
        private ScaleDbContext? dbContext;

        public SupplierRepository(ScaleDbContext? dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            Supplier supplier = dbContext.Suppliers.Find(id);

            if (supplier is null)
            {
                return;
            }
            dbContext.Suppliers.Remove(supplier);
        }

        public List<Supplier> GetAll()
        {
            var suppliers = dbContext?.Suppliers.ToList();
            return suppliers;
        }

        public Supplier? GetById(int id)
        {
           var supplier = dbContext?.Suppliers.Find(id);
            if (supplier is null)
            {
                return null;
            }
            return supplier;
        }

        public int Insert(Supplier supplier)
        {
            dbContext.Suppliers.Add(supplier);
            dbContext.SaveChanges();

            return supplier.Id;
        }

        public Supplier GetSupplierByName(string name)
        {
            return dbContext.Suppliers.FirstOrDefault(s => s.Name == name);
        }

        public void Update(Supplier supplier)
        {
            var rectoupdate = GetById(supplier.Id);

            if (rectoupdate != null)
            {
                rectoupdate.Name = supplier.Name;
                dbContext.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Customer record not found.");
            }
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
