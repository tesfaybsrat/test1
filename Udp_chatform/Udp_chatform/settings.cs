using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udp_chatform.Properties;

namespace Udp_chatform
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Save_Setting_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GroupAddress = GroupAddress.Text;
            Properties.Settings.Default.LocalPort = LocalPort.Text;
            Properties.Settings.Default.RemotePort = RemotePort.Text;
            Properties.Settings.Default.TTL = TTL.Text;


            Properties.Settings.Default.Save();




            MessageBox.Show("Saved");
            Close();
            //Form1 datapass = new Form1();
            //datapass.ShowDialog();
        }
    }
}
