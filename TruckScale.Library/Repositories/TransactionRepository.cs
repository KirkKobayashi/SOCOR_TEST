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
            return dbContext.WeighingTransactions.Where(w => w.FirstWeightDate <= startdate && w.FirstWeightDate >= enddate);
        }

        public List<WeighingTransaction> GetAll()
        {
            return dbContext.WeighingTransactions.ToList();
        }

        public WeighingTransaction? GetById(int id)
        {
            return dbContext.WeighingTransactions.Find(id);
        }

        public void Insert(WeighingTransaction transaction)
        {
            var rec = dbContext.WeighingTransactions.Find(transaction);
            if (rec is null)
            {
                dbContext.WeighingTransactions.Add(transaction);
                dbContext.SaveChanges();
            }
        }

        public int GetTicketNumber()
        {
            var maxTicket = dbContext.WeighingTransactions.Max(x => x.TicketNumber);
            return maxTicket+1;
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
