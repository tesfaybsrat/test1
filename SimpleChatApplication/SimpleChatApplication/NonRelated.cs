using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;

namespace SimpleChatApplication
{
   public static class NonRelated
    {
        #region Ip Geting start here
        public static string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        #endregion Ip Geting end here
        #region Getting communication port start here
        public static string[] Show_Ports()
        {
            return SerialPort.GetPortNames();
        }
        #endregion Getting communication port end here
    }


}
