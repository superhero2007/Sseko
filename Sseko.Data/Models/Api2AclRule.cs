using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Api2AclRule
    {
        public int EntityId { get; set; }
        public string Privilege { get; set; }
        public string ResourceId { get; set; }
        public int RoleId { get; set; }

        public virtual Api2AclRole Role { get; set; }
    }
}
