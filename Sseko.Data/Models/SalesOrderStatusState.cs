namespace Sseko.Data.Models
{
    public partial class SalesOrderStatusState
    {
        public string Status { get; set; }
        public string State { get; set; }
        public ushort IsDefault { get; set; }

        public virtual SalesOrderStatus StatusNavigation { get; set; }
    }
}
