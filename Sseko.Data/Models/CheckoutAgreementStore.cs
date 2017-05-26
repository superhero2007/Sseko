using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CheckoutAgreementStore
    {
        public int AgreementId { get; set; }
        public ushort StoreId { get; set; }

        public virtual CheckoutAgreement Agreement { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
