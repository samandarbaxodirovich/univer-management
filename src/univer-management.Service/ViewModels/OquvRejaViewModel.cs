using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer_management.Service.ViewModels
{
    public class OquvRejaViewModel
    {
        public int Id { get; set; }
        public string FanName { get; set; } = string.Empty;
        public double Lektsiya { get; set; }
        public double Seminar { get; set; }
        public double Labaratoriya { get; set; }
        public double Zachot { get; set; }
        public double DefZachot { get; set; }
        public double Imtihon { get; set; }

    }
}