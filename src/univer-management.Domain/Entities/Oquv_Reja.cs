using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Oquv_Reja : Auditable
    {
        public long FanId { get; set; }
        public virtual Fan Fan { get; set; } = default!;
        public string TextUquvReja { get; set; } = string.Empty;
        public long MutaxasislikId { get; set; }
        public virtual Mutaxasislik Mutaxasislik { get; set; } = default!;
        public int Semestr { get; set; }
    }
}
