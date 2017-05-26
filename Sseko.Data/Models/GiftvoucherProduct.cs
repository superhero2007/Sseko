using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftvoucherProduct
    {
        public int GiftcardProductId { get; set; }
        public string ActionsSerialized { get; set; }
        public string ConditionsSerialized { get; set; }
        public string GiftcardDescription { get; set; }
        public int ProductId { get; set; }
    }
}
