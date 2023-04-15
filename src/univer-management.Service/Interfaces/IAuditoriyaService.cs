using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Interfaces
{
    public interface IAuditoriyaService
    {
        public Task<IEnumerable<AuditoriyaViewModel>> GetAllAsync();
        public Task<AuditoriyaViewModel> GetAsync(long id);
        public Task<bool> DeleteAsync(long id);
        public Task<(string,bool)> UpdateAsync(long id,Auditoriya entity);

    }
}
