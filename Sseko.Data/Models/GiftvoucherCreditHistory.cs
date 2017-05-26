using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftvoucherCreditHistory
    {
        public int HistoryId { get; set; }
        public string Action { get; set; }
        public decimal? Amount { get; set; }
        public decimal? BalanceChange { get; set; }
        public decimal? BaseAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Currency { get; set; }
        public decimal? CurrencyBalance { get; set; }
        public int CustomerId { get; set; }
        public string GiftcardCode { get; set; }
        public int? OrderId { get; set; }
        public string OrderNumber { get; set; }

        public virtual CustomerEntity Customer { get; set; }
    }
}
