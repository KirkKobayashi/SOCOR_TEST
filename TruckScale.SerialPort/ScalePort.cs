using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace TruckScale.ScaleSerialPort
{
    public class ScalePort : SerialPort
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public char TerminationCharacter { get; set; }

    }
}
