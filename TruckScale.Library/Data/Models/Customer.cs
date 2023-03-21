namespace TruckScale.Library.Data.Models
{
    public class Customer : ModelBase
    {
        public ICollection<WeighingTransaction>? Transactions { get; set; }
    }
}
