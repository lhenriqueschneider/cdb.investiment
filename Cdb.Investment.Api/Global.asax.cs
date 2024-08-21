using System.Web.Http;

namespace Cdb.Investment.Api
{
    /// <summary>
    /// Represents the entry point of the web application.
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Method called when the application starts.
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
