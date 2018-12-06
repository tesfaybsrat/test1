using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_udp
{
    public interface IPortManager
    {
        string Message { get; set; }
        void Send();
        //event dataReceived;
        string[] Getlocal();
    }
}
