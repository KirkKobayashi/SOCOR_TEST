using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScaleUI.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;
using TruckScale.UI.Forms;
using TruckScale.UI.UserControls;

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
            services.AddScoped<ITicketPrinter, TicketPrinter>();
            services.AddScoped<IApplicationServiceExtensions, ApplicationServiceExtensions>();

            services.AddTransient<MainForm>();
            services.AddTransient<TransactionForm>();
            services.AddTransient<LogInForm>();
            services.AddTransient<CustomerCrudUC>();
            services.AddTransient<ProductCrudUC>();
            services.AddTransient<SupplierCrudUC>();
            services.AddTransient<TransactionsUC>();
            services.AddTransient<WeigherUC>();
        }
    }
}
