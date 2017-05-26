using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftcardTemplate
    {
        public GiftcardTemplate()
        {
            Giftvoucher = new HashSet<Giftvoucher>();
        }

        public int GiftcardTemplateId { get; set; }
        public string BackgroundImg { get; set; }
        public string Caption { get; set; }
        public short? DesignPattern { get; set; }
        public string Images { get; set; }
        public string Notes { get; set; }
        public short Status { get; set; }
        public string StyleColor { get; set; }
        public string TemplateName { get; set; }
        public string TextColor { get; set; }

        public virtual ICollection<Giftvoucher> Giftvoucher { get; set; }
    }
}
