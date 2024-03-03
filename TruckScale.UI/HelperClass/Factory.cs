using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Interfaces;
using TruckScale.Library.Repositories;

namespace TruckScale.UI.HelperClass
{
    public static class Factory
    {
        private static ScaleDbContext dbContex;
        public static ApplicationService GetApplicationService()
        {
            return new ApplicationService(GetDBContext());
        }

        public static IApplicationServiceExtensions GetApplicationServiceExtensions()
        {
            dbContex = GetDBContext();
            ICustomerRepository customer = new CustomerRepository(dbContex);
            ISupplierRepository supplier = new SupplierRepository(dbContex);
            ITruckRepository truck = new TruckRepository(dbContex);
            ITransactionRepository transaction = new TransactionRepository(dbContex);
            IWeigherRepository weigher = new WeigherRepository(dbContex);
            IProductRepository product = new ProductRepository(dbContex);

            return new ApplicationServiceExtensions(customer,supplier, product, truck, weigher, transaction);
        }

        public static ScaleDbContext GetDBContext()
        {
            var dbname = ConfigurationManager.AppSettings["dbname"].ToString();
            return new Library.Data.DBContext.ScaleDbContext(ConStringHelper.Get(dbname));
        }

    }
}
