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
        event EventHandler DataReceived;
        //void Show_Ports();
        void OpenConnection();
        //void CloseConnection();
        void send();
        //void Send(TextMessage msg)

        //string[] ports_incbox { set; get; }
        string Port { set; get; }
        string data_to_send { set; get; }
        //string ChatWindow { set; get; }
        string data_to_reciev { set; get; }
        string toolStripComboBox1 { get; set; }
        string toolStripComboBox2 { get; set; }
        string displayed { get; set; }

        string Local_Ip { get; set; }
        string Local_Port { get; set; }
        string Remot_Ip { get; set; }
        string Remot_Port { get; set; }
    }
}
//Port data_to_send data_to_reciev toolStripComboBox1 toolStripComboBox2 displayed