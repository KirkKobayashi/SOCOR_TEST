using System.Drawing.Printing;
using TruckScale.Library.Data.DTOs;

namespace TruckScale.UI.HelperClass
{
    public class TicketPrinter : ITicketPrinter
    {
        private PrintDocument _document;
        private PrintDialog _printDialog;
        private FlatWeighingTransaction _recordToPrint;
        private PrintSettings _settings;

        public TicketPrinter()
        {
            _document = new PrintDocument();
            _printDialog = new PrintDialog();
            _printDialog.Document = _document;

            _document.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

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

            var headerFont = _settings.HeaderFont;
            var headerSize = _settings.HeaderFontHeight;
            var bodyFont = _settings.BodyFont;
            var bodySize = _settings.BodyFontHeigt;
            string textLine = "____________________";

            e.PageSettings.PaperSize = new PaperSize("Custom", 800, 1100);
            Graphics graphics = e.Graphics;

            int startX = _settings.startX;
            int startY = _settings.startY;
            int Offset = _settings.yOffset;
            int bodyOffset = 18;

            SizeF title1Size = (graphics.MeasureString("WEIGHING SLIP", new Font(_settings.HeaderFont, _settings.HeaderFontHeight)));

            SizeF title2Size = (graphics.MeasureString(_settings.HeaderText2, new Font(_settings.HeaderFont, _settings.HeaderFontHeight)));

            float firstHeaderX = (400 - title1Size.Width) / 2;
            float secondHeaderX = (400 - title2Size.Width) / 2;


            ////HEADER 1 - COMPANY NAME
            //graphics.DrawString(_settings.HeaderText1, new Font(headerFont, headerSize),
            //                    new SolidBrush(Color.Black), firstHeaderX, startY + Offset);
            ////HEADER 2 - ADDRESS
            //Offset = Offset + 20;
            //graphics.DrawString(_settings.HeaderText2, new Font(headerFont, headerSize),
            //                  new SolidBrush(Color.Black), secondHeaderX, startY + Offset);

            //TICKET NUMBER
            _recordToPrint.TicketNumber = 1;
            Offset = Offset + 20;
            graphics.DrawString("Weighing Slip No.",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(_recordToPrint.TicketNumber.ToString(),
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            graphics.DrawString(_settings.HeaderText2,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), 280, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(_settings.HeaderText2,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), 280, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("WEIGHING SLIP",
                  new Font(bodyFont, headerSize, FontStyle.Bold),
                  new SolidBrush(Color.Black), firstHeaderX, startY + Offset);

            Offset = Offset + 30;
            graphics.DrawString("SUPPLIER",
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + _recordToPrint.SupplierName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("ITEM",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + _recordToPrint.ProductName,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("PLATE NO.",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + _recordToPrint.TruckPlateNumber,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("BLOCK NO.",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + textLine,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("NO. OF BALES",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + _recordToPrint?.Quantity,
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            #region 2ND_PART
            Offset = Offset + 30;
            graphics.DrawString("% MOISTURE",
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("INITIAL",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + textLine,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("AVERAGE",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + textLine,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("TARGET",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + "____________________",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("EXCESS",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + textLine,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);
            #endregion

            #region 3rd Part
            Offset = Offset + 30;
            graphics.DrawString("WEIGHT, kgs",
                  new Font(bodyFont, bodySize, FontStyle.Bold),
                  new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("GROSS",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + grossweight,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("TARE",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + tareweight,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("NET",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + netweight,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("EXCESS",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + textLine,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("NEW NET",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(": " + textLine,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 150, startY + Offset);

            Offset = Offset + 30;
            graphics.DrawString(textLine,
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString(textLine,
               new Font(bodyFont, bodySize),
               new SolidBrush(Color.Black), startX + 230, startY + Offset);

            Offset = Offset + bodyOffset;
            graphics.DrawString("Truck Personnel",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX, startY + Offset);


            graphics.DrawString("Raw Materials Inspector",
                  new Font(bodyFont, bodySize),
                  new SolidBrush(Color.Black), startX + 230, startY + Offset);
            #endregion
        }
    }
}
