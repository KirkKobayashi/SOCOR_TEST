using TruckScale.Library.Data.DTOs;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace TruckScale.Report_Print
{
    public class ExcelHelper
    {
        private readonly string _filePath;
        private readonly string _fileName;
        //private Workbook _workbook;
        //private Application _application;
        //private Worksheet _worksheet;

        public ExcelHelper(string filepath, string fileName)
        {
            _filePath = filepath;
            _fileName = fileName;
        }

        public void PrintScaleTicket(FlatWeighingTransaction flatWeighingTransaction)
        {
            try
            {

                var newpath = Path.Combine(_filePath, _fileName);
                using (var workbook = new XLWorkbook(newpath))
                {
                    var worksheet = workbook.Worksheet("Sheet1");

                    var trans = flatWeighingTransaction;


                    worksheet.Cell("A6").Value = trans.TruckPlateNumber;
                    worksheet.Cell("A8").Value = trans.SupplierName;
                    worksheet.Cell("A10").Value = trans.CustomerName;
                    worksheet.Cell("A12").Value = trans.Quantity;
                    worksheet.Cell("A14").Value = trans.ProductName;
                    worksheet.Cell("A16").Value = trans.FirstWeighingDate;
                    worksheet.Cell("A18").Value = trans.SecondWeighingDate;
                    worksheet.Cell("A20").Value = trans.FirstWeight;
                    worksheet.Cell("A22").Value = trans.SecondWeight;
                    worksheet.Cell("A24").Value = Math.Abs(trans.FirstWeight - trans.SecondWeight);
                    worksheet.Cell("A25").Value = trans.WeigherName;
                    worksheet.Cell("A27").Value = trans.TicketNumber;

                    worksheet.PageSetup.FitToPages(1, 1);

                }
                //SLDocument doc = new SLDocument();
                //var trans = flatWeighingTransaction;

                //doc.SetCellValue("A6", trans.TruckPlateNumber);
                //doc.SetCellValue("A8", trans.SupplierName);
                //doc.SetCellValue("A10", trans.CustomerName);
                //doc.SetCellValue("A12", trans.Quantity);
                //doc.SetCellValue("A14", trans.ProductName);
                //doc.SetCellValue("A16", trans.FirstWeighingDate);
                //doc.SetCellValue("A18", trans.SecondWeighingDate);
                //doc.SetCellValue("A20", trans.FirstWeight);
                //doc.SetCellValue("A22", trans.SecondWeight);
                //doc.SetCellValue("A24", Math.Abs(trans.FirstWeight - trans.SecondWeight));
                //doc.SetCellValue("A25", trans.WeigherName);
                //doc.SetCellValue("A27", trans.TicketNumber);

                //doc.SaveAs(_filePath + "\\Templates\\ticketToPrint.xlsx");

                //Application app = new Application();
                //Workbook wb = app.Workbooks.Open(_filePath + "\\Templates\\ticketToPrint.xlsx");
                //wb.PrintOutEx();
                //wb.Close(false);
                //app.Quit();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}