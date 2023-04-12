using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer_management.Domain.Entities
{
    public class Oqituvchi_Mutaxasislik
    {
        public long OqituvchiId { get; set; }
        public virtual Oqituvchi Oqituvchi { get; set; } = default!;
        public long MutaxasislikId { get; set; }
        public Mutaxasislik Mutaxasislik { get; set; } = default!;

    }
}
