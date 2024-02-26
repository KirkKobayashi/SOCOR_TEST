using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.ScaleSerialPort;

namespace TruckScale.UI.HelperClass
{
    public static class SettingsGetter
    {
        public static ScalePort Get()
        {
            var sp = new ScalePort
            {
                PortName = ConfigurationManager.AppSettings["portname"],
                StartIndex = Convert.ToInt32(ConfigurationManager.AppSettings["startIndex"]),
                EndIndex = Convert.ToInt32(ConfigurationManager.AppSettings["endIndex"]),
                BaudRate = Convert.ToInt32(ConfigurationManager.AppSettings["baudrate"]),
                TerminationCharacter = (char)Convert.ToInt32(ConfigurationManager.AppSettings["terminationChar"]),
                ReceivedBytesThreshold = Convert.ToInt32(ConfigurationManager.AppSettings["rthreshold"]),
                ReadBufferSize = Convert.ToInt32(ConfigurationManager.AppSettings["rbuffersize"]),
                DtrEnable = true

            };
            return sp;
        }


        public static PrintSettings GetPrintSettings()
        {
            var printSettings = new PrintSettings
            {
                PrinterName = ConfigurationManager.AppSettings["Printername"],
                startX = Convert.ToInt32(ConfigurationManager.AppSettings["startx"]),
                startY = Convert.ToInt32(ConfigurationManager.AppSettings["starty"]),
                yOffset = Convert.ToInt32(ConfigurationManager.AppSettings["yoffset"]),
                xOffset = Convert.ToInt32(ConfigurationManager.AppSettings["xoffset"]),
                HeaderFont = ConfigurationManager.AppSettings["headerfont"],
                HeaderFontHeight = Convert.ToInt32(ConfigurationManager.AppSettings["headerfontheight"]),
                BodyFont = ConfigurationManager.AppSettings["Bodyfont"],
                BodyFontHeigt = Convert.ToInt32(ConfigurationManager.AppSettings["bodyfontheight"]),
                PaperSize_X = Convert.ToInt32(ConfigurationManager.AppSettings["papersize_x"]),
                PaperSize_Y = Convert.ToInt32(ConfigurationManager.AppSettings["papersize_y"]),
                HeaderText1 = ConfigurationManager.AppSettings["headertext1"],
                HeaderText2 = ConfigurationManager.AppSettings["headertext2"]
            };

            return printSettings;
        }
    }
}
