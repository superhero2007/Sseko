namespace Sseko.Data.Models
{
    public partial class AdminRule
    {
        public int RuleId { get; set; }
        public int AssertId { get; set; }
        public string Permission { get; set; }
        public string Privileges { get; set; }
        public string ResourceId { get; set; }
        public int RoleId { get; set; }
        public string RoleType { get; set; }

        public virtual AdminRole Role { get; set; }
    }
}
