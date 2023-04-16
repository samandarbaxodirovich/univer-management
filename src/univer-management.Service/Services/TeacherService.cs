﻿using System;
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

        public Task<(bool, string)> DeleteAsync(long id)
        {
            throw new NotImplementedException();
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

        public Task<Oqituvchi> UpdateAsync(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
