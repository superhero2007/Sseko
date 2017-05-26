using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Magenotification
    {
        public int MagenotificationId { get; set; }
        public DateTime AddedDate { get; set; }
        public string Description { get; set; }
        public sbyte? IsRead { get; set; }
        public sbyte? IsRemove { get; set; }
        public string RelatedExtensions { get; set; }
        public ushort Severity { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
