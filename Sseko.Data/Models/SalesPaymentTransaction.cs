using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesPaymentTransaction
    {
        public int TransactionId { get; set; }
        public byte[] AdditionalInformation { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ushort IsClosed { get; set; }
        public int OrderId { get; set; }
        public int? ParentId { get; set; }
        public string ParentTxnId { get; set; }
        public int PaymentId { get; set; }
        public string TxnId { get; set; }
        public string TxnType { get; set; }

        public virtual SalesFlatOrder Order { get; set; }
        public virtual SalesPaymentTransaction Parent { get; set; }
        public virtual ICollection<SalesPaymentTransaction> InverseParent { get; set; }
        public virtual SalesFlatOrderPayment Payment { get; set; }
    }
}
