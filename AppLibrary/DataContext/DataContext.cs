using AppLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace AppLibrary.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User>  Users { get; set; } 
    }
}
