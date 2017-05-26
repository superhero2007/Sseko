using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MagenotificationExtensionFeedbackmessage
    {
        public int FeedbackmessageId { get; set; }
        public string FeedbackCode { get; set; }
        public int FeedbackId { get; set; }
        public string File { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsSent { get; set; }
        public string Message { get; set; }
        public DateTime? PostedTime { get; set; }
        public string User { get; set; }
    }
}
