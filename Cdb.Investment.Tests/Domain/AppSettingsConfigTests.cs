using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace Cdb.Investment.Services.Investment.Config.Tests
{
    [TestClass]
    public class AppSettingsConfigTests
    {
        [TestMethod]
        public void TbValue_ShouldReturnCorrectValue()
        {
            // Arrange
            var appSettingsConfig = new AppSettingsConfig();

            // Act
            decimal tbValue = appSettingsConfig.TbValue;

            // Assert
            decimal expectedValue = Convert.ToDecimal(ConfigurationManager.AppSettings["TbValue"]) / 100;
            Assert.AreEqual(expectedValue, tbValue);
        }

        [TestMethod]
        public void CdiValue_ShouldReturnCorrectValue()
        {
            // Arrange
            var appSettingsConfig = new AppSettingsConfig();

            // Act
            decimal cdiValue = appSettingsConfig.CdiValue;

            // Assert
            decimal expectedValue = Convert.ToDecimal(ConfigurationManager.AppSettings["CdiValue"]) / 100;
            Assert.AreEqual(expectedValue, cdiValue);
        }
    }
}
