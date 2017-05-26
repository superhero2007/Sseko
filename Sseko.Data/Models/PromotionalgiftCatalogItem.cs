using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class PromotionalgiftCatalogItem
    {
        public int ItemId { get; set; }
        public string GiftQty { get; set; }
        public string ProductIds { get; set; }
        public int RuleId { get; set; }

        public virtual PromotionalgiftCatalogRule Rule { get; set; }
    }
}
