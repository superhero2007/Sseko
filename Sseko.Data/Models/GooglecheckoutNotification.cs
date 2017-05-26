using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GooglecheckoutNotification
    {
        public string SerialNumber { get; set; }
        public DateTime? StartedAt { get; set; }
        public ushort Status { get; set; }
    }
}
