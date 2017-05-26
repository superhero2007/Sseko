using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusprogramTransaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal Commission { get; set; }
        public int OrderId { get; set; }
        public string OrderItemIds { get; set; }
        public string OrderItemNames { get; set; }
        public string OrderNumber { get; set; }
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public decimal TotalAmount { get; set; }
        public int TransactionId { get; set; }
        public sbyte Type { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
        public virtual AffiliateplusTransaction Transaction { get; set; }
    }
}
