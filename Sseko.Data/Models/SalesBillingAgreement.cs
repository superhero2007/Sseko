using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesBillingAgreement
    {
        public SalesBillingAgreement()
        {
            SalesBillingAgreementOrder = new HashSet<SalesBillingAgreementOrder>();
        }

        public int AgreementId { get; set; }
        public string AgreementLabel { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CustomerId { get; set; }
        public string MethodCode { get; set; }
        public string ReferenceId { get; set; }
        public string Status { get; set; }
        public ushort? StoreId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<SalesBillingAgreementOrder> SalesBillingAgreementOrder { get; set; }
        public virtual CustomerEntity Customer { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
