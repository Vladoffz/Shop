using System.Linq;
using DAL.Impl;
using Entities;
using Models;

namespace BLL.Impl
{
    public class GoodMapper
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public GoodDTO GoodToGoodDTO(Good Good)
        {
            return new GoodDTO { Height = Good.Height, id = Good.id, Name = Good.Name, Weight = Good.Weight, Width = Good.Width };
        }

        public Good GoodDTOToGood(GoodDTO GoodDTO)
        {
            return new Good{Height = GoodDTO.Height, Name = GoodDTO.Name, Weight = GoodDTO.Weight, Width = GoodDTO.Width};
        }
    }
}