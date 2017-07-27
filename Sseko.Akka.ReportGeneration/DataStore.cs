using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sseko.Akka.ReportGeneration.Actors;
using Sseko.Data;
using Sseko.Data.Models;

namespace Sseko.Akka.ReportGeneration
{
    public static class DataStore
    {
        private static SsekoContext _dataContext;
        private static List<AffiliateplusTransaction> _aPlusTransactions;
        private static List<AffiliateplusAccount> _accounts;
        private static List<AffiliatepluslevelTier> _underlings;

        public static void Init()
        {
            if (_dataContext == null) _dataContext = ActorSystemRefs.Context;
            if (_aPlusTransactions == null) _aPlusTransactions = _dataContext.AffiliateplusTransaction.ToList();
            if (_accounts == null) _accounts = _dataContext.AffiliateplusAccount.ToList();
            if (_underlings == null) _underlings = _dataContext.AffiliatepluslevelTier.ToList();
        }

        public static void Terminate()
        {
            _aPlusTransactions = null;
            _accounts = null;
            _underlings = null;
        }

        public static List<AffiliateplusTransaction> TransactionsWhere(Func<AffiliateplusTransaction, bool> predicate)
        {
            Init();

            return _aPlusTransactions.Where(predicate).ToList();
        }

        public static List<int> GetHostessIds(int overlordAccountId)
        {
            Init();

            var allUnderlingIds = _underlings.Where(u => u.ToptierId == overlordAccountId).Select(u => u.TierId).ToList();

            return _accounts.Where(a => allUnderlingIds.Contains(a.AccountId) && a.Name.Contains("Hostess")).Select(a => a.AccountId).ToList();
        }

        public static List<AffiliateplusAccount> GetUnderlings(int overlordAccountId, bool includeHostesses = false)
        {
            Init();

            var allUnderlingIds = _underlings.Where(u => u.ToptierId == overlordAccountId).Select(u => u.TierId).ToList();

            var underlings =  _accounts.Where(a => allUnderlingIds.Contains(a.AccountId)).ToList();

            return includeHostesses ? underlings : underlings.Where(u => !u.Name.Contains("Hostess")).ToList();
        }

        public static List<WorkerActor.FellowLite> GetAllChildren(int fellowId)
        {
            var fellows = new List<WorkerActor.FellowLite>();
            var children = GetUnderlings(fellowId);

            foreach (var child in children)
            {
                var grandChildren = DataStore.GetUnderlings(child.AccountId);

                fellows.Add(new WorkerActor.FellowLite
                {
                    Name = child.Name,
                    Id = child.AccountId,
                    Level = 1,
                    Parent = "Me"
                });
                foreach (var grandChild in grandChildren)
                {
                    var greatGrandChildren = DataStore.GetUnderlings(grandChild.AccountId);

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
        }
    }
}
