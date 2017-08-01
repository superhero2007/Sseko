using System;
using System.Collections.Generic;
using System.Linq;
using Akka.Actor;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Data.Models;
using Sseko.DAL.DocumentDb.Entities;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.Akka.ReportGeneration.Actors
{
    public class WorkerActor : ReceiveActor, ILogReceive
    {
        public WorkerActor()
        {
            Receive<ReportOperations.ReportOperation>(message =>
            {
                switch (message.ReportType)
                {
                    case ReportOperations.ReportType.DownlineSummary:
                        var dlReport = GetDownlineReport(message);
                        Sender.Tell(new ReportOperations.Result<Report>(dlReport));
                        break;
                    case ReportOperations.ReportType.PvTransactionSummary:
                        var pvReport = GetPvTransactionSummaryReport(message);
                        Sender.Tell(new ReportOperations.Result<Report>(pvReport));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });
            Receive<ReportOperations.GetNewFellows>(message =>
            {
                var newFellows = GetNewFellows(message.LastUpdated);
                Sender.Tell(new ReportOperations.ResultList<User>(newFellows));
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

        private static Report GetDownlineReport(ReportOperations.ReportOperation message)
        {
            var report = new Report();
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

            var rows = (from fellow in childFellows
                        let transactions = DataStore.Transactions(fellowId)
                        let personalPurchases = transactions.Where(t => t.Commission == 0).Sum(t => t.TotalAmount)
                        let pv = transactions.Sum(t => t.TotalAmount)
                        select new List<string>
                {
                    fellow.Name,
                    fellow.Parent,
                    fellow.GrandParent,
                    fellow.Level.ToString(),
                    (pv - personalPurchases).ToString(),
                    pv.ToString()
                }).AsParallel().ToList();
            report.Rows = rows;

            return report;
        }

        private static Report GetPvTransactionSummaryReport(ReportOperations.ReportOperation message)
        {
            var report = new Report();
            var fellowId = message.FellowId;

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

            var transactions = DataStore.Transactions(fellowId);

            var rows = (from transaction in transactions
                let hostess = transaction.AccountName.Replace("Hostess ", "")
                let type = GetTransactionType(transaction)
                select new List<string>
                {
                    transaction.CreatedTime.ToString(),
                    transaction.OrderId.ToString(),
                    transaction.CustomerEmail,
                    hostess,
                    type,
                    transaction.Commission.ToString(),
                    transaction.TotalAmount.ToString()
                }).AsParallel().ToList();
            report.Rows = rows;

            return report;
        }

        private static string GetTransactionType(AffiliateplusTransaction transaction)
        {
            var transactionProgram = transaction.ProgramName ?? string.Empty;

            if (transactionProgram.Contains("Hostess"))
                return "Hostess Program";

            if (transactionProgram.Contains("Fellows"))
                return "Fellows Program";

            if (transaction.Commission == 0)
                return "Personal Purchase";

            return string.Empty;
        }

        private static List<User> GetNewFellows(DateTime? lastUpdateDate)
        {
            var activeAccounts =  DataStore.GetFellows(lastUpdateDate);

            return activeAccounts.Select(account => new User
                {
                    Email = account.Email,
                    NormalizedEmail = account.Email,
                    UserName = account.Email,
                    NormalizedUserName = account.Email,
                    CustomUrlId = account.IdentifyCode,
                    MagentoAccountId = account.AccountId
                }).AsParallel().ToList();
        }
    }
}