using DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Impl
{
    public class GoodRepository : IGoodRepository
    {
        private Context context;
        public GoodRepository(Context context)
        {
            this.context = context;
        }

        public void Create(Good good)
        {
            context.Goods.Add(good);
        }

        public Good GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Good> ListEntities()
        {
            return context.Goods.ToList();
        }

        public IList<Good> ListEntities(Expression<Func<Good, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}