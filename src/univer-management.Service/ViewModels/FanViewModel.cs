using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;

namespace univer_management.Service.ViewModels
{
    public class FanViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string KafedraName { get; set; } = string.Empty;
        public double Level { get; set; }
        public static implicit operator FanViewModel(Fan entity)
        {
            UnitOfWork _work = SingeltonUnitOfWork.Instance;
            return new FanViewModel()
            {
                Id= entity.Id,
                Name= entity.Name,
                KafedraName = _work.Kafedralar.GetAll().Where(x => x.Id == entity.KafedraId).First().Name,
                Level = entity.Level
            };
        }
    }
}
