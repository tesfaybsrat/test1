using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication4
{
    class Server
    {
        public void Listen()
        {
            UdpClient listener = new UdpClient(123);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 123);

            while (true)
            {
                byte[] data = listener.Receive(ref serverEP);

                //raise event
                RaiseDataReceived(new ReceiveDataArgs(serverEP.Address, serverEP.Port, data));
            }
        }

        public delegate void DataReceived(Object sender, ReceiveDataArgs args);

        public event DataReceived DataReceivedEvent;

        private void RaiseDataReceived(ReceiveDataArgs args)
        {
            if (DataReceivedEvent != null)
                DataReceivedEvent(this, args);
        }
    }

    public class ReceiveDataArgs
    {
        public IPAddress IpAddress { get; set; }
        public int Port { get; set; }
        public byte[] ReceivedBytes;

        public ReceiveDataArgs(IPAddress ip, int port, byte[] data)
        {
            this.IpAddress = ip;
            this.Port = port;
            this.ReceivedBytes = data;
        }
    }
}
