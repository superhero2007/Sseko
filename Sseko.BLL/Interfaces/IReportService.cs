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
        Task<ReportGenerationOperations.Result> GenerateReport(ReportGenerationOperations.ReportType reportType);
    }
}
