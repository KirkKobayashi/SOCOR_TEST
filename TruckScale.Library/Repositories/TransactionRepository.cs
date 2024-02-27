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
            try
            {
                var rec = dbContext.WeighingTransactions.Find(id);
                if (rec != null)
                {
                    dbContext.WeighingTransactions.Remove(rec);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IQueryable<WeighingTransaction> GetRangedRecords(DateTime startdate, DateTime enddate)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public List<WeighingTransaction> GetAll()
        {
            try
            {
                return dbContext.WeighingTransactions.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public WeighingTransaction? GetById(int id)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public void Insert(WeighingTransaction transaction)
        {
            try
            {
                var rec = dbContext.WeighingTransactions.Find(transaction.Id);
                if (rec is null)
                {
                    dbContext.WeighingTransactions.Add(transaction);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(WeighingTransaction transaction)
        {
            try
            {
                var ttU = dbContext.WeighingTransactions.Find(transaction.Id);
                ttU.SecondWeight = transaction.SecondWeight;
                ttU.SecondWeightDate = transaction.SecondWeightDate;
                ttU.FirstWeight = transaction.FirstWeight;
                ttU.FirstWeightDate = transaction.FirstWeightDate;
                ttU.TicketNumber = transaction.TicketNumber;
                ttU.Quantity = transaction.Quantity; 
                ttU.Driver = transaction.Driver;
                ttU.Remarks =   transaction.Remarks;
                

                dbContext.Update(ttU);
                //dbContext.Entry(transaction).CurrentValues.SetValues(transaction);
                dbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetTicketNumber()
        {
            try
            {
                var maxTicket = dbContext.WeighingTransactions.Max(x => x.TicketNumber);
                return maxTicket + 1;
            }
            catch (InvalidOperationException)
            {
                return 1;
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
