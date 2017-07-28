using System.Threading.Tasks;
using Akka.Actor;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.ReportGeneration.Services
{
    public class ReportGenerationService
    {
        private IActorRef _coordinator;
        public ReportGenerationService()
        {
            _coordinator = ActorSystemRefs.ReportCoordinatorActor;
        }

        public async Task<Report> CreateAsync(ReportOperations.ReportType reportType, int i)
        {
            return (Report) await _coordinator.Ask(new ReportOperations.GetNewFellows());
        }
    }
}
