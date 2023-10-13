using System.Configuration;

namespace TruckScale.UI.HelperClass
{
    public static class UpdateDirectoryHelper
    {
        public static void CreateDirectory()
        {
            try
            {
                var folderpath = ConfigurationManager.AppSettings["updatelocation"];

                if (!Directory.Exists(folderpath))
                {
                    Directory.CreateDirectory(folderpath);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
