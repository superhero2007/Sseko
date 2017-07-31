using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Data.QueryModels;
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

        public async Task<ReportOperations.Result<Report>> CreateAsync(ReportOperations.ReportType reportType, int fellowId)
        {
            var report = (ReportOperations.Result<Report>)await _coordinator.Ask(new ReportOperations.ReportOperation(reportType, fellowId));

            return report;
        }

        public async Task<ReportOperations.ResultList<User>> GetNewFellows(DateTime? lastUpdated)
        {
            var fellows = (ReportOperations.ResultList<User>) await _coordinator.Ask(new ReportOperations.GetNewFellows(lastUpdated));

            return fellows;
        }
    }
}
