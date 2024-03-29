﻿using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Interfaces
{
    public interface ISupplierRepository
    {
        void Delete(int id);
        void Dispose();
        Supplier? GetById(int id);
        List<Supplier> GetAll();
        int Insert(Supplier supplier);
        Supplier GetSupplierByName(string name);
    }
}
