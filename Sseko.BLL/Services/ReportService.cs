using System.Threading.Tasks;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Akka.ReportGeneration.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Services
{
    public class ReportService : IReportService
    {
        public async Task<ReportOperations.Result<Report>> GenerateReport(ReportOperations.ReportType reportType)
        {
            var reportGenerationService = new ReportGenerationService();

            var report = await reportGenerationService.CreateAsync(reportType, 43);

            return null;
        }
    }
}
