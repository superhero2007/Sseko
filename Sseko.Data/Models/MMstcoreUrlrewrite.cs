namespace Sseko.Data.Models
{
    public partial class MMstcoreUrlrewrite
    {
        public int UrlrewriteId { get; set; }
        public int? EntityId { get; set; }
        public string Module { get; set; }
        public string Type { get; set; }
        public string UrlKey { get; set; }
    }
}
