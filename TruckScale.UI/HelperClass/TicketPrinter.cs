using System.Drawing.Printing;
using TruckScale.Library.Data.DTOs;

namespace TruckScale.UI.HelperClass
{
    public class TicketPrinter
    {
        private PrintDocument _document;
        private PrintDialog _printDialog;
        private FlatWeighingTransaction _recordToPrint;
        private PrintSettings _settings;

        public TicketPrinter(FlatWeighingTransaction recordToPrint, PrintSettings settings)
        {
            _document = new PrintDocument();
            _printDialog = new PrintDialog();
            _printDialog.Document = _document;
            _recordToPrint = recordToPrint;

            _document.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            _settings = settings;
        }

        public void Print()
        {
            DialogResult result = _printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = _document;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _document.Print();
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var headerFont = _settings.HeaderFont;
            var headerSize = _settings.HeaderFontHeight;
            var bodyFont = _settings.BodyFont;
            var bodySize = _settings.BodyFontHeigt;
            string separator = "---------------------------------------";

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            
            int startX = 10;
            int startY = 10;
            int Offset = 40;

            //HEADER 1 - COMPANY NAME
            graphics.DrawString(_settings.HeaderText1, new Font(headerFont, headerSize),
                                new SolidBrush(Color.Black), startX + 50, startY + Offset);
            //HEADER 2 - ADDRESS
            Offset = Offset + 20;
            graphics.DrawString(_settings.HeaderText2, new Font(headerFont, headerSize),
                              new SolidBrush(Color.Black), startX + 50, startY + Offset);

            //TICKET NUMBER
            Offset = Offset + 50;
            graphics.DrawString("Ticket No :",
                  new Font(bodyFont,bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(_recordToPrint.TicketNumber.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 250, startY + Offset);

            //SEPARATOR
            Offset = Offset + 10;
            graphics.DrawString(separator,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);

            //PLATENUMBER
            Offset = Offset + 30;
            graphics.DrawString("Plate Number :",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.TruckPlateNumber,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //CUSTOMER
            Offset = Offset + 30;
            graphics.DrawString($"Customer :",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.CustomerName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //SUPPLIER
            Offset = Offset + 30;
            graphics.DrawString($"Supplier :",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.SupplierName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //PRODUCT
            Offset = Offset + 30;
            graphics.DrawString($"Product :",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.SupplierName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //QUANTITY
            Offset = Offset + 30;
            graphics.DrawString($"Quantity : \n\n{_recordToPrint.Quantity}",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);

            //REMARKS
            Offset = Offset + 50;
            graphics.DrawString($"Remarks : \n\n{_recordToPrint.Remarks}",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);

            //SEPARATOR
            Offset = Offset + 50;
            graphics.DrawString(separator,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);

            //GROSS WEIGHT
            Offset = Offset + 30;
            graphics.DrawString($"GROSS WEIGHT",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.FirstWeight.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //GROSS WEIGHT
            Offset = Offset + 30;
            graphics.DrawString($"TARE WEIGHT",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(_recordToPrint.SecondWeight.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);
        }


    }
    
    
}
