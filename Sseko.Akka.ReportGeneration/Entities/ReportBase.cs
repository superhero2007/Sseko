using System.Collections.Generic;

namespace Sseko.Akka.DataService.Magento.Entities
{
    public class ReportBase : IReport
    {
        public string UserId { get; set; }
        public int MagentoId { get; set; }
        public List<Dictionary<string,string>> Rows { get; set; }
    }
}
