using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckScale.Library.Printing
{
    public class ScaleReport
    {
        private readonly string _fileName;
        private readonly string _filePath;

        public ScaleReport(string fileName, string filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }

        public void ExportReport()
        {

        }
    }
}
