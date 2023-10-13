using AppLibrary.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using TruckScale.UI.Forms;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var conString = ConfigurationManager.ConnectionStrings["default"].ToString();
            var services = new ServiceCollection();

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(conString)
            );



            Application.Run(new MainForm());
        }
    }
}