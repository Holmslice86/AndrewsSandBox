using CodeNameBravo.DAL.Interfaces.Repository;
using CodeNameBravo.Web.DAL.Repository;
using Microsoft.Practices.Unity;
using CodeNameBravo.Domain.Interfaces.Stores;
using CodeNameBravo.Domain.Services.Stores;

namespace CodeNameBravo.Init
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialize()
        {
            var container = BuildUnityContainer();
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        private static void RegisterDomainTypes(IUnityContainer container)
        {
            container.RegisterType<IStoreDomainService, StoreDomainService>();
        }

        private static void RegisterDalTypes(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            RegisterDomainTypes(container);
            RegisterDalTypes(container);
        }

    }
}
