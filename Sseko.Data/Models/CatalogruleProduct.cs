using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogruleProduct
    {
        public int RuleProductId { get; set; }
        public decimal ActionAmount { get; set; }
        public string ActionOperator { get; set; }
        public short ActionStop { get; set; }
        public ushort CustomerGroupId { get; set; }
        public int FromTime { get; set; }
        public int ProductId { get; set; }
        public int RuleId { get; set; }
        public int SortOrder { get; set; }
        public decimal SubDiscountAmount { get; set; }
        public string SubSimpleAction { get; set; }
        public int ToTime { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual Catalogrule Rule { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
