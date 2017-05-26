using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesRecurringProfile
    {
        public SalesRecurringProfile()
        {
            SalesRecurringProfileOrder = new HashSet<SalesRecurringProfileOrder>();
        }

        public int ProfileId { get; set; }
        public string AdditionalInfo { get; set; }
        public ushort BillFailedLater { get; set; }
        public string BillingAddressInfo { get; set; }
        public decimal BillingAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CurrencyCode { get; set; }
        public int? CustomerId { get; set; }
        public decimal? InitAmount { get; set; }
        public ushort InitMayFail { get; set; }
        public string InternalReferenceId { get; set; }
        public string MethodCode { get; set; }
        public string OrderInfo { get; set; }
        public string OrderItemInfo { get; set; }
        public ushort? PeriodFrequency { get; set; }
        public ushort? PeriodMaxCycles { get; set; }
        public string PeriodUnit { get; set; }
        public string ProfileVendorInfo { get; set; }
        public string ReferenceId { get; set; }
        public string ScheduleDescription { get; set; }
        public string ShippingAddressInfo { get; set; }
        public decimal? ShippingAmount { get; set; }
        public DateTime StartDatetime { get; set; }
        public string State { get; set; }
        public ushort? StoreId { get; set; }
        public string SubscriberName { get; set; }
        public ushort? SuspensionThreshold { get; set; }
        public decimal? TaxAmount { get; set; }
        public string TrialBillingAmount { get; set; }
        public ushort? TrialPeriodFrequency { get; set; }
        public ushort? TrialPeriodMaxCycles { get; set; }
        public string TrialPeriodUnit { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<SalesRecurringProfileOrder> SalesRecurringProfileOrder { get; set; }
        public virtual CustomerEntity Customer { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
