using Microsoft.EntityFrameworkCore;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class TransactionRepository : ITransactionRepository, IDisposable
    {
        private ScaleDbContext dbContext;

        public TransactionRepository(ScaleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            var rec = dbContext.WeighingTransactions.Find(id);
            if (rec != null)
            {
                dbContext.WeighingTransactions.Remove(rec);
                dbContext.SaveChanges();
            }
        }


        public IQueryable<WeighingTransaction> GetRangedRecords(DateTime startdate, DateTime enddate)
        {
            var trans = dbContext.WeighingTransactions
                .Include(w => w.Customer)
                .Include(w => w.Supplier)
                .Include(w => w.Product)
                .Include(w => w.Truck)
                .Include(w => w.Weigher)
                .Where(w => w.FirstWeightDate >= startdate && w.FirstWeightDate <= enddate);

            return trans;
        }

        public List<WeighingTransaction> GetAll()
        {
            return dbContext.WeighingTransactions.ToList();
        }

        public WeighingTransaction? GetById(int id)
        {
            var transaction = dbContext.WeighingTransactions
                .Include(w => w.Customer)
                    .Include(w => w.Supplier)
                    .Include(w => w.Product)
                    .Include(w => w.Truck)
                    .Include(w => w.Weigher)
                    .Where(w => w.Id == id);

            return transaction.FirstOrDefault();
        }

        public void Insert(WeighingTransaction transaction)
        {
            var rec = dbContext.WeighingTransactions.Find(transaction.Id);
            if (rec is null)
            {
                dbContext.WeighingTransactions.Add(transaction);
                dbContext.SaveChanges();
            }
        }

        public int GetTicketNumber()
        {
            var maxTicket = dbContext.WeighingTransactions.Max(x => x.TicketNumber);
            return maxTicket + 1;
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
