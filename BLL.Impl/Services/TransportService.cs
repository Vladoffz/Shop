using BLL.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DAL.Impl;

namespace BLL.Impl
{
    public class TransportService : ITransportService
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        TransportMapper mapper = new TransportMapper();
        public TransportDTO GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TransportDTO> ListEntities()
        {
            List<TransportDTO> list = new List<TransportDTO>();
            foreach (var i in unitOfWork.TransportRepository.ListEntities())
            {
                list.Add(mapper.TransportToTransportDTO(i));
            }

            return list;
        }

        public IList<TransportDTO> ListEntities(Expression<Func<TransportDTO, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}