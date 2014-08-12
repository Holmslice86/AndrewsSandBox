using System.Linq;

namespace CodeNameBravo.DAL.Interfaces.Repository
{
    public interface IRepositoryDelete<T>
    {
        void Delete(int id);

        void DeleteMany(IQueryable<T> entities);
    }
}