using System.Linq;

namespace CodeNameBravo.DAL.Interfaces.Repository
{
    public interface IRepositoryInsert<T>
    {
        void Insert(T entity);

        void InsertMany(IQueryable<T> entities);
    }
}