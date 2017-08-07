using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sseko.Akka.ReportGeneration.Reports
{
    public interface IReport
    {
        string UserId { get; set; }
        int MagentoId { get; set; }
        List<Dictionary<string, string>> Rows { get; set; }
    }
}
