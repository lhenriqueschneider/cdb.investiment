using Cdb.Investment.IoC;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Cdb.Investment.Api
{
    /// <summary>
    /// Configures the Web API routes and services.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the Web API routes and services.
        /// </summary>
        /// <param name="config">The HttpConfiguration object.</param>
        public static void Register(HttpConfiguration config)
        {
            // Configuration and Web API services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // Format the response as JSON

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/",
                defaults: new { id = RouteParameter.Optional }
            );

            UnityWebApiActivator.Start();
        }
    }
}
