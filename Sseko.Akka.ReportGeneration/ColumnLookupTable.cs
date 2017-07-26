using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sseko.Data;
using Sseko.Data.Models;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.Akka.ReportGeneration
{
    public static class ColumnLookupTable
    {
        private static SsekoContext _dataContext;
        private static List<AffiliateplusTransaction> _transactions;
        private static List<AffiliateplusAccount> _fellows;

        public static void Init()
        {
            if (_dataContext == null) _dataContext = ActorSystemRefs.Context;
            if (_transactions == null) _transactions = _dataContext.AffiliateplusTransaction.ToList();
            if (_fellows == null) _fellows =  _dataContext.AffiliateplusAccount.ToList();

        }

        public static Func<List<string>> ColumnKeyFetcher(ColumnKeyType columnKey)
        {
            Init();

            switch (columnKey)
            {
                case ColumnKeyType.Fellow:
                    return () => _fellows.Select(f => f.ReferredBy).ToList();
                default:
                    throw new ArgumentException("Invalid column key!");
            }
        }
        public static Func<string, string> ColumnFetcher(ColumnType column)
        {
            Init();

            switch (column)
            {
                default:
                    throw new ArgumentException("Invalid column");
            }
        }
    }
}
