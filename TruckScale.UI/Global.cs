using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckScale_App
{
    public static class Global
    {
        public static string AppDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        public static string TextFileName { get; set; } = "Templates\\ScaleTicket.txt";
    }
}
