namespace Sseko.Data.Models
{
    public partial class SalesruleCustomer
    {
        public int RuleCustomerId { get; set; }
        public int CustomerId { get; set; }
        public int RuleId { get; set; }
        public ushort TimesUsed { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual Salesrule Rule { get; set; }
    }
}
