namespace TruckScale.Library.Data.Models
{
    public class Supplier : ModelBase
    {
        public ICollection<WeighingTransaction>? Transactions { get; set; }
    }
}
