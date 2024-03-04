using Microsoft.Extensions.DependencyInjection;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ServiceContainer.ConfigureServices(services);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frm = serviceProvider.GetRequiredService<MainForm>();

                Application.Run(frm);
            }
        }
    }
}