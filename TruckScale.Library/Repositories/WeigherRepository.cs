using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using System.Data;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class WeigherRepository : IWeigherRepository, IDisposable
    {
        private ScaleDbContext dbContext;

        public WeigherRepository(ScaleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            var rec = dbContext.Trucks.Find(id);
            if (rec != null)
            {
                dbContext.Trucks.Remove(rec);
            }
            dbContext.SaveChanges();
        }

        public List<Weigher> GetAll()
        {
            return dbContext.Weighers.ToList();
        }

        public Weigher? GetById(int id)
        {
            return dbContext?.Weighers.Find(id);
        }

        public Weigher? GetByName(string name)
        {
            return dbContext?.Weighers.FirstOrDefault(w => w.UserName == name);
        }

        public void Insert(Weigher weigher)
        {
            var rec = dbContext.Weighers.Find(weigher.Id);
            if (rec is null)
            {
                dbContext.Weighers.Add(weigher);
                dbContext.SaveChanges();
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
