using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Oqituvchi:Auditable
    {
        public string FullName { get; set; } = string.Empty;
        public string Level { get; set; } 
        public long KafedraId { get; set; }
        public virtual Kafedra Kafedra { get; set; } = default!;
    }
}
