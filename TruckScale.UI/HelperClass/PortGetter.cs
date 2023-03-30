using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.ScaleSerialPort;

namespace TruckScale.UI.HelperClass
{
    public static class PortGetter
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
    }
}
