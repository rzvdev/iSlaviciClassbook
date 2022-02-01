using System.Configuration;

namespace iSlavici.Utility
{
    internal class Writer
    {

        /// <summary>
        /// Represent the method that update the configuration file
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void UpdateConfig(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
