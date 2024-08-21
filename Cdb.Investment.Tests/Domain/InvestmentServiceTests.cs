using AutoFixture;
using Cdb.Investment.Services.Investment;
using Cdb.Investment.Services.Investment.Config;
using Cdb.Investment.Services.Investment.Dto;
using Cdb.Investment.Services.Investment.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace Cdb.Investment.Services.Tests.Investment
{
    [TestClass]
    public class InvestmentServiceTests
    {
        private readonly Mock<AppSettingsConfig> _appSettingsConfigMock;
        private readonly IInvestmentService _investmentService;

        public InvestmentServiceTests()
        {
            _appSettingsConfigMock = new Mock<AppSettingsConfig>();
            _investmentService = new InvestmentService(_appSettingsConfigMock.Object);
        }

        [TestMethod]
        public async Task Calculate_ShouldReturnCorrectFinalValue()
        {
            // Arrange
            decimal monetaryValue = 1000;
            int month = 1;

            // Act
            var result = await _investmentService.Calculate(monetaryValue, month);

            // Assert
            Assert.IsTrue(result.TotalAmount > 0);
        }

        [TestMethod]
        public async Task Calculate_ShouldReturnCorrectNetAmount()
        {
            decimal monetaryValue = 1000;
            int month = 1;

            // Act
            var result = await _investmentService.Calculate(monetaryValue, month);

            // Assert
            Assert.IsTrue(result.NetAmount > 0);
        }
    }
}
