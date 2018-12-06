using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Best.Properties;

namespace Best
{
    public partial class Form1 : Form
    {
        Class1 c = new Class1();
        delegate void textUpdate(string txt);
        public Form1()
        {
            InitializeComponent();
            c.DataReceived += new dataReceived(_workingObject_DataReceived);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Accept_data();
            c.Show_Ports();
            cBoxPortSelect.Items.AddRange(c.Ports_incbox);
            //cBoxbaudrate.Text = Setting.baundrate;

            cBoxPortSelect.Text = Settings.Default["Comport"].ToString();
            cBoxbaudrate.Text = Settings.Default["Boudrate"].ToString();
            cBoxdatabits.Text = Settings.Default["Databit"].ToString();
            cBoxstopbits.Text = Settings.Default["Stopbit"].ToString();
            cBoxparitybits.Text = Settings.Default["Paritybit"].ToString();
        }
        
        public void Accept_data()
        {
            c.Port=cBoxPortSelect.Text;
            c.data_to_send = tBoxgo.Text;
            c.data_to_reciev = tBoxreciev.Text;
            c.ChatWindow = tBoxreciev;
            //Console.WriteLine(c.data_to_send);
            //Console.WriteLine(c.data_to_reciev);

        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            Accept_data();
            c.Gone();
            //tBoxreciev.Text = c.displayed.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accept_data();
            c.OpenConnection();
            progressBar.Value = 100;
        }

        void _workingObject_DataReceived(object sender, SerialPortEventArgs arg)
        {
            //tBoxreciev.Text += arg.ReceivedData;
            updateUi(arg.ReceivedData);
        }
        private void updateUi(string msg)
        {

            this.Invoke(new EventHandler(delegate
            {
                tBoxreciev.AppendText(msg);

            }));

        }

        //private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    //c.Recieved();
        //    // c.data_to_reciev();
        //    //Accept_data();
        //    // c.data_to_reciev = serialPort1.ReadExisting();

        //    c.data_to_reciev = serialPort1.ReadExisting();
        //    Invoke(new EventHandler(ShowData));
        //}


        //private void ShowData(object sender, EventArgs e)
        //{
        //    //class1.ShowD();
        //    // if (toolStripComboBox1.Text == "Always Update")
        //    // if (cBoxalwaysupdate.Checked)
        //    //{
        //    tBoxreciev.Text = c.data_to_reciev;
        //    //}
        //    //else if (toolStripComboBox1.Text == "Add to old data")
        //    //{
        //    //    else if (cBoxaddtoolddata.Checked)

        //    //        tBoxrecievecontrol.Text += class1.dataIN;
        //    //    tBoxrecievecontrol.Text = tBoxrecievecontrol.Text.Insert(0, tBoxrecievecontrol);
        //    //}
        //}

        private void comControlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.CloseConnection();
            progressBar.Value = 0;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.Clear();
            tBoxgo.Text = c.displayed.ToString();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            c.Clear();
            tBoxreciev.Text = c.displayed.ToString();
        }

        private void cBoxrtsenable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Setting goto_setting = new Setting();
            //this.Hide();
            goto_setting.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
         c.toolStripComboBox1 = toolStripComboBox1.Text;
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
           c.toolStripComboBox2 = toolStripComboBox2.Text;
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
