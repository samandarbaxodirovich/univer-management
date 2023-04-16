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
    public class MashgulotService : IMashgulot
    {
        UnitOfWork _work = SingeltonUnitOfWork.Instance;

        public async Task<(bool, string)> CreateAsync(Mashgulot entity)
        {
            if (await _work.Mashgulotlar.FirstOrDefaultAsync(x => x.Name == entity.Name) != null)
                return (false, "Bu nomdagi mashgu'ulot allaqachon mavjud");
            _work.Mashgulotlar.Add(entity);
            if (await _work.SaveChangesAsync() != 0) return (true, "Mashg'ulot muvaffaqiyatli qo'shildi");
            return (false, "Nimadir xato ketdi,internet bilan aloqani tekshiring");
        }

        public Task<(bool, string)> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Entities.Mashgulot> GetAll()
        {
            var targets = _work.Mashgulotlar.GetAll().ToList();
            return targets;
        }

        public Task<Domain.Entities.Mashgulot> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Entities.Mashgulot> GetByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Mashgulot> UpdateAsync(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
