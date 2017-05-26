using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliatepluspaymentBank
    {
        public int Id { get; set; }
        public string BankaccountHtml { get; set; }
        public int BankaccountId { get; set; }
        public string InvoiceNumber { get; set; }
        public string Message { get; set; }
        public int PaymentId { get; set; }

        public virtual AffiliateplusPayment Payment { get; set; }
    }
}
