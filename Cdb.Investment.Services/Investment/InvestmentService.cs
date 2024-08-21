using Cdb.Investment.Services.Investment.Config;
using Cdb.Investment.Services.Investment.Dto;
using Cdb.Investment.Services.Investment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cdb.Investment.Services.Investment
{
    public class InvestmentService : IInvestmentService
    {
        private readonly AppSettingsConfig _appSettingsConfig;
        public InvestmentService(AppSettingsConfig appSettingsConfig)
        {
            _appSettingsConfig = appSettingsConfig;
        }

        /// <summary>
        /// Calculates the final value of an investment.
        /// </summary>
        /// <param name="monetaryValue">The initial monetary value of the investment.</param>
        /// <param name="mounth">The number of months the investment will last.</param>
        /// <returns>The final value of the investment.</returns>
        public async Task<CalculateCdbResponse> Calculate(decimal monetaryValue, int mounths)
        {
            decimal totalAmount = monetaryValue;

            // Calculates the total amount based on the number of months
            for (int i = 0; i < mounths; i++)
            {
                totalAmount *= (1 + _appSettingsConfig.CdiValue * _appSettingsConfig.TbValue);
            }

            // Calculates the income tax rate and the net amount
            var taxRate = CalculateIncomeTaxRate(mounths);

            // Calculates the tax value and the net amount
            decimal taxValue = totalAmount * taxRate;

            // Rounds the totalAmount value to two decimal places
            totalAmount = Math.Floor(totalAmount * 100) / 100;

            // Calculates the net amount
            decimal netAmount = totalAmount - taxValue;

            // Rounds the net amount to two decimal places
            netAmount = Math.Floor(netAmount * 100) / 100;

            // Returns the final value of the investment
            return await Task.FromResult(new CalculateCdbResponse
            {
                TotalAmount = totalAmount,
                NetAmount = netAmount
            });
        }

        /// <summary>
        /// Loads the CDI (Certificado de Depósito Interbancário) rate based on the number of month.
        /// </summary>
        /// <param name="mounth">The number of month.</param>
        /// <returns>The CDI rate.</returns>
        private decimal CalculateIncomeTaxRate(int mounth)
        {
            // Definition of tax rates according to the month
            var taxRates = new Dictionary<int, decimal>
                {
                    { 1, 0.225M },
                    { 6, 0.225M },
                    { 12, 0.2M },
                    { 24, 0.175M },
                    { int.MaxValue, 0.15M }
                };

            // Finds the highest key that is less than or equal to the month
            var taxKey = taxRates.Keys.Where(k => k <= mounth).Max();
            // Returns the tax rate
            return taxRates[taxKey];
        }
    }
}
