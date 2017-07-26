using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Microsoft.EntityFrameworkCore;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.Data;
using Sseko.Data.Models;

namespace Sseko.Akka.ReportGeneration.Actors
{
    public class WorkerActor : ReceiveActor, ILogReceive
    {
        public WorkerActor()
        {
            Receive<ReportGenerationOperations.Operation>(message =>
            {
                var columns = message.ReportType.Columns;
                //if (!ColumnLookupTable.ValidateColumns(columns))
                //{
                //    throw new InvalidOperationException("Column layout not valid!");
                //}
                var columnKey = columns[0].ColumnKeyType;
                var columnKeyFetcher = ColumnLookupTable.ColumnKeyFetcher(columnKey);

                var columnKeyResults = columnKeyFetcher();

                var rows = columnKeyResults.Select(result => new List<string>
                    {
                        result
                    })
                    .ToList();
                foreach (var column in columns.Skip(1))
                {
                    var columnFetcher = ColumnLookupTable.ColumnFetcher(column.ColumnType);
                    foreach (var row in rows)
                    {
                        var rowKey = row[0];
                        row.Add(columnFetcher(rowKey));
                    }
                }
                Sender.Tell(rows);
            });
        }


    }
}
