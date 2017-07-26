using System;
using System.Collections.Generic;
using System.Text;
using Sseko.DAL.DocumentDb.Base;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.DAL.DocumentDb.Entities
{
    public class ReportType : DocumentBase
    {
        public ReportType() : base(DocumentType.ReportType)
        {
            
        }

        public List<Column> Columns { get; set; } = new List<Column>();
    }
}
