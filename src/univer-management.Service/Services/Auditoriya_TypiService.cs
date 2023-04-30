using Microsoft.EntityFrameworkCore;
using System;
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
    public class Auditoriya_TypiService : IAuditoriya_Tipi
    {
        private readonly UnitOfWork _work;

        public Auditoriya_TypiService()
        {
            _work = SingeltonUnitOfWork.Instance;
        }
        public async Task<IEnumerable<Domain.Entities.Auditoriya_Tipi>> GetAllAsync()
        {
            var result = await _work.AuditoriyaTiplari.GetAll().ToListAsync();
            return result;
        }

        public Task<Domain.Entities.Auditoriya_Tipi> GetAsync(long id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> Create(Auditoriya_Tipi auditoriya_Tipi)
        {
            _work.AuditoriyaTiplari.Add(auditoriya_Tipi);
            if((await _work.SaveChangesAsync())!= 0)
            {
                return true;
            }
            return false;
        }
    }
}
