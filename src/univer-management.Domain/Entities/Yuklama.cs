using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Yuklama:Auditable
    {
        public long GuruxId { get; set; }
        public virtual Gurux Gurux { get; set; } = default!;
        public long FanId { get; set; }
        public virtual Fan Fan { get;set; } = default!;
        public long OqituvchiId { get; set; }
        public Oqituvchi Oqituvchi { get; set; } = default!;
        public long Oquv_RejaId { get; set; }
        public virtual Oquv_Reja Oquv_Reja { get; set; } = default!;
        public long AuditoriyaId { get; set; }
        public virtual Auditoriya Auditoriya { get; set; } = default!;
        public double HaftasigaDars { get; set; }
        public long MashgulotId { get; set; }
        public virtual Mashgulot Mashgulot { get; set; } = default!;
    }
}
