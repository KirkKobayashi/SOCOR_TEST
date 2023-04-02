using System.Configuration;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.DBContext;
using TruckScale.ScaleSerialPort;

namespace TruckScale.UI.HelperClass
{
    public static class Factory
    {
        public static ApplicationService GetApplicationService()
        {
            return new ApplicationService(GetDBContext());
        }

        public static ScaleDbContext GetDBContext()
        {
            var dbname = ConfigurationManager.AppSettings["dbname"].ToString();
            return new Library.Data.DBContext.ScaleDbContext(ConStringHelper.Get(dbname));
        }

    }
}
