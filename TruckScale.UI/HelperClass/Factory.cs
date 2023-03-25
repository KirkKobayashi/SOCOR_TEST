using System.Configuration;
using TruckScale.Library.BLL;
using TruckScale.ScaleSerialPort;

namespace TruckScale.UI.HelperClass
{
    public static class Factory
    {
        public static ApplicationService GetApplicationService()
        {
            return new ApplicationService(new Library.Data.DBContext.ScaleDbContext(ConStringHelper.Get()));
        }


    }
}
