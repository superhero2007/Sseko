using System;
using System.Threading.Tasks;
using Akka.Actor;
using Sseko.Akka.DataService.Magento.Entities;
using Sseko.Akka.DataService.Magento.Messages;
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
            return (DataOperations.Result<Report>)await _coordinator.Ask(new DataOperations.DataOperation(ReportType.PersonalVolume, fellowId));
        }

        public async Task<DataOperations.Result<Report>> CreateDownlineReport(int fellowId)
        {
            return (DataOperations.Result<Report>)await _coordinator.Ask(new DataOperations.DataOperation(ReportType.DownlineSummary, fellowId));
        }

        public async Task<DataOperations.Result<Report>> CreateAdminSummaryReport(int fellowId)
        {
            return (DataOperations.Result<Report>)await _coordinator.Ask(new DataOperations.DataOperation(ReportType.AdminSummary, fellowId));
        }

        public async Task<DataOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            var fellows = (DataOperations.ResultList<User>) await _coordinator.Ask(new DataOperations.GetNewFellows(lastUpdated));

            return fellows;
        }
    }
}
