using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Interfaces
{
    public interface IReportService
    {
        Task<List<List<string>>> GenerateReport(ReportType reportType);
    }
}
