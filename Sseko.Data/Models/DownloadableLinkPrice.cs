namespace Sseko.Data.Models
{
    public partial class DownloadableLinkPrice
    {
        public int PriceId { get; set; }
        public int LinkId { get; set; }
        public decimal Price { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual DownloadableLink Link { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
