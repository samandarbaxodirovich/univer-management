using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Common;

namespace univer_management.DataAccess.Interfaces.Common
{
    public interface IGenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> GetAll();

        public IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
