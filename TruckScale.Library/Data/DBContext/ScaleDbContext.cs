using Microsoft.EntityFrameworkCore;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Data.DBContext
{
    public class ScaleDbContext : DbContext
    {
        private string _constring;

        public ScaleDbContext(string constring) 
        {
            _constring = constring;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_constring);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Weigher> Weighers { get; set; }
        public DbSet<WeighingTransaction> WeighingTransactions { get; set; }
    }
}
