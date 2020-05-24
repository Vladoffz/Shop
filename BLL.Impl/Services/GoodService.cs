using BLL.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DAL.Impl;

namespace BLL.Impl
{
    public class GoodService : IGoodService
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        GoodMapper mapper = new GoodMapper();

        public void Create(GoodDTO goodDTO)
        {
            unitOfWork.GoodRepository.Create(mapper.GoodDTOToGood(goodDTO));
            unitOfWork.Save();
        }

        public GoodDTO GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IList<GoodDTO> ListEntities()
        {
            List<GoodDTO> list = new List<GoodDTO>();
            foreach (var i in unitOfWork.GoodRepository.ListEntities())
            {
                list.Add(mapper.GoodToGoodDTO(i));
            }

            return list;
        }

        public IList<GoodDTO> ListEntities(Expression<Func<GoodDTO, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}