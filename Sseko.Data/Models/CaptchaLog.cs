using System;

namespace Sseko.Data.Models
{
    public partial class CaptchaLog
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public int Count { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
