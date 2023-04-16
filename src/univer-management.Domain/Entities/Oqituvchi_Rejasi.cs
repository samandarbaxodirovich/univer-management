using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Oqituvchi_Rejasi:BaseEntity
    {
        public long OqituvchiId { get; set; }
        public virtual Oqituvchi Oqituvchi { get; set; } = default!;
        public string DushanbaDars {get; set; } = string.Empty;
        public string SeshanbaDars { get; set; } = string.Empty;
        public string ChorshanbaDars { get; set; } = string.Empty;
        public string PayshanbaDars { get; set; } = string.Empty;
        public string JumaDars { get; set; } = string.Empty;
        public string ShanbaDars { get; set; } = string.Empty;
        public long KafedraId { get; set; }
        public Kafedra Kafedra { get;set; } = default!;
    }
}
