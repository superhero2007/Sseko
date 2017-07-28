namespace Sseko.Data.Models
{
    public partial class AffiliateplusCredit
    {
        public int Id { get; set; }
        public decimal BasePaidAmount { get; set; }
        public decimal BaseRefundAmount { get; set; }
        public int OrderId { get; set; }
        public string OrderIncrementId { get; set; }
        public decimal PaidAmount { get; set; }
        public int PaymentId { get; set; }
        public decimal RefundAmount { get; set; }

        public virtual AffiliateplusPayment Payment { get; set; }
    }
}
