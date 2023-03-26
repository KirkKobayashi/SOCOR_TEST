using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckScale.Report_Print
{
    public class ExcelHelper
    {
        private readonly string _filePath;

        private Workbook _workbook;
        private Application _application;
        private Worksheet _worksheet;

        public ExcelHelper(string filepath)
        {
            _filePath = filepath;
        }

        public void PrintScaleTicket(DataTable dataTable)
        {
            try
            {
                _application = new Application();
                _workbook = _application.Workbooks.Open(_filePath);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
