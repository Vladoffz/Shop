using DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Impl
{
    public class BaseRepository
    {
        protected Context context;

        public BaseRepository(Context context)
        {
          this.context = context;
        }
    }
}
