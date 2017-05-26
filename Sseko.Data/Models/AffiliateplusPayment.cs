using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusPayment
    {
        public AffiliateplusPayment()
        {
            AffiliateplusCredit = new HashSet<AffiliateplusCredit>();
            AffiliatepluspaymentBank = new HashSet<AffiliatepluspaymentBank>();
            AffiliateplusPaymentHistory = new HashSet<AffiliateplusPaymentHistory>();
            AffiliatepluspaymentMoneybooker = new HashSet<AffiliatepluspaymentMoneybooker>();
            AffiliatepluspaymentOffline = new HashSet<AffiliatepluspaymentOffline>();
            AffiliateplusPaymentPaypal = new HashSet<AffiliateplusPaymentPaypal>();
        }

        public int PaymentId { get; set; }
        public string AccountEmail { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
        public decimal? AmountInclTax { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public bool IsPayerFee { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsReducedBalance { get; set; }
        public bool IsRefundBalance { get; set; }
        public bool IsRequest { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime? RequestTime { get; set; }
        public bool Status { get; set; }
        public string StoreIds { get; set; }
        public decimal? TaxAmount { get; set; }

        public virtual ICollection<AffiliateplusCredit> AffiliateplusCredit { get; set; }
        public virtual ICollection<AffiliatepluspaymentBank> AffiliatepluspaymentBank { get; set; }
        public virtual ICollection<AffiliateplusPaymentHistory> AffiliateplusPaymentHistory { get; set; }
        public virtual ICollection<AffiliatepluspaymentMoneybooker> AffiliatepluspaymentMoneybooker { get; set; }
        public virtual ICollection<AffiliatepluspaymentOffline> AffiliatepluspaymentOffline { get; set; }
        public virtual ICollection<AffiliateplusPaymentPaypal> AffiliateplusPaymentPaypal { get; set; }
        public virtual AffiliateplusAccount Account { get; set; }
    }
}
