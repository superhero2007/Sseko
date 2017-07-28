namespace Sseko.Data.Models
{
    public partial class AffiliateplusPaymentVerify
    {
        public int VerifyId { get; set; }
        public int AccountId { get; set; }
        public string Field { get; set; }
        public string Info { get; set; }
        public string PaymentMethod { get; set; }
        public bool Verified { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
    }
}
