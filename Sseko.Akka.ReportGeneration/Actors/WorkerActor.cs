using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Routing;
using Microsoft.EntityFrameworkCore;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Data;
using Sseko.Data.Models;
using Sseko.DAL.DocumentDb.Entities;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.Akka.ReportGeneration.Actors
{
    public class WorkerActor : ReceiveActor, ILogReceive
    {
        public WorkerActor()
        {
            Receive<ReportGenerationOperations.Operation>(message =>
            {
                switch (message.ReportType)
                {
                    case ReportGenerationOperations.ReportType.DownlineSummary:
                        var dlReport = GetDownlineReport(message);
                        Sender.Tell(new ReportGenerationOperations.Result(dlReport));
                        break;
                    case ReportGenerationOperations.ReportType.PvTransactionSummary:
                        var pvReport = GetPvTransactionSummaryReport(message);
                        Sender.Tell(new ReportGenerationOperations.Result(pvReport));
                        break;
                    default:
                        break;
                }
            });
        }

        internal class FellowLite
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public int Level { get; set; }
            public string Parent { get; set; }
            public string GrandParent { get; set; }
        }

        private Report GetDownlineReport(ReportGenerationOperations.Operation message)
        {
            var report = new Report();
            var rows = new List<List<string>>();
            var fellowId = message.FellowId;

            report.Columns = new List<Column>
            {
                new Column { Name = "Fellow"},
                new Column { Name = "Parent"},
                new Column { Name = "GrandParent"},
                new Column { Name = "Level"},
                new Column { Name = "Commissionable Sales"},
                new Column { Name = "PV"}
            };

            var childFellows = DataStore.GetAllChildren(fellowId);

            foreach (var fellow in childFellows)
            {
                var hostesses = DataStore.GetHostessIds(fellow.Id);

                var transactions = DataStore.TransactionsWhere(t => t.AccountId == fellow.Id || hostesses.Contains(t.AccountId));
                transactions.Add(new AffiliateplusTransaction());
                var personalPurchases = transactions.Where(t => t.Commission == 0).Sum(t => t.TotalAmount);

                var pv = transactions.Sum(t => t.TotalAmount);

                var row = new List<string>
                {
                    fellow.Name,
                    fellow.Parent,
                    fellow.GrandParent,
                    fellow.Level.ToString(),
                    (pv - personalPurchases).ToString(),
                    pv.ToString()
                };
                rows.Add(row);
            }
            report.Rows = rows;

            return report;
        }

        private Report GetPvTransactionSummaryReport(ReportGenerationOperations.Operation message)
        {
            var report = new Report();
            var rows = new List<List<string>>();
            var fellow = message.FellowId;

            report.Columns = new List<Column>
            {
                new Column { Name = "Date" },
                new Column { Name = "Order Number" },
                new Column { Name = "Customer" },
                new Column { Name = "Hostess" },
                new Column { Name = "Type" },
                new Column { Name = "Commission" },
                new Column { Name = "Sale" }
            };

            var hostesses = DataStore.GetHostessIds(fellow);

            var transactions = DataStore.TransactionsWhere(t => t.AccountId == fellow || hostesses.Contains(t.AccountId));

            foreach (var transaction in transactions)
            {
                string hostess = string.Empty;
                if (transaction.AccountName.Contains("Hostess"))
                {
                    hostess = transaction.AccountName.Skip(8).ToString();
                }
                string type = string.Empty;
                var transactionProgram = transaction.ProgramName ?? string.Empty;
                if (transactionProgram.Contains("Hostess"))
                    type = "Hostess Program";
                else if (transactionProgram.Contains("Fellows"))
                    type = "Fellows Program";
                else if (transaction.Commission == 0)
                    type = "Personal Purchase";

                var row = new List<string>
                {
                    transaction.CreatedTime.ToString(),
                    transaction.OrderId.ToString(),
                    transaction.CustomerEmail,
                    hostess,
                    type,
                    transaction.Commission.ToString(),
                    transaction.TotalAmount.ToString()
                };
                rows.Add(row);
            }
            report.Rows = rows;

            return report;
        }
    }
}
