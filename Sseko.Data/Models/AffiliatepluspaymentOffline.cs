using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliatepluspaymentOffline
    {
        public int Id { get; set; }
        public string AddressHtml { get; set; }
        public int AddressId { get; set; }
        public string Message { get; set; }
        public int PaymentId { get; set; }
        public string TransferInfo { get; set; }

        public virtual AffiliateplusPayment Payment { get; set; }
    }
}
