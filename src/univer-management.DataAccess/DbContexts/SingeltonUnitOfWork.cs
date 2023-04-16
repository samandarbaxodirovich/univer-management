using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.Repositories.Common;

namespace univer_management.DataAccess.DbContexts
{
    public sealed class SingeltonUnitOfWork
    {
        public SingeltonUnitOfWork() { }
        private static UnitOfWork _work = new UnitOfWork(new AppDbContext());

        public static UnitOfWork Instance
        {
            get { return _work; }
        }
    }
}
