using System;
using System.Threading.Tasks;
using Sseko.Akka.DataService.Magento.Entities;
using Sseko.Akka.DataService.Magento.Messages;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Interfaces
{
    public interface IMagentoService
    {
        Task<DataOperations.Result<Report>> GetDownlineReport(int fellowId);

        Task<DataOperations.Result<Report>> GetPvSummaryReport(int fellowId);

        Task<DataOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated = null);
    }
}
