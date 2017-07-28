using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaStatus
    {
        public MRmaStatus()
        {
            MRmaComment = new HashSet<MRmaComment>();
            MRmaRma = new HashSet<MRmaRma>();
            MRmaRule = new HashSet<MRmaRule>();
        }

        public int StatusId { get; set; }
        public string AdminMessage { get; set; }
        public string Code { get; set; }
        public string CustomerMessage { get; set; }
        public string HistoryMessage { get; set; }
        public bool IsActive { get; set; }
        public bool IsRmaResolved { get; set; }
        public string Name { get; set; }
        public short SortOrder { get; set; }

        public virtual ICollection<MRmaComment> MRmaComment { get; set; }
        public virtual ICollection<MRmaRma> MRmaRma { get; set; }
        public virtual ICollection<MRmaRule> MRmaRule { get; set; }
    }
}
