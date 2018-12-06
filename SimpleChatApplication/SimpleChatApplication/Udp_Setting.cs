using SimpleChatApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChatApplication
{
    public partial class Udp_Setting : Form
    {
        public Udp_Setting()
        {
            InitializeComponent();
        }

        private void Exit_udp_setting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_udp_Setting_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalIp = Localip.Text;
            Properties.Settings.Default.Localport = Localport.Text;
            Properties.Settings.Default.RemotIp = Remotip.Text;
            Properties.Settings.Default.Remotport = Remotport.Text;
            Properties.Settings.Default.Status = Status.Text;
            Settings.Default.Save();
            MessageBox.Show("Setting Saved.");
            this.Close();
            Form1 go = new Form1();
            go.Show();


        }
    }
}
