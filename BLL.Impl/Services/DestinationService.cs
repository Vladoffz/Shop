using BLL.Abstract;
using Models;
using System;
using System.Collections.Generic;

using System.Linq.Expressions;
using DAL.Impl;


namespace BLL.Impl
{
    public class DestinationService : IDestinationService
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        DestinationMapper mapper = new DestinationMapper();
        public DestinationDTO GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DestinationDTO> ListEntities()
        {
            List<DestinationDTO> list = new List<DestinationDTO>();
            foreach (var i in unitOfWork.DestinationRepository.ListEntities())
            {
                list.Add(mapper.DestinationToDestinationDTO(i));
            }

            return list;
        }

        public IList<DestinationDTO> ListEntities(Expression<Func<DestinationDTO, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}