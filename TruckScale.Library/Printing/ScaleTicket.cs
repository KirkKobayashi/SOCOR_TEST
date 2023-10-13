using TruckScale.Library.Data.DTOs;

namespace TruckScale.Library.Printing
{
    public class ScaleTicket
    {
        private readonly string filePath;
        private readonly string fileName;

        public ScaleTicket(string fileName, string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }

        public string PrintTicket(FlatWeighingTransaction weighingTransaction, List<string> ticketHeaders)
        {
            try
            {
                var fullPath = Path.Combine(filePath, fileName);

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }

                var netWeight = Convert.ToInt32(Math.Abs(weighingTransaction.FirstWeight - weighingTransaction.SecondWeight));

                using (StreamWriter sw = File.CreateText(fullPath))
                {
                    sw.WriteLine(string.Format("{0, 0}", ticketHeaders[0]));
                    sw.WriteLine(string.Format("{0, 0}", ticketHeaders[1]));
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");

                    sw.WriteLine(string.Format("{0, 0}", $"TRUCK PLATE NUMBER: {weighingTransaction.TruckPlateNumber}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"SUPPLIER: { weighingTransaction.SupplierName}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"CUSTOMER: {weighingTransaction.CustomerName}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"QUANTITY: {weighingTransaction.Quantity}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"PRODUCT: {weighingTransaction.ProductName}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"WEIGH-IN: {weighingTransaction.FirstWeighingDate.ToString("HH:mm MM-dd-yyyy")}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"WEIGH-OUT: {weighingTransaction.SecondWeighingDate.ToString("HH:mm MM-dd-yyyy")}"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"FIRST WEIGHT:{weighingTransaction.FirstWeight} KG"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"SECOND WEIGHT: {weighingTransaction.SecondWeight} KG"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", $"NET WEIGHT: {netWeight} KG"));
                    sw.WriteLine("");
                    sw.WriteLine(string.Format("{0, 0}", "CUSTOMER REP:"));
                    sw.WriteLine(string.Format("{0, 0}",$"SCALER: {weighingTransaction.WeigherName}"));
                   
                    sw.WriteLine("");
                    sw.WriteLine("");
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
}
