using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities;

namespace DAL.Impl
{
    public class TransportRepository : ITransportRepository
    {
        private Context context;

        public TransportRepository(Context context)
        {
            this.context = context;
        }

        public Transport GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Transport> ListEntities()
        {
            return context.Transports.ToList();
        }

        public IList<Transport> ListEntities(Expression<Func<Transport, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}