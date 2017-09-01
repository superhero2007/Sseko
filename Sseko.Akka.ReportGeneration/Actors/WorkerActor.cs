using System;
using System.Collections.Generic;
using System.Linq;
using Akka.Actor;
using Sseko.Akka.DataService.Magento.Entities;
using Sseko.Akka.DataService.Magento.Messages;
using Sseko.Data.Models;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.DataService.Magento.Actors
{
    public class WorkerActor : ReceiveActor, ILogReceive
    {
        public WorkerActor()
        {
            Receive<DataOperations.DataOperation>(message =>
            {
                switch (message.ReportType)
                {
                    case ReportType.DownlineSummary:
                        var dlReport = GetDownlineReport(message);
                        Sender.Tell(new DataOperations.Result<ReportBase>(dlReport));
                        break;
                    case ReportType.PvTransactionSummary:
                        var pvReport = GetPvTransactionSummaryReport(message);
                        Sender.Tell(new DataOperations.Result<ReportBase>(pvReport));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });
            Receive<DataOperations.GetNewFellows>(message =>
            {
                var newFellows = GetNewFellows(message.LastUpdated);
                Sender.Tell(new DataOperations.ResultList<User>(newFellows));
            });
            Receive<DataOperations.GetTransactions>(message =>
            {
                Sender.Tell(new DataOperations.ResultList<Transaction>(GetTransactions(message.FellowId)));
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

        private static ReportBase GetDownlineReport(DataOperations.DataOperation message)
        {
            var report = new ReportBase();
            var fellowId = message.FellowId;

            var childFellows = DataStore.GetAllChildren(fellowId);

            var rows = (from fellow in childFellows
                        let transactions = DataStore.Transactions(fellow.Id)
                        let personalPurchases = transactions.Where(t => t.Commission == 0).Sum(t => t.TotalAmount)
                        let pv = transactions.Sum(t => t.TotalAmount)
                        select new Dictionary<string, string>
                {
                    {"fellow", fellow.Name},
                    {"parent", fellow.Parent},
                    {"grandparent", fellow.GrandParent},
                    {"level", fellow.Level.ToString()},
                    {"commissionableSales", (pv - personalPurchases).ToCurrency()},
                    {"pv", pv.ToCurrency()}
                }).AsParallel().ToList();

            report.Rows = rows;

            return report;
        }

        private static ReportBase GetPvTransactionSummaryReport(DataOperations.DataOperation message)
        {
            var report = new ReportBase();
            var fellowId = message.FellowId;
            var transactions = MapTransactions(fellowId);

            var rows = (from transaction in transactions
                        select new Dictionary<string, string>
                            {
                                { "date", transaction.Date.ToString("MM/dd/yy") },
                                { "orderNumber", transaction.OrderId},
                                { "customer",  transaction.Customer},
                                { "hostess", transaction.Hostess},
                                { "type", transaction.Type},
                                { "commission", transaction.CommissionalbeSale.ToCurrency()},
                                { "sale", transaction.TotalAmount.ToCurrency()}
                            }).AsParallel().ToList();

            report.Rows = rows;

            return report;
        }

        private static string GetTransactionType(AffiliateplusTransaction transaction, SalesFlatOrder saleOrder)
        {
            var transactionProgram = transaction.ProgramName ?? string.Empty;

            if (transactionProgram.Contains("Hostess"))
                return "Hostess Program";

            if (transactionProgram.Contains("Fellows"))
                return "Fellows Program";

            if (saleOrder.CouponCode != null && saleOrder.CouponCode.StartsWith("FPP"))
                return "Personal Purchase";

            return string.Empty;
        }

        private static List<User> GetNewFellows(DateTime? lastUpdateDate)
        {
            var activeAccounts = DataStore.GetFellows(lastUpdateDate);

            return activeAccounts.Select(account => new User
            {
                UserName = account.Email,
                CustomUrlId = account.IdentifyCode,
                MagentoAccountId = account.AccountId
            }).AsParallel().ToList();
        }

        private static List<Transaction> MapTransactions(int fellowId)
        {
            try
            {
                var transactions = DataStore.Transactions(fellowId);
                var salesFlatOrders = DataStore.SalesFlatOrders(transactions);

                return (from transaction in transactions
                        let hostess = transaction.AccountName.Contains("Hostess") ? transaction.AccountName.Replace("Hostess ", "") : string.Empty
                        let saleOrder = salesFlatOrders.FirstOrDefault(s => s.EntityId == transaction.OrderId)

                        select new Transaction
                        {
                            Date = transaction.CreatedTime ?? DateTime.MinValue,
                            OrderId = transaction.OrderNumber,
                            Customer = transaction.CustomerEmail,
                            Hostess = hostess,
                            Type = GetTransactionType(transaction, saleOrder),
                            CommissionalbeSale = GetCommissionableSale(saleOrder),
                            TotalAmount = GetTotalAmount(saleOrder)
                        }).AsParallel().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private static decimal GetCommissionableSale(SalesFlatOrder sale)
        {
            if (sale.CouponCode != null && sale.CouponCode.StartsWith("FPP")) return 0;

            var totalBeforeDiscounts = (sale.BaseSubtotalInvoiced ?? 0) + (sale.BaseShippingInclTax ?? 0);
            var discounts = (sale.GrandTotal ?? 0) - totalBeforeDiscounts;

            return totalBeforeDiscounts + discounts;
        }
        private static decimal GetTotalAmount(SalesFlatOrder sale)
        {
            return (sale.BaseSubtotalInvoiced ?? 0) + (sale.BaseShippingInclTax ?? 0);
        }

        private static List<Transaction> GetTransactions(int fellowId)
        {
            return null;
        }
    }

    internal static class Extensions
    {
        internal static string ToCurrency(this decimal number)
        {
            var rounded = Math.Round(number, 2).ToString("0.00");

            return $"${rounded}";
        }
    }
}