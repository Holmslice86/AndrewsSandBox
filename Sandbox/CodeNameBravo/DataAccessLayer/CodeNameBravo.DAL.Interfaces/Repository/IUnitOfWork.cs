using System;
using CodeNameBravo.Domain.Entities.Stores;

namespace CodeNameBravo.DAL.Interfaces.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Store> Stores { get; }

        void Save();
    }
}