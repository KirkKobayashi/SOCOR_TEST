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
            string separator = "-----------------------------------------";

            e.PageSettings.PaperSize = new PaperSize("Custom", 400, 550);
            Graphics graphics = e.Graphics;
            
            int startX = _settings.startX;
            int startY = _settings.startY;
            int Offset = _settings.yOffset;

            SizeF title1Size = (graphics.MeasureString(_settings.HeaderText1, new Font(_settings.HeaderFont, _settings.HeaderFontHeight)));

            SizeF title2Size = (graphics.MeasureString(_settings.HeaderText2, new Font(_settings.HeaderFont, _settings.HeaderFontHeight)));

            float firstHeaderX = (400 - title1Size.Width) / 2;
            float secondHeaderX = (400 - title2Size.Width) / 2;


            //HEADER 1 - COMPANY NAME
            graphics.DrawString(_settings.HeaderText1, new Font(headerFont, headerSize),
                                new SolidBrush(Color.Black), firstHeaderX, startY + Offset);
            //HEADER 2 - ADDRESS
            Offset = Offset + 20;
            graphics.DrawString(_settings.HeaderText2, new Font(headerFont, headerSize),
                              new SolidBrush(Color.Black), secondHeaderX, startY + Offset);

            //TICKET NUMBER
            Offset = Offset + 30;
            graphics.DrawString("Ticket No",
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
            graphics.DrawString("Plate Number",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.TruckPlateNumber,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //CUSTOMER
            Offset = Offset + 30;
            graphics.DrawString($"Customer",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.CustomerName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //SUPPLIER
            Offset = Offset + 30;
            graphics.DrawString($"Supplier",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.SupplierName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //PRODUCT
            Offset = Offset + 30;
            graphics.DrawString($"Product",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.ProductName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //QUANTITY
            Offset = Offset + 30;
            graphics.DrawString($"Quantity",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(_recordToPrint.Quantity,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);

            //REMARKS
            Offset = Offset + 30;
            graphics.DrawString($"Remarks \n\n{_recordToPrint.Remarks}",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);

            //SEPARATOR
            Offset = Offset + 40;
            graphics.DrawString(separator,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);

            int grossweight;
            int tareweight;
            int netweight;

            netweight = Math.Abs(_recordToPrint.FirstWeight - _recordToPrint.SecondWeight);

            if (_recordToPrint.FirstWeight > _recordToPrint.SecondWeight)
            {
                grossweight = _recordToPrint.FirstWeight;
                tareweight = _recordToPrint.SecondWeight;
            }
            else
            {
                tareweight = _recordToPrint.FirstWeight;
                grossweight = _recordToPrint.SecondWeight;
            }

            //GROSS WEIGHT
            Offset = Offset + 30;
            graphics.DrawString($"GROSS WEIGHT (KG)",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX , startY + Offset);
            graphics.DrawString(grossweight.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 160, startY + Offset);

            //GROSS WEIGHT
            Offset = Offset + 30;
            graphics.DrawString($"TARE WEIGHT  (KG)",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(tareweight.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 160, startY + Offset);

            //NET WEIGHT
            Offset = Offset + 30;
            graphics.DrawString($"NET WEIGHT   (KG)",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(netweight.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 160, startY + Offset);

            //IN DATE
            Offset = Offset + 30;
            graphics.DrawString($"Weigh In Date",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(_recordToPrint.FirstWeighingDate.ToString(),
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            //OTU DATE
            Offset = Offset + 30;
            graphics.DrawString($"Weigh Out Date",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(_recordToPrint.SecondWeighingDate.ToString(),
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);


           
            //SEPARATOR
            Offset = Offset + 30;
            graphics.DrawString(separator,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);

            //NET WEIGHT
            Offset = Offset + 8;
            graphics.DrawString($"WEIGHER",
                  new Font(bodyFont, 8),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(_recordToPrint.WeigherName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 120, startY + Offset);
        }
    }
}
