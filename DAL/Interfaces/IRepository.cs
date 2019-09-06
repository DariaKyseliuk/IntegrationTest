using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T: IEntity
    {
        Task<T> Get(string id);

        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task<bool> Delete(string id);
    }
}
