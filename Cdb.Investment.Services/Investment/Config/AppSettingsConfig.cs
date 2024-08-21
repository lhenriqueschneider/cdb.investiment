using System;
using System.Configuration;

namespace Cdb.Investment.Services.Investment.Config
{
    // Represents the configuration of the application settings.
    public class AppSettingsConfig
    {
        public decimal TbValue
        {
            get
            {
                return Convert.ToDecimal(ConfigurationManager.AppSettings["TbValue"]) / 100;
            }
        }

        public decimal CdiValue
        {
            get
            {
                return Convert.ToDecimal(ConfigurationManager.AppSettings["CdiValue"]) / 100;
            }
        }
    }
}
