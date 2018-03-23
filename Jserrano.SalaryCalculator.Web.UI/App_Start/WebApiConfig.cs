namespace Jserrano.SalaryCalculator.Web.UI
{
	using System.Web.Http;

	public static class WebApiConfig
    {
        public static UnityResolver Resolver = new UnityResolver(UnityConfig.Container);
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = Resolver;
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
