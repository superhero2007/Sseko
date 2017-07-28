namespace Sseko.Data.Models
{
    public partial class DownloadableLinkTitle
    {
        public int TitleId { get; set; }
        public int LinkId { get; set; }
        public ushort StoreId { get; set; }
        public string Title { get; set; }

        public virtual DownloadableLink Link { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
