using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;
using univer_management.Service.Interfaces;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Services
{
    public class FanService : IFanService
    {
        UnitOfWork _work = SingeltonUnitOfWork.Instance;
        public async Task<(bool, string)> CreateAsync(Fan entity,string kafedraName)
        {
            entity.KafedraId = (await _work.Kafedralar.FirstOrDefaultAsync(x=>x.Name== kafedraName))!.Id;
            if (await _work.Fanlar.FirstOrDefaultAsync(x => x.Name == entity.Name) != null)
                return (false, "Bu nomdagi fan allaqachon mavjud");
            _work.Fanlar.Add(entity);
            if (await _work.SaveChangesAsync() != 0)
                return (true, "Fan muvaffaqiyatli saqlandi");
            return (false, "Nimadir xato ketdi, iltimos internet aloqasini tekshiring");
        }

        public async Task<(bool, string)> DeleteAsync(long id)
        {
            if (await _work.Fanlar.FirstOrDefaultAsync(x => x.Id == id) == null)
                return (false, "Bu nomdagi Fan mavjud emas");
            await Task.Run(() => { _work.Fanlar.Delete(id); });
            if (await _work.SaveChangesAsync() != 0) return (true, "Fan muvaffaqiyatli o'chirildi");
            else return (false, "Fan xato ketdi,internet aloqasini tekshiring");
        }

        public IEnumerable<FanViewModel> GetAll()
        {
            return _work.Fanlar.GetAll().Select(x => (FanViewModel)x).ToList();
        }

        public IEnumerable<Fan> GetByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public Task<Fan> UpdateAsync(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
