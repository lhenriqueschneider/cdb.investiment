using System.Web.Http;
using System.Threading.Tasks;
using Cdb.Investment.Services.Investment.Interfaces;
using System;

namespace Cdb.Investment.Api.Controllers
{
    /// <summary>
    /// Controller for handling investment-related operations.
    /// </summary>
    [RoutePrefix("api/investment")]
    public class InvestmentController : ApiController
    {
        private readonly IInvestmentService _investmentService;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentController"/> class.
        /// </summary>
        /// <param name="investmentService">The investment service.</param>
        public InvestmentController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        /// <summary>
        /// Calculates the CDB (Certificate of Deposit) based on the monetary value and the number of months.
        /// </summary>
        /// <param name="monetaryValue">The monetary value of the investment.</param>
        /// <param name="mounth">The number of months for the investment.</param>
        /// <returns>An IHttpActionResult representing the result of the calculation.</returns>
        [HttpGet]
        [Route("calculateCdb")]
        public async Task<IHttpActionResult> CalculateCdb(decimal monetaryValue, int mounth)
        {
            try
            {
                var response = await _investmentService.Calculate(monetaryValue, mounth);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
