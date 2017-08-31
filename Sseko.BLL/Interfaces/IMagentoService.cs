using System;
using System.Threading.Tasks;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Akka.ReportGeneration.Reports;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Interfaces
{
    public interface IMagentoService
    {
        Task<ReportOperations.Result<Report>> GetDownlineReport(int fellowId);

        Task<ReportOperations.Result<Report>> GetPvSummaryReport(int fellowId);

        Task<ReportOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated = null);

        Task<ReportOperations.ResultList<Transaction>> GetTransactions(int fellowId);
    }
}
