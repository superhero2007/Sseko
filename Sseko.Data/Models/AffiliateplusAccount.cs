using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusAccount
    {
        public AffiliateplusAccount()
        {
            AffiliateplusAccountValue = new HashSet<AffiliateplusAccountValue>();
            AffiliatepluslevelTierTier = new HashSet<AffiliatepluslevelTier>();
            AffiliatepluslevelTierToptier = new HashSet<AffiliatepluslevelTier>();
            AffiliatepluslevelTransaction = new HashSet<AffiliatepluslevelTransaction>();
            AffiliateplusPayment = new HashSet<AffiliateplusPayment>();
            AffiliatepluspaymentBankaccount = new HashSet<AffiliatepluspaymentBankaccount>();
            AffiliateplusPaymentVerify = new HashSet<AffiliateplusPaymentVerify>();
            AffiliateplusprogramAccount = new HashSet<AffiliateplusprogramAccount>();
            AffiliateplusprogramJoined = new HashSet<AffiliateplusprogramJoined>();
            AffiliateplusprogramTransaction = new HashSet<AffiliateplusprogramTransaction>();
            AffiliateplusReferer = new HashSet<AffiliateplusReferer>();
            AffiliateplusTracking = new HashSet<AffiliateplusTracking>();
            AffiliateplusTransaction = new HashSet<AffiliateplusTransaction>();
        }

        public int AccountId { get; set; }
        public int AddressId { get; set; }
        public bool Approved { get; set; }
        public decimal Balance { get; set; }
        public string CouponCode { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string IdentifyCode { get; set; }
        public bool InParty { get; set; }
        public DateTime? LastReceivedDate { get; set; }
        public string MoneybookerEmail { get; set; }
        public string Name { get; set; }
        public bool Notification { get; set; }
        public string PaypalEmail { get; set; }
        public string RecurringMethod { get; set; }
        public bool RecurringPayment { get; set; }
        public string ReferredBy { get; set; }
        public string ReferringWebsite { get; set; }
        public bool Status { get; set; }
        public int TotalClicks { get; set; }
        public decimal TotalCommissionReceived { get; set; }
        public decimal TotalPaid { get; set; }
        public int UniqueClicks { get; set; }

        public virtual ICollection<AffiliateplusAccountValue> AffiliateplusAccountValue { get; set; }
        public virtual ICollection<AffiliatepluslevelTier> AffiliatepluslevelTierTier { get; set; }
        public virtual ICollection<AffiliatepluslevelTier> AffiliatepluslevelTierToptier { get; set; }
        public virtual ICollection<AffiliatepluslevelTransaction> AffiliatepluslevelTransaction { get; set; }
        public virtual ICollection<AffiliateplusPayment> AffiliateplusPayment { get; set; }
        public virtual ICollection<AffiliatepluspaymentBankaccount> AffiliatepluspaymentBankaccount { get; set; }
        public virtual ICollection<AffiliateplusPaymentVerify> AffiliateplusPaymentVerify { get; set; }
        public virtual ICollection<AffiliateplusprogramAccount> AffiliateplusprogramAccount { get; set; }
        public virtual ICollection<AffiliateplusprogramJoined> AffiliateplusprogramJoined { get; set; }
        public virtual ICollection<AffiliateplusprogramTransaction> AffiliateplusprogramTransaction { get; set; }
        public virtual ICollection<AffiliateplusReferer> AffiliateplusReferer { get; set; }
        public virtual ICollection<AffiliateplusTracking> AffiliateplusTracking { get; set; }
        public virtual ICollection<AffiliateplusTransaction> AffiliateplusTransaction { get; set; }
        public virtual CustomerEntity Customer { get; set; }
    }
}
