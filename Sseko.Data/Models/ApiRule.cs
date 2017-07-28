namespace Sseko.Data.Models
{
    public partial class ApiRule
    {
        public int RuleId { get; set; }
        public string ApiPermission { get; set; }
        public string ApiPrivileges { get; set; }
        public int AssertId { get; set; }
        public string ResourceId { get; set; }
        public int RoleId { get; set; }
        public string RoleType { get; set; }

        public virtual ApiRole Role { get; set; }
    }
}
