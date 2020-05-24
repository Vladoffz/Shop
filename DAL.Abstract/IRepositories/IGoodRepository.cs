﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Impl;
using Entities;

namespace DAL.Abstract
{
    public interface IGoodRepository : IGenericRepository<Good>
    {
        void Create(Good good);
    }
}
