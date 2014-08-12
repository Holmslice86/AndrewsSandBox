using CodeNameBravo.DAL.Interfaces.Repository;
using CodeNameBravo.Domain.Entities.Stores;
using CodeNameBravo.Domain.Interfaces.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameBravo.Domain.Services.Stores
{
    public class StoreDomainService : IStoreDomainService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public StoreDomainService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public Store GetStore(int id)
        {
            var store = new Store();

            using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
            {
                store = unitOfWork.Stores.Find(id);
            }

            return store;
        }

        public List<Store> GetStores()
        {
            var stores = new List<Store>();

            using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
            {
                stores = unitOfWork.Stores.GetAll().ToList();
            }

            return stores;
        }

        public void InsertStore(Store store)
        {
            using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
            {
                unitOfWork.Stores.Insert(store);
                unitOfWork.Save();
            }
            
        }

        public void UpdateStore(Store store)
        {
            using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
            {
                unitOfWork.Stores.Update(store);
                unitOfWork.Save();
            }
        }

        public void DeleteStore(int id)
        {
            using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
            {
                unitOfWork.Stores.Delete(id);
                unitOfWork.Save();
            }
        }
    }
}
