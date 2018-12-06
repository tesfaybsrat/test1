using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChatApplication
{
   public interface Interface1
    {
        event dataReceived DataReceived;
        void Show_Ports();
        void OpenConnection();
        void CloseConnection();
        void send();
        //void Send(TextMessage msg)

        string[] ports_incbox { set; get; }
        string Port { set; get; }
        string data_to_send { set; get; }
        TextBox ChatWindow { set; get; }
        string data_to_reciev { set; get; }
    }
}
