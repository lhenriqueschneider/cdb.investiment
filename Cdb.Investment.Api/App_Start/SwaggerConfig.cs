using System.Web.Http;
using WebActivatorEx;
using Cdb.Investment.Api;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Cdb.Investment.Api
{
    /// <summary>
    /// Provides configuration for Swagger in the API.
    /// </summary>
    public static class SwaggerConfig
    {
        /// <summary>
        /// Registers Swagger configuration.
        /// </summary>
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Cdb.Investment.Api");
                    })
                .EnableSwaggerUi(c =>
                    {

                    });
        }
    }
}
