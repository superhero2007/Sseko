using System;

namespace Sseko.Core.Models
{
    public class TransactionModel
    {
        public DateTime Date { get; set; }
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public string Hostess { get; set; }
        public string Type { get; set; }
        public decimal CommissionalbeSale { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
