using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using Sseko.Akka.ReportGeneration;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Akka.ReportGeneration.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.BLL.Services
{
    public class ReportService : IReportService
    {
        public async Task<ReportGenerationOperations.Result> GenerateReport(ReportGenerationOperations.ReportType reportType)
        {
            var reportGenerationService = new ReportGenerationService();

            var report = await reportGenerationService.CreateAsync(reportType, 43);

            return null;
        }
    }
}
