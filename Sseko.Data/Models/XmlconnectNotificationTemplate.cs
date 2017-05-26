using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class XmlconnectNotificationTemplate
    {
        public XmlconnectNotificationTemplate()
        {
            XmlconnectQueue = new HashSet<XmlconnectQueue>();
        }

        public int TemplateId { get; set; }
        public ushort ApplicationId { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string MessageTitle { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Name { get; set; }
        public string PushTitle { get; set; }

        public virtual ICollection<XmlconnectQueue> XmlconnectQueue { get; set; }
        public virtual XmlconnectApplication Application { get; set; }
    }
}
