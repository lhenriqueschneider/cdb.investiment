using System.Web.Http;
using WebActivatorEx;
using Cdb.Investment.Api;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Cdb.Investment.Api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

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
