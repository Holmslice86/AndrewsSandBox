using CodeNameBravo.Domain.Entities.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameBravo.Domain.Interfaces.Stores
{
    public interface IStoreDomainService
    {
        Store GetStore(int id);

        List<Store> GetStores();

        void InsertStore(Store store);

        void UpdateStore(Store store);

        void DeleteStore(int id);
    }
}
