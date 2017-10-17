using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sseko.Core.Models
{
    public class DownlineTransactionGroup
    {
        public int DownlineFellowId { get; set; }

        public int DownlineFellowLevel { get; set; }

        public List<TransactionModel> Transactions { get; set; } = new List<TransactionModel>();
    }
}
