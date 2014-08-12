using CodeNameBravo.DAL.Interfaces.Repository;
using CodeNameBravo.Domain.Entities.Stores;
using CodeNameBravo.Web.DAL.DataEntities;

namespace CodeNameBravo.Web.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CodeNameBravoContext _context;

        private IRepository<Store> _stores;

        public UnitOfWork()
        {
            _context = new CodeNameBravoContext();
        }

        public IRepository<Store> Stores
        {
            get
            {
                if (_stores == null)
                    _stores = new GenericRepository<Store>(_context);

                return _stores;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}