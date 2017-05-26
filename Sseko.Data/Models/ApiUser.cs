using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ApiUser
    {
        public int UserId { get; set; }
        public string ApiKey { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public short IsActive { get; set; }
        public string Lastname { get; set; }
        public ushort Lognum { get; set; }
        public DateTime? Modified { get; set; }
        public short ReloadAclFlag { get; set; }
        public string Username { get; set; }
    }
}
