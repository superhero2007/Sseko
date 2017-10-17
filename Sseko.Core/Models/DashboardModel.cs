using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sseko.Core.Models
{
    public class DashboardModel
    {
        public List<TransactionModel> MyTransactions { get; set; } = new List<TransactionModel>();

        public List<DownlineTransactionGroup> MyDownlineTransactions { get; set; } = new List<DownlineTransactionGroup>();
    }
}
