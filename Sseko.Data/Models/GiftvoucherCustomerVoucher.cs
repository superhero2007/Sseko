using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftvoucherCustomerVoucher
    {
        public int CustomerVoucherId { get; set; }
        public DateTime? AddedDate { get; set; }
        public int CustomerId { get; set; }
        public int VoucherId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual Giftvoucher Voucher { get; set; }
    }
}
