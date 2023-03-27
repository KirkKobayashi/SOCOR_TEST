using SpreadsheetLight;
using TruckScale.Library.Data.Models;
using System.Data;
using System.Linq;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace TruckScale.Library.Printing
{
    public class ScaleReport
    {
        private readonly string _fileName;
        private readonly string _filePath;
        private string _fullPath;

        public ScaleReport(string filePath)
        {
            _filePath = filePath;
        }

        public void ExportReport(List<WeighingTransaction> weighingTransactions)
        {
            try
            {
                SLDocument doc = new SLDocument();
                var dt = ConvertToDataTable(weighingTransactions);

                doc.ImportDataTable(3, 1, dt, true);

                var stats = doc.GetWorksheetStatistics();
                var columnCount = stats.NumberOfColumns;
                var rowCount = stats.NumberOfRows;
                var totalNet = weighingTransactions.Sum(x => (Math.Abs(x.FirstWeight - x.SecondWeight)));
                var style = doc.CreateStyle();

                style.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Left; 

                for (int i = 1; i < columnCount + 2; i++)
                {
                    doc.SetColumnWidth(i, 20);
                }

                doc.SetCellValue(rowCount + 4, columnCount - 1, "Total Net Weight:");
                doc.SetCellValue(rowCount + 4, columnCount, totalNet);
                doc.SetCellStyle(rowCount + 4, columnCount, style);
                
                var fileName = $@"Scale_Report_{DateTime.Now.ToString("MMddyyyy")}.xlsx";
                var savePath = Path.Combine(_filePath, fileName);
                doc.SaveAs(savePath);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private SLStyle GetComlumnAlignment(SLDocument sld
        //{
        //    var style = sld.CreateStyle();

        //}

        private DataTable ConvertToDataTable(List<WeighingTransaction> weighings)
        {
            try
            {
                var dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Plate Number");
                dt.Columns.Add("Supplier");
                dt.Columns.Add("Customer");
                dt.Columns.Add("Product");
                dt.Columns.Add("Weigh Date/Time");
                dt.Columns.Add("Weigher");
                dt.Columns.Add("First Weight");
                dt.Columns.Add("Second Weight");
                dt.Columns.Add("Net Weight");

                foreach (var i in weighings)
                {
                    var netweight = Math.Abs(i.FirstWeight - i.SecondWeight);
                    dt.Rows.Add(i.Id, i.Truck.PlateNumber, i.Supplier.Name, i.Customer.Name, i.Product.Name, i.FirstWeightDate.ToString("HH:mm mm-dd-yyyy"), i.Weigher.FirstName + " " + i.Weigher.LastName, i.FirstWeight, i.SecondWeight, netweight);
                }

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
