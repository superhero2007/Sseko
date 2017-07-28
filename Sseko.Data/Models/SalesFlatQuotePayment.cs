using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatQuotePayment
    {
        public int PaymentId { get; set; }
        public string AdditionalData { get; set; }
        public string AdditionalInformation { get; set; }
        public string CcCidEnc { get; set; }
        public ushort? CcExpMonth { get; set; }
        public ushort? CcExpYear { get; set; }
        public string CcLast4 { get; set; }
        public string CcNumberEnc { get; set; }
        public string CcOwner { get; set; }
        public string CcSsIssue { get; set; }
        public string CcSsOwner { get; set; }
        public ushort? CcSsStartMonth { get; set; }
        public ushort? CcSsStartYear { get; set; }
        public string CcType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Method { get; set; }
        public string PaypalCorrelationId { get; set; }
        public string PaypalPayerId { get; set; }
        public string PaypalPayerStatus { get; set; }
        public string PoNumber { get; set; }
        public int QuoteId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual SalesFlatQuote Quote { get; set; }
    }
}
