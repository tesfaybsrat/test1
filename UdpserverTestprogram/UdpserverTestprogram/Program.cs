using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UdpserverTestprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient c = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 123);

            c.Connect(ep);

            var data = Encoding.ASCII.GetBytes("adsasdg");
            c.Send(data, data.Length);
        }
    }
}
