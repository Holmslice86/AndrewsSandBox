using System.Linq;

namespace CodeNameBravo.DAL.Interfaces.Repository
{
    public interface IRepositoryRead<T>
    {
        T Find(object id);

        IQueryable<T> GetAll();
    }
}