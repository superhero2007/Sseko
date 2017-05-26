using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CronSchedule
    {
        public int ScheduleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? ExecutedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public string Host { get; set; }
        public string JobCode { get; set; }
        public DateTime? KillRequest { get; set; }
        public DateTime? LastSeen { get; set; }
        public string Messages { get; set; }
        public string Parameters { get; set; }
        public string Pid { get; set; }
        public string ProgressMessage { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public int? ScheduledBy { get; set; }
        public string ScheduledReason { get; set; }
        public string Status { get; set; }
    }
}
