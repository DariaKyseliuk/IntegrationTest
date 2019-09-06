using DAL.Interfaces;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IService<TDto, TEntity> where TEntity: IEntity
    {
        Task<TDto> Get(string id);

        Task<TDto> Add(TDto entityDto);

        Task<TDto> Update(TDto entityDto);

        Task<bool> Delete(string id);
    }
}
