using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace TruckScale.Library.Data.DBContext
{
    public class DesignTimeDbContext : IDesignTimeDbContextFactory<ScaleDbContext>
    {
        public ScaleDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server = wearelegion; Database = dbWb; Trusted_Connection = true; Encrypt = No";

            var builder = new DbContextOptionsBuilder<ScaleDbContext>();
            builder.UseSqlServer(connectionString);

            return new ScaleDbContext(builder.Options);
        }
    }
}
