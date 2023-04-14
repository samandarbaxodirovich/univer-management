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
        public IEnumerable<Mutaxasislik> GetAll();
        public IEnumerable<Mutaxasislik> GetByKeyword(string keyword);
        public Task<(bool,string)> CreateAsync(Mutaxasislik entity);
    }
}
