using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Interfaces.Common;
using univer_management.Domain.Common;

namespace univer_management.DataAccess.Repositories.Common
{
    public class GenericRepository<T> : BaseRepository<T>, Interfaces.Common.IGenericRepository<T>
        where T : BaseEntity
    {
        public GenericRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
        public virtual IQueryable<T> GetAll() => _dbSet;

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> expression)
            => _dbSet.Where(expression);
    }
}
