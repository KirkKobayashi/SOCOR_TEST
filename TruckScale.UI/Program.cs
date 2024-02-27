using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Configuration;
using TruckScale.Library.Data.DBContext;
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

            var services = new ServiceCollection();
            services.AddDbContext<ScaleDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });


            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}