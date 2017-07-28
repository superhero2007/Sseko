using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreVariable
    {
        public CoreVariable()
        {
            CoreVariableValue = new HashSet<CoreVariableValue>();
        }

        public int VariableId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CoreVariableValue> CoreVariableValue { get; set; }
    }
}
