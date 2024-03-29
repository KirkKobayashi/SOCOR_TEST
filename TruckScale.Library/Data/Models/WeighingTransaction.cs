﻿namespace TruckScale.Library.Data.Models
{
    public class WeighingTransaction
    {
        public int Id { get; set; }
        public DateTime FirstWeightDate { get; set; }
        public DateTime  SecondWeightDate { get; set; }
        public int TicketNumber { get; set; }
        public int FirstWeight { get; set; }
        public int SecondWeight { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public int TruckId { get; set; }
        public int ProductId { get; set; }
        public int WeigherId { get; set; }
        public string? Quantity { get; set; }
        public string? Remarks { get; set; }
        public string? Driver { get; set; }
        public Customer? Customer { get; set; }
        public Supplier? Supplier { get; set; }
        public Truck? Truck { get; set; }
        public Product? Product { get; set; }
        public Weigher? Weigher { get; set; }


    }
}
