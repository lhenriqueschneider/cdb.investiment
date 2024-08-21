using Cdb.Investment.Services.Investment;
using Cdb.Investment.Services.Investment.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Unity;

namespace Cdb.Investment.IoC.Tests
{
    [TestClass]
    public class UnityConfigTests
    {
        [TestMethod]
        public void RegisterTypes_ShouldRegisterInvestmentService()
        {
            // Arrange
            var container = new UnityContainer();
            UnityConfig.RegisterTypes(container);

            // Act
            var investmentService = container.Resolve<IInvestmentService>();

            // Assert
            Assert.IsNotNull(investmentService);
            Assert.IsInstanceOfType(investmentService, typeof(InvestmentService));
        }
    }

    public static class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            // Register your types here
            container.RegisterType<IInvestmentService, InvestmentService>();
        }
    }
}
