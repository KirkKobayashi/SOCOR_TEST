using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.Models;

namespace TruckScale.Library.Data.DBContext
{
    public class ScaleDbContext : DbContext
    {
        //public ScaleDbContext(DbContextOptions<ScaleDbContext> options) : base(options)
        //{

        //}

        private const string ConnectionString = @"Server=wearelegion; Database=dbWb; Trusted_Connection=true; Encrypt=No; TrustServerCertificate=yes";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Weigher> Weighers { get; set; }
        public DbSet<WeighingTransaction> WeighingTransactions { get; set; }
    }
}
