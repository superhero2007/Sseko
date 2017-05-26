using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AdminUser
    {
        public AdminUser()
        {
            MRmaComment = new HashSet<MRmaComment>();
            MRmaRule = new HashSet<MRmaRule>();
            OauthToken = new HashSet<OauthToken>();
        }

        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public string Extra { get; set; }
        public string Firstname { get; set; }
        public short IsActive { get; set; }
        public string Lastname { get; set; }
        public DateTime? Logdate { get; set; }
        public ushort Lognum { get; set; }
        public DateTime? Modified { get; set; }
        public string Password { get; set; }
        public short ReloadAclFlag { get; set; }
        public string RpToken { get; set; }
        public DateTime? RpTokenCreatedAt { get; set; }
        public string Username { get; set; }

        public virtual Api2AclUser Api2AclUser { get; set; }
        public virtual ICollection<MRmaComment> MRmaComment { get; set; }
        public virtual ICollection<MRmaRule> MRmaRule { get; set; }
        public virtual ICollection<OauthToken> OauthToken { get; set; }
    }
}
