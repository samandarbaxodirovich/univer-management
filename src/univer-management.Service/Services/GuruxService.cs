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
using univer_management.Service.ViewModels;

namespace univer_management.Service.Services
{
	public class GuruxService : IGuruxService
	{
		private readonly UnitOfWork _work;

		public GuruxService()
		{
			_work = SingeltonUnitOfWork.Instance;
		}

		public async Task<(bool, string)> CreateAsync(Gurux entity)
		{
			if (await _work.Guruxlar.FirstOrDefaultAsync(x => x.Name == entity.Name) != null)
			{
				return (false, "Bu nomdagi Gurux allaqachon mavjud");
			}
			_work.Guruxlar.Add(entity);
			if (await _work.SaveChangesAsync() != 0)
			{
				return (true, "Gurux muvaffaqiyatli qo'shildi");
			}
			else
			{
				return (false, "Nimadir xato ketdi,internet bilan aloqani tekshiring");
			}
		}

		public async Task<(bool, string)> DeleteAsync(long id)
		{
            if (await _work.Guruxlar.FirstOrDefaultAsync(x => x.Id == id) == null)
                return (false, "Bu nomdagi Guruh mavjud emas");
            await Task.Run(() => { _work.Guruxlar.Delete(id); });
            if (await _work.SaveChangesAsync() != 0) return (true, "Guruh muvaffaqiyatli o'chirildi");
            else return (false, "Guruh xato ketdi,internet aloqasini tekshiring");
        }

		public async Task<IEnumerable<Gurux>> GetAll()
		{
			var targets = await _work.Guruxlar.GetAll().Include(x => x.Mutaxasislik).Include(x => x.Auditoriya).OrderByDescending(x => x.Id).ToListAsync();
			return targets;
		}

		public Task<Gurux> GetById(long id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Gurux> GetByKeyword(string keyword)
		{
			throw new NotImplementedException();
		}

		public async Task<(bool, string)> UpdateAsync(long id, Gurux entity)
		{
            var result = await _work.Guruxlar.FindByIdAsync(id);
            if (result != null)
            {
                result.Name = entity.Name;
                result.Capacity = entity.Capacity;
                result.AuditoriyaId = entity.AuditoriyaId;
                result.MutaxasislikId = entity.MutaxasislikId;
            }
            else
                return (false,"Bunaqa Guruh mavjud emas");
            if (await _work.SaveChangesAsync() != 0) return (true,"Guruh muvaffaqiyatli o'zgartirildi");
            return (false, "Nimadir xato ketdi,internet aloqasini tekshiring");
        }
		public IEnumerable<Gurux> GetAllBit()
		{
            return _work.Guruxlar.GetAll().Include(x => x.Mutaxasislik).Include(x => x.Auditoriya).OrderByDescending(x => x.Id).ToList();

        }
    }
}
