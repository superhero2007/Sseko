using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaReason
    {
        public MRmaReason()
        {
            MRmaItem = new HashSet<MRmaItem>();
            MRmaOfflineItem = new HashSet<MRmaOfflineItem>();
        }

        public int ReasonId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public short SortOrder { get; set; }

        public virtual ICollection<MRmaItem> MRmaItem { get; set; }
        public virtual ICollection<MRmaOfflineItem> MRmaOfflineItem { get; set; }
    }
}
