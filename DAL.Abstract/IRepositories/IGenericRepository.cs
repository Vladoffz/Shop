using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl
{
    public interface IGenericRepository<T> where T : class
    {
        T GetEntity(int id);
        IList<T> ListEntities();
        IList<T> ListEntities(Expression<Func<T, bool>> expression);

    }
}
