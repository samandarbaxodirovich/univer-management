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
    public class TeacherService : ITechaerService
    {
		UnitOfWork _work = SingeltonUnitOfWork.Instance;

        public async Task<(bool, string)> CreateAsync(Oqituvchi entity)
        {
            if (await _work.Oqituvchilar.FirstOrDefaultAsync(x => x.FullName == entity.FullName) != null)
            {
                return (false, "Bu nomdagi O'qituvchi allaqachon mavjud");
            }
            _work.Oqituvchilar.Add(entity);
            if (await _work.SaveChangesAsync() != 0)
            {
                return (true, "O'qituvchi muvaffaqiyatli qo'shildi");
            }
            else
            {
                return (false, "Nimadir xato ketdi,internet bilan aloqani tekshiring");
            }
        }

        public async Task<(bool, string)> DeleteAsync(long id)
        {
            if (await _work.Oqituvchilar.FirstOrDefaultAsync(x => x.Id == id) == null)
                return (false, "Bu nomdagi O'qituvchi mavjud emas");
            await Task.Run(() => { _work.Oqituvchilar.Delete(id); });
            if (await _work.SaveChangesAsync() != 0) return (true, "O'qituvchi muvaffaqiyatli o'chirildi");
            else return (false, "Nimadir xato ketdi,internet aloqasini tekshiring");
        }

        public IEnumerable<OqituvchiViewModel> GetAllTeachers()
        {
            var teachers = _work.Oqituvchilar.GetAll().Select(x=>(OqituvchiViewModel)x).ToList();
            if (teachers != null) return teachers;
            else return new List<OqituvchiViewModel>();
        }

        public Task<Oqituvchi> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Oqituvchi> GetByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public async Task<(string, bool)> UpdateAsync(Oqituvchi entity, long id)
        {
            var res = await _work.Oqituvchilar.FindByIdAsync(id);
            if (res != null)
            {
                res.KafedraId = entity.KafedraId;
                res.FullName = entity.FullName;
                res.Level = entity.Level;
                if (await _work.SaveChangesAsync() != 0)
                {
                    return ("O'qituvchi muvaffaqiyatli o'zgartirildi", true);
                }
                return ("O'qituvchi xato ketti internet aloqasini tekshiring", false);
            }
            return ("O'qituvchi kafedra topilmadi", false);
        }
    }
}
