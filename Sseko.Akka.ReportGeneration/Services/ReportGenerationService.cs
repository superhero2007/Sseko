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

        public async Task<DataOperations.Result<ReportBase>> CreateAsync(ReportType reportType, int fellowId)
        {
            var report = (DataOperations.Result<ReportBase>)await _coordinator.Ask(new DataOperations.DataOperation(reportType, fellowId));

            return report;
        }

        public async Task<DataOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            var fellows = (DataOperations.ResultList<User>) await _coordinator.Ask(new DataOperations.GetNewFellows(lastUpdated));

            return fellows;
        }

        public async Task<DataOperations.ResultList<Transaction>> GetTransactions(int fellowId)
        {
            return (DataOperations.ResultList<Transaction>) await _coordinator.Ask(new DataOperations.GetTransactions(fellowId));
        }
    }
}
