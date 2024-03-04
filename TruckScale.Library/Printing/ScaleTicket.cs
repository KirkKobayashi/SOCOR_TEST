using TruckScale.Library.Data.DTOs;

namespace TruckScale.Library.Printing
{
    public class ScaleTicket
    {
        private readonly string filePath;
        private readonly string address1;
        private readonly string address2;
        private readonly string fileName;

        public ScaleTicket(string fileName, string filePath, string address1, string address2)
        {
            this.fileName = fileName;
            this.filePath = filePath;
            this.address1 = address1;
            this.address2 = address2;
        }

        public string PrintTicket(TransacionDTO weighingTransaction)
        {
            try
            {
                var fullPath = Path.Combine(filePath, fileName);

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }

                using (StreamWriter sw = File.CreateText(fullPath))
                {

                    sw.WriteLine(string.Format("{0, 0}", address1));
                    sw.WriteLine(string.Format("{0, 0}", address2));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", "TRUCK PLATE NUMBER:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.TruckPlateNumber));
                    sw.WriteLine(string.Format("{0, 0}", "SUPPLIER:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.SupplierName));
                    sw.WriteLine(string.Format("{0, 0}", "CUSTOMER:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.CustomerName));
                    sw.WriteLine(string.Format("{0, 0}", "QUANTITY:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.Quantity));
                    sw.WriteLine(string.Format("{0, 0}", "PRODUCT:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.ProductName));
                    sw.WriteLine(string.Format("{0, 0}", "WEIGH-IN:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.FirstWeighingDate.ToString("HH:mm MM-dd-yyyy")));
                    sw.WriteLine(string.Format("{0, 0}", "WEIGH-OUT:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.SecondWeighingDate.ToString("HH:mm MM-dd-yyyy")));
                    sw.WriteLine(string.Format("{0, 0}", "FIRST WEIGHT:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.FirstWeight + " KG"));
                    sw.WriteLine(string.Format("{0, 0}", "SECOND WEIGHT:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.SecondWeight + " KG"));
                    sw.WriteLine(string.Format("{0, 0}", "NET WEIGHT:"));
                    sw.WriteLine(string.Format("{0, 30}", Convert.ToInt32(Math.Abs(weighingTransaction.FirstWeight - weighingTransaction.SecondWeight)) + " KG"));
                    sw.WriteLine(string.Format("{0, 0}", "SCALER:"));
                    sw.WriteLine(string.Format("{0, 30}", weighingTransaction.WeigherName));
                    sw.WriteLine(string.Format("{0, 0}", "CUSTOMER REP:"));
                    sw.WriteLine(string.Format("{0, 0}", "TICKET NUMBER:" + String.Format("{0,10}", weighingTransaction.TicketNumber.ToString("0000000000"))));
                }

                return fullPath;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public class TextFileProps
    {
        public string FileName { get; set; }
        public int FontSize { get; set; }
        public string FontName { get; set; }

    }
}
