using System;

namespace CodeNameBravo.DAL.Interfaces.Repository
{
    public interface IRepository<T> : IRepositoryRead<T>, IRepositoryInsert<T>, IRepositoryUpdate<T>, IRepositoryDelete<T>
    {
    }
}