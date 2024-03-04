using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface IWeigherRepository
    {
        void Delete(int id);
        Weigher GetById(int id);
        List<Weigher> GetAll();
        void Insert(Weigher weigher);
        Weigher GetByName(string name);
    }
}
