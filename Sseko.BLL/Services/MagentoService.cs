using System;
using System.Threading.Tasks;
using Akka.Dispatch;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Akka.ReportGeneration.Reports;
using Sseko.Akka.ReportGeneration.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Services
{
    public class MagentoService : IMagentoService
    {
        private ReportGenerationService _ds;

        public MagentoService()
        {
            _ds = new ReportGenerationService();
        }

        public async Task<ReportOperations.Result<Report>> GetDownlineReport(int fellowId)
        {

            return await _ds.CreateAsync(ReportType.DownlineSummary, fellowId);
        }

        public async Task<ReportOperations.Result<Report>> GetPvSummaryReport(int fellowId)
        {
            return  await _ds.CreateAsync(ReportType.PvTransactionSummary, fellowId);
        }

        public async Task<ReportOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            return await _ds.GetNewFellows(lastUpdated);
        }

        public async Task<ReportOperations.ResultList<Transaction>> GetTransactions(int fellowId)
        {
            return await _ds.GetTransactions(fellowId);
        }
    }
}
