using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaComment
    {
        public int CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? EmailId { get; set; }
        public bool IsCustomerNotified { get; set; }
        public bool IsHtml { get; set; }
        public bool IsRead { get; set; }
        public bool IsVisibleInFrontend { get; set; }
        public int RmaId { get; set; }
        public int? StatusId { get; set; }
        public string Text { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? UserId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual MRmaRma Rma { get; set; }
        public virtual MRmaStatus Status { get; set; }
        public virtual AdminUser User { get; set; }
    }
}
