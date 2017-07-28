namespace Sseko.Data.Models
{
    public partial class XmlconnectConfigData
    {
        public ushort ApplicationId { get; set; }
        public string Category { get; set; }
        public string Path { get; set; }
        public string Value { get; set; }

        public virtual XmlconnectApplication Application { get; set; }
    }
}
