using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Oquv_Reja_Mashgulot:BaseEntity
    {
        public long OquvRejaId { get; set; }
        public virtual Oquv_Reja Oquv_Reja { get; set; } = default!;
        public long MashgulotId { get; set; }
        public virtual Mashgulot Mashgulot { get; set; } = default!;
    }
}
