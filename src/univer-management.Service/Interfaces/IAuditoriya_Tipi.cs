using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Interfaces
{
    public interface IAuditoriya_Tipi
    {
        public Task<Auditoriya_Tipi> GetAsync(long id);
        public Task<IEnumerable<Auditoriya_Tipi>> GetAllAsync();

    }
}
