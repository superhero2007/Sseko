using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MagenotificationExtensionFeedback
    {
        public int FeedbackId { get; set; }
        public string Code { get; set; }
        public string Comment { get; set; }
        public string Content { get; set; }
        public string CouponCode { get; set; }
        public string CouponValue { get; set; }
        public DateTime Created { get; set; }
        public DateTime ExpiredCounpon { get; set; }
        public string Extension { get; set; }
        public string ExtensionVersion { get; set; }
        public string File { get; set; }
        public bool IsSent { get; set; }
        public string LatestMessage { get; set; }
        public string LatestResponse { get; set; }
        public DateTime? LatestResponseTime { get; set; }
        public bool Status { get; set; }
        public DateTime Updated { get; set; }
    }
}
