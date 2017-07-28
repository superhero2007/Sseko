using System;

namespace Sseko.Data.Models
{
    public partial class SpringbotCronQueue
    {
        public int Id { get; set; }
        public string Args { get; set; }
        public int Attempts { get; set; }
        public string CommandHash { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Error { get; set; }
        public DateTime? LockedAt { get; set; }
        public string LockedBy { get; set; }
        public string Method { get; set; }
        public DateTime? NextRunAt { get; set; }
        public int Priority { get; set; }
        public string Queue { get; set; }
        public DateTime? RunAt { get; set; }
        public int StoreId { get; set; }
    }
}
