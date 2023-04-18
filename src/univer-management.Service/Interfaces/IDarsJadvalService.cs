using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.DataAccess.Repositories.Main;
using univer_management.Domain.Entities;

namespace univer_management.Service.Interfaces
{
    public class IDarsJadvalService
    {
        UnitOfWork unitOfWork = SingeltonUnitOfWork.Instance;
        public async Task<bool> CreateAsync(DarsJadval dars)
        {
            unitOfWork.DarsJadvallari.Add(dars);
            if(await unitOfWork.SaveChangesAsync() != 0)
                return true;
            return false;
        }
    }
}
