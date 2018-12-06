﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChatApplication.Properties;

namespace SimpleChatApplication
{
    public partial class Serial_Setting : Form
    {
        public Serial_Setting()
        {
            InitializeComponent();
        }

        private void Save_Setting_Click(object sender, EventArgs e)
        {
            //Settings.Default["Comport"] = cBoxPortSelect.Text;
            //Settings.Default["Boudrate"] = cBoxbaudrate.Text;
            //Settings.Default["Databit"] = cBoxdatabits.Text;
            //Settings.Default["Stopbit"] = cBoxstopbits.Text;
            //Settings.Default["Paritybit"] = cBoxparitybits.Text;
            Properties.Settings.Default.Comport = cBoxPortSelect.Text;
            Properties.Settings.Default.Boudrate = cBoxbaudrate.Text;
            Properties.Settings.Default.Databit = cBoxdatabits.Text;
            Properties.Settings.Default.Stopbit = cBoxstopbits.Text;
            Properties.Settings.Default.Paritybit = cBoxparitybits.Text;

            Settings.Default.Save();
            MessageBox.Show("Saved");
            this.Close();
            //Form1 datapass = new Form1();
            //datapass.ShowDialog();

        }
    }
}
