using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusTransaction
    {
        public AffiliateplusTransaction()
        {
            AffiliatepluslevelTransaction = new HashSet<AffiliatepluslevelTransaction>();
            AffiliateplusprogramTransaction = new HashSet<AffiliateplusprogramTransaction>();
        }

        public int TransactionId { get; set; }
        public string AccountEmail { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public int? BannerId { get; set; }
        public decimal Commission { get; set; }
        public decimal CommissionPlus { get; set; }
        public string CouponCode { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreditmemoIds { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerId { get; set; }
        public decimal Discount { get; set; }
        public DateTime? HoldingFrom { get; set; }
        public int OrderId { get; set; }
        public string OrderItemIds { get; set; }
        public string OrderItemNames { get; set; }
        public string OrderNumber { get; set; }
        public decimal PercentPlus { get; set; }
        public int? ProgramId { get; set; }
        public string ProgramName { get; set; }
        public bool Status { get; set; }
        public ushort StoreId { get; set; }
        public decimal TotalAmount { get; set; }
        public sbyte Type { get; set; }

        public virtual ICollection<AffiliatepluslevelTransaction> AffiliatepluslevelTransaction { get; set; }
        public virtual ICollection<AffiliateplusprogramTransaction> AffiliateplusprogramTransaction { get; set; }
        public virtual AffiliateplusAccount Account { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
