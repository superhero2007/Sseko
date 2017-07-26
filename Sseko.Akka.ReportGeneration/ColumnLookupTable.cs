using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sseko.Data;
using Sseko.Data.Models;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.Akka.ReportGeneration
{
    public static class ColumnLookupTable
    {
        private static SsekoContext _dataContext;
        private static List<AffiliateplusTransaction> _transactions;
        private static List<AffiliateplusAccount> _fellows;

        private static async void Init()
        {
            try
            {
                if (_dataContext == null) _dataContext = new SsekoContext();
                if (_transactions == null) _transactions = (await _dataContext.AffiliateplusTransaction.ToListAsync()).ToList();
                if (_fellows == null) _fellows = (await _dataContext.AffiliateplusAccount.ToListAsync()).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static Func<List<string>> ColumnKeyFetcher(string columnKey)
        {
            Init();

            switch (columnKey)
            {
                case "fellows":
                    return () => _fellows.Select(f => f.ReferredBy).ToList();
                default:
                    throw new ArgumentException("Invalid column key!");
            }
        }
        public static Func<string, string> ColumnFetcher(string column)
        {
            Init();

            switch (column)
            {
                case "sales":
                    return (ck) => _transactions.Where(t => t.Account.Name == ck).Sum(t => t.TotalAmount).ToString();
                default:
                    throw new ArgumentException("Invalid column");
            }
        }

        public static bool ValidateColumns(List<Column> columns)
        {
            throw new NotImplementedException();
        }
    }
}
