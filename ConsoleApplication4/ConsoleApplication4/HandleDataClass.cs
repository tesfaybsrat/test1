using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class HandleDataClass
    {

        public void SubscribeToEvent(Server server)
        {
            server.DataReceivedEvent += server_DataReceiveEvent;
        }
        void server_DataReceiveEvent(object sender, ReceiveDataArgs args)
        {
            Console.WriteLine("Received message from [{0}:{1}]:\r\n{2}",
                args.IpAddress.ToString(), args.Port.ToString(), Encoding.ASCII.GetString(args.ReceivedBytes));
        }
    }
}
