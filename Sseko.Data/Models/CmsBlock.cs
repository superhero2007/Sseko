using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CmsBlock
    {
        public CmsBlock()
        {
            CmsBlockStore = new HashSet<CmsBlockStore>();
        }

        public short BlockId { get; set; }
        public string Content { get; set; }
        public DateTime? CreationTime { get; set; }
        public string Identifier { get; set; }
        public short IsActive { get; set; }
        public string Title { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<CmsBlockStore> CmsBlockStore { get; set; }
    }
}
