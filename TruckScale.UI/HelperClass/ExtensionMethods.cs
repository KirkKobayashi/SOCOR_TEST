using System.Text.RegularExpressions;
using TruckScale.Library.Data.DTOs;
using TruckScale.Library.Data.Models;

namespace TruckScale.UI.HelperClass
{
    public static class ExtensionMethods
    {
        public static string ParseWeight(this string strWeight  )
        {
            var str =  Regex.Replace(strWeight, @"[^\d]", "");
            return str;
        }

        public static FlatWeighingTransaction FlattenData(WeighingTransaction transaction )
        {
            var flatTrans = new FlatWeighingTransaction
            {
                TruckPlateNumber = transaction.Truck.PlateNumber,
                CustomerName = transaction.Customer.Name,
                SupplierName = transaction.Supplier.Name,
                FirstWeighingDate = transaction.FirstWeightDate,
                SecondWeighingDate = transaction.SecondWeightDate,
                FirstWeight = transaction.FirstWeight,
                SecondWeight = transaction.SecondWeight,
                ProductName = transaction.Product.Name,
                Quantity = transaction.Quantity,
                TicketNumber = transaction.TicketNumber,
                WeigherName = $"{transaction.Weigher.FirstName} {transaction.Weigher.LastName}"
            };

            return flatTrans;
        }
    }
}
