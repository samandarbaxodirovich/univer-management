using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.Service.Interfaces
{
    public interface IYuklamalarService
    {
        public Task<Yuklama> GetById(long id);
        public IEnumerable<Yuklama> GetAll();
        public IEnumerable<Yuklama> GetByKeyword(string keyword);
        public Task<(bool, string)> CreateAsync(Yuklama entity);
        public Task<(bool, string)> DeleteAsync(long id);
        public Task<Yuklama> UpdateAsync(string name, long id);
    }
}
