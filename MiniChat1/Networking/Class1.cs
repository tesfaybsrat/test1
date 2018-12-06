using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Networking
{
    class RemoteNode
    {
        public IPEndPoint EndPoint { get; set; }
        public string UserName { get; set; }
        //public UserStatus Status { get; set; }
        public RemoteNode()
        {
            Socket sock;
        }
    }
}
