using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;

namespace univer_management.Service.ViewModels
{
    public class AuditoriyaViewModel
    {
        public long Id { get; set; }
        public string NumberOfOrder { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string AuditoriyaTipi { get; set; } = string.Empty;

        public string Korpus = string.Empty;

        public static implicit operator AuditoriyaViewModel(Auditoriya model)
        {
            var _work = SingeltonUnitOfWork.Instance;
            return new()
            {
                Id = model.Id,
                NumberOfOrder = model.NumberOfOrder,
                Capacity = model.Capacity,
                Korpus = model.Korpus,
                AuditoriyaTipi = _work.AuditoriyaTiplari.GetAll().Where(x=>x.Id == model.AuditoriyaTipiId).First().Type
            };
        }
    }
}
