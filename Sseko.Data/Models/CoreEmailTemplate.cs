using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreEmailTemplate
    {
        public int TemplateId { get; set; }
        public DateTime? AddedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string OrigTemplateCode { get; set; }
        public string OrigTemplateVariables { get; set; }
        public string TemplateCode { get; set; }
        public string TemplateSenderEmail { get; set; }
        public string TemplateSenderName { get; set; }
        public string TemplateStyles { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateText { get; set; }
        public int? TemplateType { get; set; }
    }
}
