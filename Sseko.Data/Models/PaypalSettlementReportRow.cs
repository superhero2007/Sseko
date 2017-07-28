using System;

namespace Sseko.Data.Models
{
    public partial class PaypalSettlementReportRow
    {
        public int RowId { get; set; }
        public string ConsumerId { get; set; }
        public string CustomField { get; set; }
        public decimal FeeAmount { get; set; }
        public string FeeCurrency { get; set; }
        public string FeeDebitOrCredit { get; set; }
        public decimal GrossTransactionAmount { get; set; }
        public string GrossTransactionCurrency { get; set; }
        public string InvoiceId { get; set; }
        public string PaymentTrackingId { get; set; }
        public string PaypalReferenceId { get; set; }
        public string PaypalReferenceIdType { get; set; }
        public int ReportId { get; set; }
        public string StoreId { get; set; }
        public DateTime? TransactionCompletionDate { get; set; }
        public string TransactionDebitOrCredit { get; set; }
        public string TransactionEventCode { get; set; }
        public string TransactionId { get; set; }
        public DateTime? TransactionInitiationDate { get; set; }

        public virtual PaypalSettlementReport Report { get; set; }
    }
}
