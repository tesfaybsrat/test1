using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace MiniChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress[] ipAddress = Dns.GetHostEntry("user-PC").AddressList;
            foreach (IPAddress addr in ipAddress)
            {
                listBox1.Items.Add(addr.ToString());
            }
        }
    }
}
