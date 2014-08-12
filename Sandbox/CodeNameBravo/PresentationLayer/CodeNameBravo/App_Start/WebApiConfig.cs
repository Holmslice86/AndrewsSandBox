using System.Web.Http;
using CodeNameBravo.Init;

namespace CodeNameBravo.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = Bootstrapper.Initialize();
            config.DependencyResolver = new UnityResolver(container);

			config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
