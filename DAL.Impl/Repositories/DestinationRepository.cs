using DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Impl
{
    public class DestinationRepository : IDestinationRepository
    {
        private Context context;

        public DestinationRepository(Context context)
        {
            this.context = context;
        }
        public Destination GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Destination> ListEntities()
        {
            return context.Destinations.ToList();
        }

        public IList<Destination> ListEntities(Expression<Func<Destination, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}