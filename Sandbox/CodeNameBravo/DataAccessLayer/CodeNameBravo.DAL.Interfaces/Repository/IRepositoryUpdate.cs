using System.Linq;

namespace CodeNameBravo.DAL.Interfaces.Repository
{
    public interface IRepositoryUpdate<T>
    {
        void Update(T entity);

        void UpdateMany(IQueryable<T> entities);
    }
}