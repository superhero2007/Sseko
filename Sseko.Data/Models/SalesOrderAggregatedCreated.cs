using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesOrderAggregatedCreated
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public int OrdersCount { get; set; }
        public DateTime? Period { get; set; }
        public ushort? StoreId { get; set; }
        public decimal TotalCanceledAmount { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalDiscountAmountActual { get; set; }
        public decimal TotalIncomeAmount { get; set; }
        public decimal TotalInvoicedAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalProfitAmount { get; set; }
        public decimal TotalQtyInvoiced { get; set; }
        public decimal TotalQtyOrdered { get; set; }
        public decimal TotalRefundedAmount { get; set; }
        public decimal TotalRevenueAmount { get; set; }
        public decimal TotalShippingAmount { get; set; }
        public decimal TotalShippingAmountActual { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal TotalTaxAmountActual { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
