using System;
using System.Threading.Tasks;
using Akka.Actor;
using Sseko.Akka.DataService.Magento.Entities;
using Sseko.Akka.DataService.Magento.Messages;
using Sseko.Core.Models;
using Sseko.Data.Models;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.DataService.Magento.Services
{
    public class ReportGenerationService
    {
        private IActorRef _coordinator;

        public ReportGenerationService()
        {
            _coordinator = ActorSystemRefs.ReportCoordinatorActor;
        }

        public async Task<DataOperations.Result<Report>> CreatePvReport(int fellowId)
        {
            return (DataOperations.Result<Report>)await _coordinator.Ask(new DataOperations.DataOperation(OperationType.PersonalVolume, fellowId));
        }

        public async Task<DataOperations.Result<Report>> CreateDownlineReport(int fellowId)
        {
            return (DataOperations.Result<Report>)await _coordinator.Ask(new DataOperations.DataOperation(OperationType.DownlineSummary, fellowId));
        }

        public async Task<DataOperations.Result<Report>> CreateAdminSummaryReport(int fellowId)
        {
            return (DataOperations.Result<Report>)await _coordinator.Ask(new DataOperations.DataOperation(OperationType.AdminSummary, fellowId));
        }

        public async Task<DataOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            var fellows = (DataOperations.ResultList<User>) await _coordinator.Ask(new DataOperations.GetNewFellows(lastUpdated));

            return fellows;
        }

        public async Task<DataOperations.Result<DashboardModel>> GetDashboard(int fellowId, DateTime start, DateTime end)
        {
            return (DataOperations.Result<DashboardModel>) await _coordinator.Ask(new DataOperations.DataOperation(OperationType.Dashboard, fellowId, start, end));
        }
    }
}
