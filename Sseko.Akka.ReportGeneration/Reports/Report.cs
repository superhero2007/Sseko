using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sseko.Akka.ReportGeneration.Reports
{
    public class Report : IReport
    {
        public string UserId { get; set; }
        public int MagentoId { get; set; }
        public List<Dictionary<string,string>> Rows { get; set; }
    }
}
