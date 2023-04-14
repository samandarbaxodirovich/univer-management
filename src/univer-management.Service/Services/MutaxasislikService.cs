using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;
using univer_management.Service.Interfaces;

namespace univer_management.Service.Services
{
    public class MutaxasislikService : IMutaxasislikService
    {
        UnitOfWork _work = SingeltonUnitOfWork.Instance;

        public async Task<(bool,string)> CreateAsync(Mutaxasislik entity)
        {
            if (await _work.Mutaxasisliklar.FirstOrDefaultAsync(x => x.Name == entity.Name) != null)
                return (false, "Bu nomdagi mutaxasislik allaqachon mavjud");
            _work.Mutaxasisliklar.Add(entity);
            if (await _work.SaveChangesAsync() != 0) return (true,"Mutaxasislik muvaffaqiyatli qo'shildi");
            return (false,"Nimadir xato ketdi,internet bilan aloqani tekshiring");
        }

        public async Task<(bool, string)> DeleteAsync(long id)
        {
            if (await _work.Mutaxasisliklar.FirstOrDefaultAsync(x => x.Id == id) == null)
                return (false, "Bu nomdagi mutaxasislik mavjud emas");
            await Task.Run(() => { _work.Mutaxasisliklar.Delete(id); });
            if (await _work.SaveChangesAsync() != 0) return (true, "Mutaxasislik muvaffaqiyatli o'chirildi");
            else return (false, "Nimadir xato ketdi,internet aloqasini tekshiring");
        }

        public IEnumerable<Mutaxasislik> GetAll()
        {
            var targets = _work.Mutaxasisliklar.GetAll().ToList();
            return targets;
        }

        public async Task<Mutaxasislik> GetById(long id)
        {
            var result = await _work.Mutaxasisliklar.FirstOrDefaultAsync(_ => _.Id == id);
            return result!;
            
        }

        public IEnumerable<Mutaxasislik> GetByKeyword(string keyword)
        {
            return _work.Mutaxasisliklar.Where(x => x.Name.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}
