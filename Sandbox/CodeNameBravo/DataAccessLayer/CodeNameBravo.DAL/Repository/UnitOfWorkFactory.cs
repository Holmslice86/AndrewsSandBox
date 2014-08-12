using CodeNameBravo.DAL.Interfaces.Repository;

namespace CodeNameBravo.Web.DAL.Repository
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            return new UnitOfWork();
        }
    }
}
