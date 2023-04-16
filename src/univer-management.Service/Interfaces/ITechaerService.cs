using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Interfaces
{
    public interface ITechaerService
    {
        public IEnumerable<OqituvchiViewModel> GetAllTeachers();
        public Task<Oqituvchi> GetById(long id);
        public IEnumerable<Oqituvchi> GetByKeyword(string keyword);
        public Task<(bool, string)> CreateAsync(Oqituvchi entity);
        public Task<(bool, string)> DeleteAsync(long id);
        public Task<Oqituvchi> UpdateAsync(string name, long id);
    }
}
