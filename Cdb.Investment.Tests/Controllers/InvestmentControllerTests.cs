using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using AutoFixture;
using Cdb.Investment.Api.Controllers;
using Cdb.Investment.Services.Investment.Dto;
using Cdb.Investment.Services.Investment.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Cdb.Investment.Api.Tests.Controllers
{
    [TestClass]
    public class InvestmentControllerTests
    {
        private Mock<IInvestmentService> _investmentServiceMock;
        private InvestmentController _investmentController;
        private Fixture _fixture;

        [TestInitialize]
        public void Initialize()
        {
            _fixture = new Fixture();
            _investmentServiceMock = new Mock<IInvestmentService>();
            _investmentController = new InvestmentController(_investmentServiceMock.Object);
        }

        /// <summary>
        /// Tests the CalculateCdb method with valid input.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task CalculateCdb_ValidInput_ReturnsOkResult()
        {
            // Arrange
            decimal monetaryValue = 1000;
            int month = 12;
            var calculateCdbResponse = _fixture.Create<CalculateCdbResponse>();

            _investmentServiceMock.Setup(x => x.Calculate(monetaryValue, month)).ReturnsAsync(calculateCdbResponse);

            // Act
            var result = await _investmentController.CalculateCdb(monetaryValue, month) as OkNegotiatedContentResult<CalculateCdbResponse>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Content.TotalAmount, calculateCdbResponse.TotalAmount);
            Assert.AreEqual(result.Content.NetAmount, calculateCdbResponse.NetAmount);
        }

        /// <summary>
        /// Tests the CalculateCdb method when an exception is thrown.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task CalculateCdb_ExceptionThrown_ReturnsBadRequestResult()
        {
            // Arrange
            decimal monetaryValue = 1000;
            int month = 12;
            string errorMessage = "An error occurred.";

            _investmentServiceMock.Setup(x => x.Calculate(monetaryValue, month))
                .ThrowsAsync(new Exception(errorMessage));

            // Act
            var result = await _investmentController.CalculateCdb(monetaryValue, month) as BadRequestErrorMessageResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Message, errorMessage);
        }
    }
}
