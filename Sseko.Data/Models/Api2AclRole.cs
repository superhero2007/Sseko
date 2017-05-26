using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Api2AclRole
    {
        public Api2AclRole()
        {
            Api2AclRule = new HashSet<Api2AclRule>();
            Api2AclUser = new HashSet<Api2AclUser>();
        }

        public int EntityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string RoleName { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Api2AclRule> Api2AclRule { get; set; }
        public virtual ICollection<Api2AclUser> Api2AclUser { get; set; }
    }
}
