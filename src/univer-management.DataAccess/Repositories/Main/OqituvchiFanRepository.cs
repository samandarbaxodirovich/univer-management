using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Interfaces.Common;
using univer_management.DataAccess.Interfaces.Main;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;

namespace univer_management.DataAccess.Repositories.Main
{
    public class OqituvchiFanRepository : GenericRepository<Oqituvchi_Fan>, IOqituvchiFanRepository
    {
        public OqituvchiFanRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
