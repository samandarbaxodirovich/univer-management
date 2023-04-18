using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Interfaces.Main;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;
using univer_management.Service.Interfaces;

namespace univer_management.Service.Services
{
	public class KafedraService : IKafedraService
	{
		UnitOfWork _work = SingeltonUnitOfWork.Instance;

		public async Task<(bool, string)> CreateAsync(Kafedra entity)
		{
			if (await _work.Kafedralar.FirstOrDefaultAsync(x => x.Name == entity.Name) != null)
			{
				return (false, "Bu nomdagi kafedra allaqachon mavjud");
			}
			_work.Kafedralar.Add(entity);
			if (await _work.SaveChangesAsync() != 0)
			{
				return (true, "Kafedra muvaffaqiyatli qo'shildi");
			}
			else
			{
				return (false, "Nimadir xato ketdi,internet bilan aloqani tekshiring");
			}
		}

		public async Task<(bool, string)> DeleteAsync(long id)
		{
			if (await _work.Kafedralar.FirstOrDefaultAsync(x => x.Id == id) == null)
				return (false, "Bu nomdagi kafedra mavjud emas");
			await Task.Run(() => { _work.Kafedralar.Delete(id); });
			if (await _work.SaveChangesAsync() != 0) return (true, "kafedra muvaffaqiyatli o'chirildi");
			else return (false, "Nimadir xato ketdi,internet aloqasini tekshiring");
		}

		public async Task<IEnumerable<Kafedra>> GetAll()
		{
			var targets = await _work.Kafedralar.GetAll().Include(x => x.Mutaxasislik).OrderByDescending(x => x.Id).ToListAsync();
			return targets;
		}

		public Task<Kafedra> GetById(long id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Kafedra> GetByKeyword(string keyword)
		{
			throw new NotImplementedException();
		}

        public async Task<(string, bool)> UpdateAsync(Kafedra entity, long id)
        {
            var res = await _work.Kafedralar.FindByIdAsync(id);
            if (res != null)
            {
                res.MutaxasislikId = entity.MutaxasislikId;
                res.Name = entity.Name;
                if (await _work.SaveChangesAsync() != 0)
                {
                    return ("Kafedra muvaffaqiyatli o'zgartirildi", true);
                }
                return ("Nimadir xato ketti internet aloqasini tekshiring", false);
            }
            return ("Bunaqa kafedra topilmadi", false);
        }
    }
}
