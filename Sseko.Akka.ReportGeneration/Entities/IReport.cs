using System.Collections.Generic;

namespace Sseko.Akka.DataService.Magento.Entities
{
    public interface IReport
    {
        string UserId { get; set; }
        int MagentoId { get; set; }
        List<Dictionary<string, string>> Rows { get; set; }
    }
}
