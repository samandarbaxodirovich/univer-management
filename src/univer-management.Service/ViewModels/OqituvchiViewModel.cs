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
    public class OqituvchiViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Level { get; set; }
        public string Kafedra { get; set; } = string.Empty;
        public static implicit operator OqituvchiViewModel(Oqituvchi model)
        {
            return new()
            {
                FullName = model.FullName,
                Level = model.Level,
                Id = model.Id,
                Kafedra = new UnitOfWork(new AppDbContext()).Kafedralar.Where(x => x.Id == model.KafedraId).FirstOrDefault()!.Name
            };
        }
    }
}
