using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class XmlconnectApplication
    {
        public XmlconnectApplication()
        {
            XmlconnectConfigData = new HashSet<XmlconnectConfigData>();
            XmlconnectHistory = new HashSet<XmlconnectHistory>();
            XmlconnectNotificationTemplate = new HashSet<XmlconnectNotificationTemplate>();
        }

        public ushort ApplicationId { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public ushort? BrowsingMode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ushort Status { get; set; }
        public ushort? StoreId { get; set; }
        public string Type { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<XmlconnectConfigData> XmlconnectConfigData { get; set; }
        public virtual ICollection<XmlconnectHistory> XmlconnectHistory { get; set; }
        public virtual ICollection<XmlconnectNotificationTemplate> XmlconnectNotificationTemplate { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
