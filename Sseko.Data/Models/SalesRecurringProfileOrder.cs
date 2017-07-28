namespace Sseko.Data.Models
{
    public partial class SalesRecurringProfileOrder
    {
        public int LinkId { get; set; }
        public int OrderId { get; set; }
        public int ProfileId { get; set; }

        public virtual SalesFlatOrder Order { get; set; }
        public virtual SalesRecurringProfile Profile { get; set; }
    }
}
