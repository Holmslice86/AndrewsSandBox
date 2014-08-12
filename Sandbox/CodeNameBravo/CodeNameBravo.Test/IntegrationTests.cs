using System;
using System.Linq;
using CodeNameBravo.Domain.Entities.Stores;
using CodeNameBravo.Domain.Services.Stores;
using CodeNameBravo.Web.DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeNameBravo.Test
{
    [TestClass]
    public class IntegrationTests
    {

        [TestInitialize]
        public void Init()
        {

        }

        [TestMethod]
        public void CrudTest()
        {
            var domain = new StoreDomainService(new UnitOfWorkFactory());
            domain.InsertStore(GetStore());

            var store = domain.GetStores().FirstOrDefault(x => x.Name == "Test1");
            Assert.IsTrue(store != null);

            store.Name = "Test2";

            domain.UpdateStore(store);

            Assert.IsTrue(domain.GetStores().Any(x=>x.Name=="Test2"));
            Assert.IsFalse(domain.GetStores().Any(x => x.Name == "Test1"));

            domain.DeleteStore(store.Id);

            Assert.IsFalse(domain.GetStores().Any(x => x.Name == "Test2"));
        }

        private Store GetStore()
        {
            return new Store()
            {
                Id = 0,
                Name = "Test1"
            };
        }

    }
}
