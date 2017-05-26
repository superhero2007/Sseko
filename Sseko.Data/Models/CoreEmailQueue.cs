using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreEmailQueue
    {
        public CoreEmailQueue()
        {
            CoreEmailQueueRecipients = new HashSet<CoreEmailQueueRecipients>();
        }

        public int MessageId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? EntityId { get; set; }
        public string EntityType { get; set; }
        public string EventType { get; set; }
        public string MessageBody { get; set; }
        public string MessageBodyHash { get; set; }
        public string MessageParameters { get; set; }
        public DateTime? ProcessedAt { get; set; }

        public virtual ICollection<CoreEmailQueueRecipients> CoreEmailQueueRecipients { get; set; }
    }
}
