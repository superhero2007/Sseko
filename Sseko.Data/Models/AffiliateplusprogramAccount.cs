using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusprogramAccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime? Joined { get; set; }
        public int ProgramId { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
        public virtual Affiliateplusprogram Program { get; set; }
    }
}
