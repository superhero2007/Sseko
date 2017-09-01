using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Sseko.Akka.DataService.Magento.Actors;
using Sseko.Data;
using Sseko.Data.Models;

namespace Sseko.Akka.DataService.Magento
{
    public static class DataStore
    {
        private static SsekoContext _dataContext;
        private static ImmutableList<AffiliateplusTransaction> _aPlusTransactions;
        private static ImmutableList<AffiliateplusAccount> _accounts;
        private static ImmutableList<AffiliatepluslevelTier> _underlings;
        private static ImmutableList<SalesFlatOrder> _salesOrders;

        public static void Init()
        {
            if (_dataContext == null) _dataContext = ActorSystemRefs.Context;
            if (_aPlusTransactions == null) _aPlusTransactions = _dataContext.AffiliateplusTransaction.ToImmutableList();
            if (_accounts == null) _accounts = _dataContext.AffiliateplusAccount.ToImmutableList();
            if (_underlings == null) _underlings = _dataContext.AffiliatepluslevelTier.ToImmutableList();
            if (_salesOrders == null) _salesOrders = _dataContext.SalesFlatOrder.ToImmutableList();
        }


        internal static void Terminate()
        {
            _aPlusTransactions = null;
            _accounts = null;
            _underlings = null;
        }

        internal static ImmutableList<AffiliateplusTransaction> Transactions(int fellowId)
        {
            var hostesses = GetHostessIds(fellowId);

            return TransactionsWhere(t => t.AccountId == fellowId || hostesses.Contains(t.AccountId));
        }

        internal static ImmutableList<AffiliateplusTransaction> TransactionsWhere(Func<AffiliateplusTransaction, bool> predicate)
        {
            Init();

            return _aPlusTransactions.Where(predicate).Where(t => t.CreatedTime.HasValue).ToImmutableList();
        }

        internal static ImmutableList<SalesFlatOrder> SalesFlatOrders(IEnumerable<AffiliateplusTransaction> transactions)
        {
            var transactionIds = transactions.Select(t => t.OrderId);
            return SalesFlatOrders(t => transactionIds.Contains(t.EntityId));
        }

        internal static ImmutableList<SalesFlatOrder> SalesFlatOrders(Func<SalesFlatOrder, bool> predicate)
        {
            return _dataContext.SalesFlatOrder.Where(predicate).ToImmutableList();
        }

        internal static ImmutableList<int> GetHostessIds(int overlordAccountId)
        {
            Init();

            var allUnderlingIds = _underlings.Where(u => u.ToptierId == overlordAccountId).Select(u => u.TierId).ToList();

            return _accounts.Where(a => allUnderlingIds.Contains(a.AccountId) && a.Name.Contains("Hostess")).Select(a => a.AccountId).ToImmutableList();
        }

        internal static ImmutableList<AffiliateplusAccount> GetFellows(DateTime? lastUpdated = null)
        {
            Init();

            var fellows = _accounts.Where(a => !a.Name.Contains("Hostess") &&
                                                a.Balance + a.TotalCommissionReceived != 0 &&
                                                a.Status
                                                ).OrderBy(a => a.Name).ToImmutableList();

            return lastUpdated == null
                    ? fellows
                    : fellows.Where(f => f.CreatedTime > lastUpdated).ToImmutableList();
        }

        internal static ImmutableList<AffiliateplusAccount> GetUnderlings(int overlordAccountId, bool includeHostesses = false)
        {
            Init();

            var allUnderlingIds = _underlings.Where(u => u.ToptierId == overlordAccountId).Select(u => u.TierId).ToList();

            var underlings = _accounts.Where(a => allUnderlingIds.Contains(a.AccountId)).ToList();

            return includeHostesses ? underlings.ToImmutableList() : underlings.Where(u => !u.Name.Contains("Hostess")).ToImmutableList();
        }

        internal static ImmutableList<WorkerActor.FellowLite> GetAllChildren(int fellowId)
        {
            var fellows = new List<WorkerActor.FellowLite>();
            var children = GetUnderlings(fellowId);

            foreach (var child in children)
            {
                var grandChildren = GetUnderlings(child.AccountId);

                fellows.Add(new WorkerActor.FellowLite
                {
                    Name = child.Name,
                    Id = child.AccountId,
                    Level = 1,
                    Parent = "Me",
                    GrandParent = string.Empty
                });
                foreach (var grandChild in grandChildren)
                {
                    var greatGrandChildren = GetUnderlings(grandChild.AccountId);

                    fellows.Add(new WorkerActor.FellowLite
                    {
                        Name = grandChild.Name,
                        Id = grandChild.AccountId,
                        Level = 2,
                        Parent = child.Name,
                        GrandParent = "Me"
                    });
                    foreach (var greatGrandChild in greatGrandChildren)
                    {
                        fellows.Add(new WorkerActor.FellowLite
                        {
                            Name = greatGrandChild.Name,
                            Id = greatGrandChild.AccountId,
                            Level = 3,
                            Parent = grandChild.Name,
                            GrandParent = child.Name
                        });
                    }
                }
            }
            return fellows.ToImmutableList();
        }
    }
}