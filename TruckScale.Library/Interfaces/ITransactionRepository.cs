using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface ITransactionRepository
    {
        void Delete(int id);
        void Dispose();
        WeighingTransaction? GetById(int id);
        List<WeighingTransaction> GetAll();
        void Insert(WeighingTransaction transaction);
        int GetTicketNumber();
        IQueryable<WeighingTransaction> GetRangedRecords(DateTime startdate, DateTime enddate);
        void Update(WeighingTransaction transaction);
        bool ValidateTicket(int ticketnumber);
    }
}
