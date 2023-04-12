using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class Auditoriya_Tipi:BaseEntity
    {
        public string Type { get; set; } = string.Empty;
    }
}
