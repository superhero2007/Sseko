using System;

namespace Sseko.Data.Models
{
    public partial class TmCacheLog
    {
        public int EntityId { get; set; }
        public string CacheId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ushort CustomerGroupId { get; set; }
        public string FullActionName { get; set; }
        public ushort IsHit { get; set; }
        public string Params { get; set; }
        public ushort StoreId { get; set; }
    }
}
