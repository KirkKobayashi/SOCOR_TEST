using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;

namespace TruckScale.UI.HelperClass
{
    public static class ServiceContainer
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            string connectionsString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            services.AddDbContext<ScaleDbContext>(options =>
                                                    options.UseSqlServer(connectionsString));

            services.AddSingleton<IUIFactory, UIFactory>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ITruckRepository, TruckRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IWeigherRepository, WeigherRepository>();
        }
    }
}
