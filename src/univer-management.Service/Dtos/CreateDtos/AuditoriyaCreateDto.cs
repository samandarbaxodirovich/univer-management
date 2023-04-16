using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.Service.Dtos.CreateDtos
{
    public class AuditoriyaCreateDto
    {
        public string NumberOfOrder { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string AuditoriyaTipi { get; set; }
        public string Korpus { get; set; } = string.Empty;
    }
}
