using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.Repositories.Main;
using univer_management.Domain.Common;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Service.ViewModels
{
    public class YuklamaViewModel : BaseEntity
    {
        public string GuruxNomi { get; set; } = string.Empty;
        public string FanNomi { get;set; } = string.Empty;
        public string OqituvchiIsmi { get; set; } = string.Empty;
        public string Mashgulot { get; set; } = string.Empty;
        public string Haftalar { get; set; } = "#";
        public double HaftalarSoatlar { get; set; }
        public string AuditoriyaIsmi { get; set; } = string.Empty;
        public static implicit operator YuklamaViewModel(Yuklama entity)
        {
            AuditoriyaService service = new();
            FanService fan = new();
            GuruxService gurux = new();
            MashgulotService mashgulot = new();
            OqituvchiRepository rejaService = new(new DataAccess.DbContexts.AppDbContext());
            return new()
            {
                Id = entity.Id,
                HaftalarSoatlar = entity.HaftasigaDars,
                AuditoriyaIsmi = service.GetAll().FirstOrDefault(x=>x.Id == entity.AuditoriyaId)!.NumberOfOrder,
                FanNomi = fan.GetAll().FirstOrDefault(x=>x.Id == entity.FanId)!.Name,
                GuruxNomi = gurux.GetAllBit().FirstOrDefault(x=>x.Id == entity.GuruxId)!.Name,
                Mashgulot = mashgulot.GetAll().FirstOrDefault(x=>x.Id == entity.MashgulotId)!.Name,
                OqituvchiIsmi = rejaService.GetAll().FirstOrDefault(x=>x.Id == entity.OqituvchiId)!.FullName
            };
        
        }
    }
}
