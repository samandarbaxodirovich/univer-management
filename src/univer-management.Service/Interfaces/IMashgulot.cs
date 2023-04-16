using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.Service.Interfaces
{
    public interface IMashgulot
    {
        public Task<Mashgulot> GetById(long id);
        public IEnumerable<Mashgulot> GetAll();
        public IEnumerable<Mashgulot> GetByKeyword(string keyword);
        public Task<(bool, string)> CreateAsync(Mashgulot entity);
        public Task<(bool, string)> DeleteAsync(long id);
        public Task<Mashgulot> UpdateAsync(string name, long id);
    }
}
