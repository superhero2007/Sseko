using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sseko.DAL.DocumentDb.Models
{
    public class PasswordResetDetails
    {
        public PasswordResetDetails()
        {
            Code = Guid.NewGuid().ToString();
            Expiration = DateTime.UtcNow.AddMinutes(30);
        }
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
