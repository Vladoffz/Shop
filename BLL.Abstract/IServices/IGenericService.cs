using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BLL.Abstract
{
    public interface IGenericService<T>
    {
        T GetEntity(int id);
        IList<T> ListEntities();
        IList<T> ListEntities(Expression<Func<T, bool>> expression);
    }
}