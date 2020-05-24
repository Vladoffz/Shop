using Models;

namespace BLL.Abstract
{
    public interface IGoodService:IGenericService<GoodDTO>
    {
        void Create(GoodDTO goodDTO);
    }
}