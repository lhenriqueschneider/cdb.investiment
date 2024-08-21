using System.Linq;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cdb.Investment.Api.Tests
{
    [TestClass]
    public class WebApiConfigTests
    {
        [TestMethod]
        public void Register_ShouldConfigureRoutes()
        {
            // Arrange
            HttpConfiguration config = new HttpConfiguration();

            // Act
            WebApiConfig.Register(config);

            // Assert
            Assert.AreEqual(2, config.Routes.Count);
            Assert.IsNotNull(config.Routes["DefaultApi"]);
            Assert.AreEqual("api/{controller}/", config.Routes["DefaultApi"].RouteTemplate);
            Assert.AreEqual(RouteParameter.Optional, config.Routes["DefaultApi"].Defaults["id"]);
        }
    }
}
