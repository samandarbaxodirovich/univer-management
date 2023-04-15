using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Auditoriya:BaseEntity
    {
        public string NumberOfOrder { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public long AuditoriyaTipiId { get; set; }
        public virtual Auditoriya_Tipi AuditoriyaTipi { get; set; } = default!;
        public string Korpus = string.Empty;
    }
}
