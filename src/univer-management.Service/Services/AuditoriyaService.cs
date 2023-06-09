﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.DataAccess.Repositories.Main;
using univer_management.Domain.Entities;
using univer_management.Service.Dtos.CreateDtos;
using univer_management.Service.Interfaces;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Services
{
    public class AuditoriyaService : IAuditoriyaService
    {
        private readonly UnitOfWork _work;

        public AuditoriyaService()
        {
            _work = SingeltonUnitOfWork.Instance;
        }

        public async Task<(string, bool)> CreateAsync(AuditoriyaCreateDto dto)
        {
            if (await _work.Auditoriyalar.FirstOrDefaultAsync(x => x.NumberOfOrder == dto.NumberOfOrder) != null)
                return ("Bu tartib sonli auditoriya allaqachon mavjud", false);
            _work.Auditoriyalar.Add(new Auditoriya() 
            {
                Auditoriya_TipiId = (await _work.AuditoriyaTiplari.FirstOrDefaultAsync(x=>x.Type == dto.AuditoriyaTipi))!.Id,
                Capacity = dto.Capacity,
                Korpus= dto.Korpus,
                NumberOfOrder = dto.NumberOfOrder
            });
            if (await _work.SaveChangesAsync() != 0) return ("Auditoriya muvaffaqiyatli saqlandi", true);
            return ("Nimadir xato ketdi,internet aloqasini tekshiring", false);
        }

        public async Task<IEnumerable<AuditoriyaViewModel>> GetAllAsync()
        {
            var result = await _work.Auditoriyalar.GetAll().ToListAsync();
            return result.Select(x => (AuditoriyaViewModel)x).ToList();
        }

        public async Task<AuditoriyaViewModel> GetAsync(long id)
        {
            var result = await _work.Auditoriyalar.FirstOrDefaultAsync(x=>x.Id == id);
            return (AuditoriyaViewModel)result!;
        }

        public async Task<(string, bool)> UpdateAsync(long id, Auditoriya entity)
        {
            var result = await _work.Auditoriyalar.FindByIdAsync(id);
            if (result != null)
            {
                result.Auditoriya_TipiId = entity.Auditoriya_TipiId;
                result.NumberOfOrder = entity.NumberOfOrder;
                result.Capacity = entity.Capacity;
                result.Korpus = entity.Korpus;
            }
            else
                return ("Bunaqa Auditoriya mavjud emas", false);
            if (await _work.SaveChangesAsync() != 0) return ("Auditoriya muvaffaqiyatli o'zgartirildi", true);
            return ("Nimadir xato ketdi,internet aloqasini tekshiring",false);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            await Task.Run(() => { _work.Auditoriyalar.Delete(id); });
            if(await _work.SaveChangesAsync() != 0) return true;
            return false;
        }
        public IEnumerable<string> GetAllTypes()
        {
            return _work.AuditoriyaTiplari.GetAll()
                .Select(x => x.Type).ToList();
        }
        public IEnumerable<Auditoriya> GetAll()
        {
            return _work.Auditoriyalar.GetAll().ToList();
        }

        public IEnumerable<AuditoriyaViewModel> GetByKeyword(string keyword)
        {
            var types = TypeHelper(keyword);
            var stepone = _work.Auditoriyalar.Where(x => x.NumberOfOrder.ToLower().Contains(keyword.ToLower()) || types.Contains(x.Auditoriya_TipiId)).ToList();
            return stepone.Select(x=>(AuditoriyaViewModel)x).ToList();
        }
       
        private List<long> TypeHelper(string keyword)
        {
            return _work.AuditoriyaTiplari.Where(x => x.Type.ToLower().Contains(keyword.ToLower())).Select(x=>x.Id).ToList();
        }
    }
}
