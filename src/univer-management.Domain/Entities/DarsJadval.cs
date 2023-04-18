using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.Domain.Entities
{
    public class DarsJadval:BaseEntity
    {
        public int paraRaqami { get; set; }
        public string Dushanba { get; set; }
        public string sehanba { get; set; }
        public string Chorshanba { get; set; }
        public string payshanba { get; set; }
        public string Juma { get;set; }
    }
}
