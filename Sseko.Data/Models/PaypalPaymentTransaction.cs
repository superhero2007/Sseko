using System;

namespace Sseko.Data.Models
{
    public partial class PaypalPaymentTransaction
    {
        public int TransactionId { get; set; }
        public byte[] AdditionalInformation { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string TxnId { get; set; }
    }
}
