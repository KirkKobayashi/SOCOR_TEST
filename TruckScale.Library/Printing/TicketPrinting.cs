using System.Drawing.Printing;
using TruckScale.Library.Data.DTOs;

namespace TruckScale.Library.Printing
{
    public static class TicketPrinting
    {
        
        private static void SetSpacing(StreamWriter sw, int spacing)
        {
            for (int i = 1; i < spacing; i++)
            {
                sw.WriteLine("");
            }
        }

        private static void FirstWeighingData(StreamWriter sw, FlatWeighingTransaction weighingTransaction)
        {
            SetSpacing(sw, 12);
            sw.WriteLine(string.Format("{0, 40}", weighingTransaction.TruckPlateNumber));

            sw.WriteLine("");

            sw.WriteLine(string.Format("{0, 40}", weighingTransaction.FirstWeighingDate.ToString("HH:mm MM-dd-yyyy")));

            SetSpacing(sw, 2);

            sw.WriteLine(string.Format("{0, 40}", weighingTransaction.FirstWeight.ToString("N0") + " KG"));

            SetSpacing(sw, 2);

            sw.WriteLine(string.Format("{0, 40}", weighingTransaction.ProductName));

            SetSpacing(sw, 4);
        }

        private static void SecondWeighingData(StreamWriter sw, FlatWeighingTransaction weighingTransaction)
        {
            int gross = 0;
            int tare = 0;

            if (weighingTransaction.FirstWeight > weighingTransaction.SecondWeight)
            {
                gross = weighingTransaction.FirstWeight;
                tare = weighingTransaction.SecondWeight;
            }
            else
            {
                tare = weighingTransaction.FirstWeight;
                gross = weighingTransaction.SecondWeight;
            }


            SetSpacing(sw, 3);

            sw.WriteLine(string.Format("{0, 40}", weighingTransaction.SecondWeighingDate.ToString("HH:mm MM-dd-yyyy")));

            SetSpacing(sw, 3);

            sw.WriteLine(string.Format("{0, 40}", gross.ToString("N0") + " KG"));

            SetSpacing(sw, 2);

            sw.WriteLine(string.Format("{0, 40}", tare.ToString("N0") + " KG"));

            SetSpacing(sw, 2);

            sw.WriteLine(string.Format("{0, 40}", Convert.ToInt32(Math.Abs(weighingTransaction.FirstWeight - weighingTransaction.SecondWeight)).ToString("N0") + " KG"));

            SetSpacing(sw, 5);

            sw.WriteLine(string.Format("{0, 40}", weighingTransaction.CustomerName));

            SetSpacing(sw, 12);

            sw.WriteLine(string.Format("{0, 20}", weighingTransaction.WeigherName));
        }

        public static PrintDocument Print(FlatWeighingTransaction weighingTransaction, string ticketPath, int ticketType = 0)
        {
            if (weighingTransaction == null)
            {
                return new PrintDocument();
            }

            try
            {
                if (File.Exists(ticketPath))
                {
                    File.Delete(ticketPath);
                }

                using (StreamWriter sw = File.CreateText(ticketPath))
                {

                    
                    //Print first weighing
                    if(ticketType == 1)
                    {
                        FirstWeighingData(sw, weighingTransaction);
                    }
                    //Print second weighing
                    else if (ticketType == 2)
                    {
                        SetSpacing(sw, 22);
                        SecondWeighingData(sw, weighingTransaction);
                    }
                    //Print Complete ticket
                    else
                    {
                        FirstWeighingData(sw, weighingTransaction);
                        SecondWeighingData(sw, weighingTransaction);
                    }
                }

                PrintDocument pd = new PrintDocument();
                Margins margins = new Margins(5, 5, 20, 20);
                pd.DefaultPageSettings.Margins = margins;
                pd.DocumentName = ticketPath;

                return pd;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

