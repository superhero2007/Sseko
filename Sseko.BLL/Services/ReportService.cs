using System;
using System.Threading.Tasks;
using Akka.Dispatch;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Akka.ReportGeneration.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Services
{
    public class ReportService : IReportService
    {
        public async Task<ReportOperations.Result<Report>> GetDownlineReport(int fellowId)
        {
            var reportGenerationService = new ReportGenerationService();

            var report = await reportGenerationService.CreateAsync(ReportOperations.ReportType.DownlineSummary, fellowId);

            return report;
        }

        public async Task<ReportOperations.Result<Report>> GetPvSummaryReport(int fellowId)
        {
            var reportGenerationService = new ReportGenerationService();

            var report = await reportGenerationService.CreateAsync(
                ReportOperations.ReportType.PvTransactionSummary, fellowId);

            return report;
        }

        public async Task<ReportOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            var reportGenerationService = new ReportGenerationService();

            var result = await reportGenerationService.GetNewFellows(lastUpdated);

            return result;
        }
    }
}
