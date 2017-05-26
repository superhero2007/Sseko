using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class PaypalauthCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string PayerId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
    }
}
