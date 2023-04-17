using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.DataAccess.Repositories.Main;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Service.ViewModels
{
    public class OquvRejaViewModel
    {
        public long Id { get; set; }
        public string FanName { get; set; } = string.Empty;
        public double Lektsiya { get; set; }
        public double Seminar { get; set; }
        public double Labaratoriya { get; set; }
        public double Zachot { get; set; }
        public double DefZachot { get; set; }
        public double Imtihon { get; set; }
        public static implicit operator OquvRejaViewModel(Oquv_Reja reja)
        {
            FanService fan = new();
            UnitOfWork _work = SingeltonUnitOfWork.Instance;
            return new()
            {
                Id = reja.Id,
                FanName = fan.GetAll().FirstOrDefault(x => x.Id == reja.FanId)!.Name,
                Lektsiya = _work.OquvRejaMashgulotlar.GetAll().Where(x => x.OquvRejaId == reja.Id && x.MashgulotId == 1).FirstOrDefault()!.MashgulotLength,
                Seminar = _work.OquvRejaMashgulotlar.GetAll().Where(x => x.OquvRejaId == reja.Id && x.MashgulotId == 2).FirstOrDefault()!.MashgulotLength,
                Labaratoriya = _work.OquvRejaMashgulotlar.GetAll().Where(x => x.OquvRejaId == reja.Id && x.MashgulotId == 3).FirstOrDefault()!.MashgulotLength,
                Zachot = _work.OquvRejaMashgulotlar.GetAll().Where(x => x.OquvRejaId == reja.Id && x.MashgulotId == 4).FirstOrDefault()!.MashgulotLength,
                DefZachot = _work.OquvRejaMashgulotlar.GetAll().Where(x => x.OquvRejaId == reja.Id && x.MashgulotId == 5).FirstOrDefault()!.MashgulotLength,
                Imtihon = _work.OquvRejaMashgulotlar.GetAll().Where(x => x.OquvRejaId == reja.Id && x.MashgulotId == 6).FirstOrDefault()!.MashgulotLength
            };
        }

    }
}