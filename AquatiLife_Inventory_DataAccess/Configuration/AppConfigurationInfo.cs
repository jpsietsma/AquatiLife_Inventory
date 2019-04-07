using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.Configuration
{
    /// <summary>
    /// Used to retrieve information from the app.config file
    /// </summary>
    public class AppConfigurationInfo
    {
        /// <summary>
        /// Username to connect to SQL
        /// </summary>
        public string SQLUsername { get; set; }

        /// <summary>
        /// Password to connect to SQL
        /// </summary>
        public string SQLPassword { get; set; }

        /// <summary>
        /// SQL Database name to connect to
        /// </summary>
        public string SQLDatabase { get; set; }

        /// <summary>
        /// Machine Hostname of the SQL Server machine
        /// </summary>
        public string SQLServer { get; set; }

        /// <summary>
        /// Instance name on the SQL Server (If there is one)
        /// </summary>
        public string SQLInstance { get; set; }

        /// <summary>
        /// Retrieve Configuration Info from App.Config
        /// </summary>
        public AppConfigurationInfo()
        {
            SQLUsername = ConfigurationManager.AppSettings["SQLUsername"];
            SQLPassword = ConfigurationManager.AppSettings["SQLPassword"];
            SQLDatabase = ConfigurationManager.AppSettings["SQLDatabase"];
            SQLServer = ConfigurationManager.AppSettings["SQLServer"];
            SQLInstance = ConfigurationManager.AppSettings["SQLInstance"];
        }

        /// <summary>
        /// Retrieve SQL Connection string from App.Config
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["SQLConnectionString"];
        }

    }
}
