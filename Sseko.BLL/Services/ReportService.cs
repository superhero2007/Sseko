using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Sseko.Akka.ReportGeneration;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.BLL.Services
{
    public class ReportService : IReportService
    {
        public async Task<List<List<string>>> GenerateReport(ReportType reportType)
        {
            var reportService = new ReportGenerationService();

            var keyColumn = new Column
            {
                ColumnKey = true,
                Name = "fellows"
            };
            var otherColumn = new Column
            {
                Name = "sales"
            };

            var report = new ReportType();

            report.Columns.Add(keyColumn);
            report.Columns.Add(otherColumn);

            return (await  reportService.CreateAsync(report)).Output;
        }
    }
}
