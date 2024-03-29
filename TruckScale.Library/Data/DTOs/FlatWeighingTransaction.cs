﻿using System.ComponentModel.DataAnnotations;

namespace TruckScale.Library.Data.DTOs
{
    public class FlatWeighingTransaction
    {
        public int Id { get; set; }
        
        public int TicketNumber { get; set; }
        public string DriverName { get; set; }
        public string TruckPlateNumber { get; set; }
        public string CustomerName { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string Remarks { get; set; }
        public int FirstWeight { get; set; }
        public int SecondWeight { get; set; }
        public int NetWeight { get; set; }
        public DateTime FirstWeighingDate { get; set; }
        public DateTime SecondWeighingDate { get; set; }
        public string WeigherName { get; set; } 

        public void GetNet()
        {
            if (FirstWeight > SecondWeight)
            {
                NetWeight = FirstWeight - SecondWeight;
            }
            else
            {
                NetWeight = SecondWeight - FirstWeight;
            }
        }
    }
}
