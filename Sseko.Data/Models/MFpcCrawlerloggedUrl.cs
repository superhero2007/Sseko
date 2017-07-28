using System;

namespace Sseko.Data.Models
{
    public partial class MFpcCrawlerloggedUrl
    {
        public int UrlId { get; set; }
        public string CacheId { get; set; }
        public DateTime CheckedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Currency { get; set; }
        public short? CustomerGroupId { get; set; }
        public string MobileGroup { get; set; }
        public int Rate { get; set; }
        public string SortByPageType { get; set; }
        public int SortByProductAttribute { get; set; }
        public int Status { get; set; }
        public short StoreId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
    }
}
