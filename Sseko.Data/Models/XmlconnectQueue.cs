using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class XmlconnectQueue
    {
        public int QueueId { get; set; }
        public string Content { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ExecTime { get; set; }
        public string MessageTitle { get; set; }
        public string PushTitle { get; set; }
        public ushort Status { get; set; }
        public int TemplateId { get; set; }
        public string Type { get; set; }

        public virtual XmlconnectNotificationTemplate Template { get; set; }
    }
}
