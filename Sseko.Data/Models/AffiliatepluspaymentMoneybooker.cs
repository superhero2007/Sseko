using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliatepluspaymentMoneybooker
    {
        public int PaymentMoneybookerId { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int PaymentId { get; set; }
        public string TransactionId { get; set; }

        public virtual AffiliateplusPayment Payment { get; set; }
    }
}
