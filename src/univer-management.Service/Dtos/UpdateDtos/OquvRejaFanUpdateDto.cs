using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer_management.Service.Dtos.UpdateDtos
{
    public class OquvRejaFanUpdateDto
    {
        public long OquvRejaId { get; set; }
        public double Lektsiya { get; set; } = 0;
        public double Seminar { get; set; } = 0;
        public double MustaqilTalim { get; set; } = 0;
        public double Imtihon { get; set; } = 0;
        public int HaftalarSoni { get; set; }
        public double UmumiyDarsSoati { get; set; }
    }
}
