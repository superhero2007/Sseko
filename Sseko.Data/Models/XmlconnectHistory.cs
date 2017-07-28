using System;

namespace Sseko.Data.Models
{
    public partial class XmlconnectHistory
    {
        public int HistoryId { get; set; }
        public string ActivationKey { get; set; }
        public ushort ApplicationId { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Name { get; set; }
        public byte[] Params { get; set; }
        public ushort? StoreId { get; set; }
        public string Title { get; set; }

        public virtual XmlconnectApplication Application { get; set; }
    }
}
