using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace iSlavici.Connection
{
    internal class DataAccess
    {
        private static string _ISLAVICI_DB_IP_ADDRESS = Helper.GetConnectionServer("iSlaviciDB");


        /// <summary>
        /// Represents the method that check if can be a connection to database ip address
        /// </summary>
        /// <returns></returns>
        public static bool TryConnection()
        {
            try
            {
                string ipAddress = _ISLAVICI_DB_IP_ADDRESS;

                Ping ping = new Ping();
                PingOptions options = new PingOptions
                {
                    DontFragment = true
                };

                string data = "a";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1;

                PingReply reply = ping.Send(ipAddress, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
