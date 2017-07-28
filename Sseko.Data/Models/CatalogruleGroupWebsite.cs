namespace Sseko.Data.Models
{
    public partial class CatalogruleGroupWebsite
    {
        public int RuleId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual Catalogrule Rule { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
