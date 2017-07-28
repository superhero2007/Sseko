using System;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusPaymentHistory
    {
        public int HistoryId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Description { get; set; }
        public int PaymentId { get; set; }
        public bool Status { get; set; }

        public virtual AffiliateplusPayment Payment { get; set; }
    }
}
