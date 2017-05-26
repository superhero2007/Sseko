using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Catalogrule
    {
        public Catalogrule()
        {
            CatalogruleCustomerGroup = new HashSet<CatalogruleCustomerGroup>();
            CatalogruleGroupWebsite = new HashSet<CatalogruleGroupWebsite>();
            CatalogruleProduct = new HashSet<CatalogruleProduct>();
            CatalogruleWebsite = new HashSet<CatalogruleWebsite>();
        }

        public int RuleId { get; set; }
        public string ActionsSerialized { get; set; }
        public string ConditionsSerialized { get; set; }
        public string Description { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public short IsActive { get; set; }
        public string Name { get; set; }
        public string SimpleAction { get; set; }
        public int SortOrder { get; set; }
        public short StopRulesProcessing { get; set; }
        public decimal SubDiscountAmount { get; set; }
        public ushort SubIsEnable { get; set; }
        public string SubSimpleAction { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual ICollection<CatalogruleCustomerGroup> CatalogruleCustomerGroup { get; set; }
        public virtual ICollection<CatalogruleGroupWebsite> CatalogruleGroupWebsite { get; set; }
        public virtual ICollection<CatalogruleProduct> CatalogruleProduct { get; set; }
        public virtual ICollection<CatalogruleWebsite> CatalogruleWebsite { get; set; }
    }
}
