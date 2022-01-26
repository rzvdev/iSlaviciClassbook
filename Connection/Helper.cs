using System.Configuration;
using System.Data.SqlClient;

namespace iSlavici.Connection
{
    internal class Helper
    {

        /// <summary>
        /// Represent the method that return the connection info from AppConfig
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Represents the method that return the IP Address of connection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionServer(string name)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            return builder.DataSource;
        }
    }
}