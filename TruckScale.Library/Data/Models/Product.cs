namespace TruckScale.Library.Data.Models
{
    public class Product : ModelBase
    {
        public ICollection<WeighingTransaction>? Transactions { get; set; }
    }
}
