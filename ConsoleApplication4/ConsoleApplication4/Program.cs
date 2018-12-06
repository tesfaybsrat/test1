using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            HandleDataClass hdc = new HandleDataClass();

            //start server thread 
            Thread serverThread = new Thread(() => server.Listen());
            serverThread.Start();

            //start handeler thread
            Thread dataHandelerThread = new Thread(() =>
            hdc.SubscribeToEvent(server));

            dataHandelerThread.Start();

            //do other things

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
