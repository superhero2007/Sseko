namespace Sseko.Data.Models
{
    public partial class SalesBillingAgreementOrder
    {
        public int AgreementId { get; set; }
        public int OrderId { get; set; }

        public virtual SalesBillingAgreement Agreement { get; set; }
        public virtual SalesFlatOrder Order { get; set; }
    }
}
