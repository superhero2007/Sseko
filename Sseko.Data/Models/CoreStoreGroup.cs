using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreStoreGroup
    {
        public CoreStoreGroup()
        {
            CoreStore = new HashSet<CoreStore>();
        }

        public ushort GroupId { get; set; }
        public ushort DefaultStoreId { get; set; }
        public string Name { get; set; }
        public int RootCategoryId { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual ICollection<CoreStore> CoreStore { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
