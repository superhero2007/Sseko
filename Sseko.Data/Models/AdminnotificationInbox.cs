using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AdminnotificationInbox
    {
        public int NotificationId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public ushort IsRead { get; set; }
        public ushort IsRemove { get; set; }
        public ushort Severity { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
