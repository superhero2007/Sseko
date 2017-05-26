using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatOrderPayment
    {
        public SalesFlatOrderPayment()
        {
            SalesPaymentTransaction = new HashSet<SalesPaymentTransaction>();
        }

        public int EntityId { get; set; }
        public string AccountStatus { get; set; }
        public string AdditionalData { get; set; }
        public string AdditionalInformation { get; set; }
        public string AddressStatus { get; set; }
        public decimal? AmountAuthorized { get; set; }
        public decimal? AmountCanceled { get; set; }
        public decimal? AmountOrdered { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? AmountRefunded { get; set; }
        public string AnetTransMethod { get; set; }
        public decimal? BaseAmountAuthorized { get; set; }
        public decimal? BaseAmountCanceled { get; set; }
        public decimal? BaseAmountOrdered { get; set; }
        public decimal? BaseAmountPaid { get; set; }
        public decimal? BaseAmountPaidOnline { get; set; }
        public decimal? BaseAmountRefunded { get; set; }
        public decimal? BaseAmountRefundedOnline { get; set; }
        public decimal? BaseShippingAmount { get; set; }
        public decimal? BaseShippingCaptured { get; set; }
        public decimal? BaseShippingRefunded { get; set; }
        public string CcApproval { get; set; }
        public string CcAvsStatus { get; set; }
        public string CcCidStatus { get; set; }
        public string CcDebugRequestBody { get; set; }
        public string CcDebugResponseBody { get; set; }
        public string CcDebugResponseSerialized { get; set; }
        public string CcExpMonth { get; set; }
        public string CcExpYear { get; set; }
        public string CcLast4 { get; set; }
        public string CcNumberEnc { get; set; }
        public string CcOwner { get; set; }
        public string CcSecureVerify { get; set; }
        public string CcSsIssue { get; set; }
        public string CcSsStartMonth { get; set; }
        public string CcSsStartYear { get; set; }
        public string CcStatus { get; set; }
        public string CcStatusDescription { get; set; }
        public string CcTransId { get; set; }
        public string CcType { get; set; }
        public string EcheckAccountName { get; set; }
        public string EcheckAccountType { get; set; }
        public string EcheckBankName { get; set; }
        public string EcheckRoutingNumber { get; set; }
        public string EcheckType { get; set; }
        public string LastTransId { get; set; }
        public string Method { get; set; }
        public int ParentId { get; set; }
        public string PayboxRequestNumber { get; set; }
        public string PoNumber { get; set; }
        public string ProtectionEligibility { get; set; }
        public int? QuotePaymentId { get; set; }
        public decimal? ShippingAmount { get; set; }
        public decimal? ShippingCaptured { get; set; }
        public decimal? ShippingRefunded { get; set; }

        public virtual ICollection<SalesPaymentTransaction> SalesPaymentTransaction { get; set; }
        public virtual SalesFlatOrder Parent { get; set; }
    }
}
