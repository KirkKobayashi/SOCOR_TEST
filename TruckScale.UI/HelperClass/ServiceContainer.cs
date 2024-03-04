using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScaleUI.UI;
using System.Configuration;
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
            services.AddTransient<CustomerForm>();
            services.AddTransient<ProductForm>();
            services.AddTransient<SupplierForm>();
            services.AddTransient<TransactionsUC>();
            services.AddTransient<WeigherManagementForm>();
        }
    }
}
