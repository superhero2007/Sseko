using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Interfaces
{
    public interface IReportService
    {
        Task<ReportOperations.Result<Report>> GenerateReport(ReportOperations.ReportType reportType);
    }
}
