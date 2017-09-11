using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sseko.Akka.DataService.Magento.Entities
{
    internal class FellowLite
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public string Grandparent { get; set; }
    }
}
