using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class TruckRepository : ITruckRepository, IDisposable
    {
        private ScaleDbContext dbContext;

        public TruckRepository(ScaleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            Truck truck = dbContext.Trucks.Find(id);

            if (truck is null)
            {
                return;
            }
            dbContext.Trucks.Remove(truck);
            dbContext.SaveChanges();
        }

        public List<Truck> GetAll()
        {
            var trucks = dbContext?.Trucks.ToList();
            return trucks;
        }

        public Truck? GetById(int id)
        {
            var truck = dbContext?.Trucks.Find(id);
            if (truck is null)
            {
                return null;
            }
            return truck;
        }

        public void Insert(Truck truck)
        {
            var rec = dbContext.Trucks.Find(truck.Id);
            if (rec is null)
            {
                dbContext.Trucks.Add(truck);
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
