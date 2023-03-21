using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface IWeigherRepository
    {
        void Delete(int id);
        void Dispose();
        Weigher? GetById(int id);
        List<Weigher> GetAll();
        void Insert(Weigher weigher);
    }
}
