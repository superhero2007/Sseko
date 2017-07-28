namespace Sseko.Data.Models
{
    public partial class SalesruleProductAttribute
    {
        public int RuleId { get; set; }
        public ushort WebsiteId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort AttributeId { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual Salesrule Rule { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
