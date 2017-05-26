using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CheckoutAgreement
    {
        public CheckoutAgreement()
        {
            CheckoutAgreementStore = new HashSet<CheckoutAgreementStore>();
        }

        public int AgreementId { get; set; }
        public string CheckboxText { get; set; }
        public string Content { get; set; }
        public string ContentHeight { get; set; }
        public short IsActive { get; set; }
        public short IsHtml { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CheckoutAgreementStore> CheckoutAgreementStore { get; set; }
    }
}
