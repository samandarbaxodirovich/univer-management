using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Gurux:Auditable
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfSemester { get; set; }
        public int Smena { get; set; }
        public int Capacity { get; set; }
        public long AuditoriyaId { get; set; }
        public virtual Auditoriya Auditoriya { get; set; } = default!;
        public long MutaxasislikId { get; set; }
        public virtual Mutaxasislik Mutaxasislik { get; set; } = default!;
        public int Semestr { get; set; }

    }
}
