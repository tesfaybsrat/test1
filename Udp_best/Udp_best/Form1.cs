using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udp_best
{
    public partial class Form1 : Form
    {
        Udp_port_manager udp_class = new Udp_port_manager();
        public Form1()
        {
            InitializeComponent();
            udp_class.must_ini();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //name = textName.Text;
            udp_class.Receive_Window = textMessage.Text;
            udp_class.Name= textName.Text;
            textName.ReadOnly = true;
            udp_class.Open_connection();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            udp_class.Data_to_go = textMessage.Text;
            udp_class.Send();

        }
    }
}
