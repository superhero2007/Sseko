using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AdminRole
    {
        public AdminRole()
        {
            AdminRule = new HashSet<AdminRule>();
        }

        public int RoleId { get; set; }
        public int ParentId { get; set; }
        public string RoleName { get; set; }
        public string RoleType { get; set; }
        public ushort SortOrder { get; set; }
        public ushort TreeLevel { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<AdminRule> AdminRule { get; set; }
    }
}
