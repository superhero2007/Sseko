using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class OauthNonce
    {
        public string Nonce { get; set; }
        public int Timestamp { get; set; }
    }
}
