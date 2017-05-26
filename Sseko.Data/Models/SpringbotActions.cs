using Sseko.Data.Enums;
using System;

namespace Sseko.Data.Models
{
    public partial class SpringbotActions
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? LockedAt { get; set; }
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int? CategoryId { get; set; }
        public int? PurchaseId { get; set; }
        public int? Quantity { get; set; }
        public int? QuoteId { get; set; }
        public SpringbotActionsType Type { get; set; }
        public string LockedBy { get; set; }
        public string PageUrl { get; set; }
        public string Sku { get; set; }
        public string SkuFulfillment { get; set; }
        public string VisitorIp { get; set; }
    }
}