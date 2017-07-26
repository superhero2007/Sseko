using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.ReportGeneration
{
    public class ReportGenerationService
    {
        private IActorRef _coordinator;
        public ReportGenerationService()
        {
            _coordinator = ActorSystemRefs.ReportCoordinatorActor;
        }

        public async Task<ReportGenerationOperations.Result> CreateAsync(ReportType reportType)
        {
            return (ReportGenerationOperations.Result) await _coordinator.Ask(new ReportGenerationOperations.Operation(reportType));
        }
    }
}
