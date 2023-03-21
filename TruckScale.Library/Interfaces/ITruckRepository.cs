using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface ITruckRepository
    {
        void Delete(int id);
        void Dispose();
        Truck? GetById(int id);
        List<Truck> GetAll();
        void Insert(Truck truck);
    }
}
