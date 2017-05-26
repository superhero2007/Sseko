using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliatepluslevelTransaction
    {
        public int Id { get; set; }
        public decimal Commission { get; set; }
        public decimal CommissionPlus { get; set; }
        public byte Level { get; set; }
        public int TierId { get; set; }
        public int TransactionId { get; set; }

        public virtual AffiliateplusAccount Tier { get; set; }
        public virtual AffiliateplusTransaction Transaction { get; set; }
    }
}
