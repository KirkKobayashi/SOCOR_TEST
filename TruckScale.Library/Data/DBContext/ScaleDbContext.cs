using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
        private string _constring;

        public ScaleDbContext(string constring) 
        {
            _constring = constring;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //_constring = @"Server=wearelegion; Database=dbWb; Trusted_Connection=true; Encrypt=No; TrustServerCertificate=yes";
            //optionsBuilder.UseSqlServer(_constring, builder =>
            //{
            //    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            //});

            optionsBuilder.UseSqlServer(_constring);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);


            //optionsBuilder.UseSqlServer("your_connection_string", builder =>
            //{
            //    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            //});
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Weigher> Weighers { get; set; }
        public DbSet<WeighingTransaction> WeighingTransactions { get; set; }
    }
}
