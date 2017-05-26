using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreSession
    {
        public string SessionId { get; set; }
        public byte[] SessionData { get; set; }
        public int SessionExpires { get; set; }
    }
}
