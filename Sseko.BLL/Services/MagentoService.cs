using System;
using System.Threading.Tasks;
using Akka.Dispatch;
using Sseko.Akka.DataService.Magento.Entities;
using Sseko.Akka.DataService.Magento.Messages;
using Sseko.Akka.DataService.Magento.Services;
using Sseko.BLL.Interfaces;
using Sseko.Core.Models;
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

        public async Task<DataOperations.Result<Report>> GetDownlineReport(int fellowId)
        {

            return await _ds.CreateDownlineReport(fellowId);
        }

        public async Task<DataOperations.Result<Report>> GetPvSummaryReport(int fellowId)
        {
            return  await _ds.CreatePvReport(fellowId);
        }

        public async Task<DataOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            return await _ds.GetNewFellows(lastUpdated);
        }

        public async Task<DashboardModel> GetDashboard(int fellowId, DateTime start, DateTime end)
        {
            var request =  await _ds.GetDashboard(fellowId, start, end);

            if (request.IsError) throw request.Exception;

            return request.Output;
        }
    }
}
