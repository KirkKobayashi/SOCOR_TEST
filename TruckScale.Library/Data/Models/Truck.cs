namespace TruckScale.Library.Data.Models
{
    public class Truck 
    {
        public int Id { get; set; }
        public string? PlateNumber { get; set; }
        public int TareWeight { get; set; }
        public ICollection<WeighingTransaction>? Transactions { get; set; }
    }
}
