using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;

namespace TruckScale.Library.Repositories
{
    public class TransactionRepository : ITransactionRepository, IDisposable
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<WeighingTransaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public WeighingTransaction? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(WeighingTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
