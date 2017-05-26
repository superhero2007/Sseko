using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftvoucherTemplate
    {
        public int TemplateId { get; set; }
        public int? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string ConditionsSerialized { get; set; }
        public string Currency { get; set; }
        public DateTime? DayToSend { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public int GiftcardTemplateId { get; set; }
        public string GiftcardTemplateImage { get; set; }
        public ushort IsGenerated { get; set; }
        public string Pattern { get; set; }
        public ushort StoreId { get; set; }
        public string TemplateName { get; set; }
        public string Type { get; set; }
    }
}
