using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u_d_p
{
    public partial class Form1 : Form
    {
        udpclass obj = new udpclass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Access_values();
        }

        private void bSTART_Click(object sender, EventArgs e)
        {
            Access_values();
            obj.OpenConnection();
            progressBar.Value = 100;
        }
        public void Access_values()
        {
            obj.Client_Name = tNAME.Text;
            obj.IP_Address = IPAddress.Parse(tIP.Text);
            obj.L_Port = int.Parse(tPORT.Text);
            obj.R_Port = 7777;
            obj.TTL = int.Parse(tTTL.Text);
            obj.data_to_reciev = tRECIEVE.Text;
        }
    }
}
