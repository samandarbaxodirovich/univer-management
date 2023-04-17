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
    public class YuklamaService : IYuklamalarService
    {
        UnitOfWork _work = SingeltonUnitOfWork.Instance;

        public async Task<(bool, string)> CreateAsync(Yuklama entity)
        {
            if (await _work.Yuklamalar.FirstOrDefaultAsync(x => x.GuruxId == entity.GuruxId && x.FanId==entity.FanId 
            && x.OqituvchiId==entity.OqituvchiId && x.MashgulotId==entity.MashgulotId) != null)
            {
                return (false, "Bu nomdagi O'qituvchi allaqachon mavjud");
            }
            _work.Yuklamalar.Add(entity);
            if (await _work.SaveChangesAsync() != 0)
            {
                return (true, " Muvaffaqiyatli qo'shildi");
            }
            else
            {
                return (false, "Nimadir xato ketdi,internet bilan aloqani tekshiring");
            }
        }

        public Task<(bool, string)> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<YuklamaViewModel> GetAll()
        {
            return _work.Yuklamalar.GetAll().Select(x=>(YuklamaViewModel)x).ToList();
        }

        public Task<Yuklama> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Yuklama> GetByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public Task<Yuklama> UpdateAsync(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
