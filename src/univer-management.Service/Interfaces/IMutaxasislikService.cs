using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.Service.Interfaces
{
    public interface IMutaxasislikService
    {
        public Task<Mutaxasislik> GetById(long id);
        public IEnumerable<Mutaxasislik> GetAll();
        public IEnumerable<Mutaxasislik> GetByKeyword(string keyword);
        public Task<(bool,string)> CreateAsync(Mutaxasislik entity);
        public Task<(bool, string)> DeleteAsync(long id);
        public Task<Mutaxasislik> UpdateAsync(Mutaxasislik mutahassis, long id);

	}
}
