using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class NewsletterTemplate
    {
        public NewsletterTemplate()
        {
            NewsletterQueue = new HashSet<NewsletterQueue>();
        }

        public int TemplateId { get; set; }
        public DateTime? AddedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public ushort? TemplateActual { get; set; }
        public string TemplateCode { get; set; }
        public string TemplateSenderEmail { get; set; }
        public string TemplateSenderName { get; set; }
        public string TemplateStyles { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateText { get; set; }
        public string TemplateTextPreprocessed { get; set; }
        public int? TemplateType { get; set; }

        public virtual ICollection<NewsletterQueue> NewsletterQueue { get; set; }
    }
}
