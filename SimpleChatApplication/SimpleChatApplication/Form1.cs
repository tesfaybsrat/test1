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
using System.IO;

namespace SimpleChatApplication
{
    public partial class Form1 : Form
    {
        OpenFileDialog openfile = new OpenFileDialog();
      

        string com_type;
        Interface1 connection =new SerialPortManager();
        Interface1 connectionu =new UdpPortManager();
        //UdpPortManager udp_obj;
        private delegate void UpdateDisplay(string msg);
        delegate void textUpdate(string txt);
        //SerialPortManager serial_obj = new SerialPortManager();
        
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            //serial start here
           // connection = new SerialPortManager();
            Accept_data();
            //connection.Show_Ports();
            cBoxPortSelect.Items.AddRange(NonRelated.Show_Ports());
           
            cBoxPortSelect.Text = Settings.Default["Comport"].ToString();
            cBoxbaudrate.Text = Settings.Default["Boudrate"].ToString();
            cBoxdatabits.Text = Settings.Default["Databit"].ToString();
            cBoxstopbits.Text = Settings.Default["Stopbit"].ToString();
            cBoxparitybits.Text = Settings.Default["Paritybit"].ToString();
           // textLocalIP.Text = Settings.Default["Localip"].ToString();
            textLocalPort.Text = Settings.Default["Localport"].ToString();
           // textRemotIP.Text = Settings.Default["Remotip"].ToString();
            textRemotPort.Text = Settings.Default["Remotport"].ToString();

            //connection.DataReceived += new dataReceived(_workingObject_DataReceived_serial);
            connection.DataReceived +=(_workingObject_DataReceived_serial);
            //serial end here

            //udp start here
            //set up socket
            //connectionu = new UdpPortManager();
            connectionu.DataReceived += _workingObject_DataReceived_udp;

            // get user Ip
            textLocalIP.Text = NonRelated.GetLocalIP();
            textRemotIP.Text = NonRelated.GetLocalIP();
            //udp end here
        }

        private void _workingObject_DataReceived_udp(object sender, EventArgs e)
        {
            udpEventArgs me = e as udpEventArgs;
            this.Invoke(new UpdateDisplay(updateUi), me.ReceivedData_udp);
        }

        private void updateUi(string msg)
        {
            string message = msg;
            string preamble = (message.Split(','))[0];
            string frameid = (message.Split(','))[1];
            string userid = (message.Split(','))[2];
            string status = (message.Split(','))[3];
            string dataa = (message.Split(','))[4];
            string postamble = (message.Split(','))[5];

            if (status == "Online")
            {
                    tBoxreciev.AppendText(userid+" : "+ dataa +"\n \n");
            }
            else if(status == "Bussy")
            {
                tBoxreciev.AppendText(userid + " : " + dataa+"\n \n");
            }
            else if(status == "Offline")
            {
                tBoxreciev.AppendText("\n" + userid + " : " + status);
            }
            else
            {
                
                tBoxreciev.AppendText("empty \n");
            }
        }

        private void openTSMIUdp_Click(object sender, EventArgs e)
        {
            if (textLocalIP.Text == "")
            {
                MessageBox.Show("Enter LocalIp.");
                textLocalIP.Focus();
            }
            else if (textLocalPort.Text == "")
            {
                MessageBox.Show("Enter LocalPort.");
                textLocalPort.Focus();
            }
            else if (textRemotIP.Text == "")
            {
                MessageBox.Show("Enter RemorIp.");
                textRemotIP.Focus();
            }
            else if (textRemotPort.Text == "")
            {
                MessageBox.Show("Enter RemotPort.");
                textRemotPort.Focus();
            }
            else
            {
            //connectionu = new UdpPortManager();
            connectionu.Local_Ip = textLocalIP.Text;
            connectionu.Local_Port = textLocalPort.Text;
            connectionu.Remot_Ip = textRemotIP.Text;
            connectionu.Remot_Port = textRemotPort.Text;

            connectionu.OpenConnection();
            progressBar.Value = 100;
            com_type = "udp_com";

            cBoxPortSelect.Enabled = false;
            cBoxbaudrate.Enabled = false;
            cBoxdatabits.Enabled = false;
            cBoxparitybits.Enabled = false;
            cBoxstopbits.Enabled = false;
            openTSMIserial.Enabled = false;
            closeTSMIserial.Enabled = false;

            textLocalIP.Enabled = true;
            textLocalPort.Enabled = true;
            textRemotIP.Enabled = true;
            textRemotPort.Enabled = true;
            openTSMIUdp.Enabled = false;
            closeTSMIUdp.Enabled = true;
        }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            //string type = com_type;
           switch (com_type)
            {
               case "udp_com":
                    connectionu.Port = tBoxMessage.Text;
                    connectionu.data_to_send = "0x11|0x55";
                    connectionu.data_to_reciev = "0x11";
                    //connectionu.toolStripComboBox1 = "0xXXXXXXXX";
                    connectionu.toolStripComboBox1 = file.Text;
                    //connectionu.toolStripComboBox2 = "Online";
                    connectionu.toolStripComboBox2 = Settings.Default["Status"].ToString();
                    connectionu.displayed = "0xAA";
                    //string path = file.Text;
                    //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    //BinaryReader br = new BinaryReader(fs);
                    //byte[] data = br.ReadBytes(Convert.ToInt16(fs.Length));
                     

                    connectionu.send();
                    tBoxreciev.AppendText("\n Me : "+ tBoxMessage.Text+ "\n \n ");
                    tBoxMessage.Text = " ";

                    //udp end here
                    break;
                case "serial_com":
                    //connection = new SerialPortManager();
                    //serial start here 
                    Accept_data();
                    connection.send();
                    //serial end here
                    break;
                default:
                    MessageBox.Show(com_type+" Please Select Communication Protocol");
                    break;
            }

        }

        private void openTSMIserial_Click(object sender, EventArgs e)
        {
            if (cBoxPortSelect.Text == "")
            {
                MessageBox.Show("Select Communication Port.");
                cBoxPortSelect.Focus();
            }
            else if (cBoxbaudrate.Text == "")
            {
                MessageBox.Show("Select Baud Rate.");
                cBoxbaudrate.Focus();
            }
            else if (cBoxdatabits.Text == "")
            {
                MessageBox.Show("Select Databits.");
                cBoxdatabits.Focus();
            }
            else if (cBoxparitybits.Text == "")
            {
                MessageBox.Show("Select Paritybits.");
                cBoxparitybits.Focus();
            }
            else if (cBoxstopbits.Text == "")
            {
                MessageBox.Show("Select Stopbits");
                cBoxstopbits.Focus();
            }
            else
            {
               // connection = new SerialPortManager();
                Accept_data();
                connection.OpenConnection();
                progressBar.Value = 100;
                com_type = "serial_com";
                MessageBox.Show(com_type);
                cBoxPortSelect.Enabled = true;
                cBoxbaudrate.Enabled = true;
                cBoxdatabits.Enabled = true;
                cBoxparitybits.Enabled = true;
                cBoxstopbits.Enabled = true;
                openTSMIserial.Enabled = false;
                closeTSMIserial.Enabled = true;

                textLocalIP.Enabled = false;
                textLocalPort.Enabled = false;
                textRemotIP.Enabled = false;
                textRemotPort.Enabled = false;
                openTSMIUdp.Enabled = false;
                closeTSMIUdp.Enabled = false;
            }
        }

        void _workingObject_DataReceived_serial(object sender, EventArgs e)
        {
            udpEventArgss me = e as udpEventArgss;
            this.Invoke(new UpdateDisplay(updateUi_serial), me.ReceivedData);
            //updateUi_serial(arg.ReceivedData);
        }
        private void updateUi_serial(string msg)
        {

            this.Invoke(new EventHandler(delegate
            {
                tBoxreciev.AppendText("\n"+msg);

            }));

        }

        public void Accept_data()
        {
            connection.Port = cBoxPortSelect.Text;
            connection.data_to_send = tBoxMessage.Text;
            connection.data_to_reciev = tBoxreciev.Text;
            //connection.ChatWindow = tBoxreciev;
        }

        private void resetTSMIudp_serial_Click(object sender, EventArgs e)
        {
            cBoxPortSelect.Enabled = true;
            cBoxbaudrate.Enabled = true;
            cBoxdatabits.Enabled = true;
            cBoxparitybits.Enabled = true;
            cBoxstopbits.Enabled = true;
            openTSMIserial.Enabled = true;
            closeTSMIserial.Enabled = true;

            textLocalIP.Enabled = true;
            textLocalPort.Enabled = true;
            textRemotIP.Enabled = true;
            textRemotPort.Enabled = true;
            openTSMIUdp.Enabled = true;
            closeTSMIUdp.Enabled = true;
        }

        private void serialSettingTSMISerial_Click(object sender, EventArgs e)
        {
            Serial_Setting goto_setting = new Serial_Setting();
            goto_setting.Show();
            this.Close();
        }

        private void existTSMI_Click(object sender, EventArgs e)
        {
            Udp_Setting goto_setting = new Udp_Setting();
            goto_setting.Show();
            this.Close();
        }

        private void closeTSMIserial_Click(object sender, EventArgs e)
        {
           // connection.CloseConnection();
            progressBar.Value = 0;
            openTSMIserial.Enabled = true;
            closeTSMIserial.Enabled = false;
        }

        private void closeTSMIUdp_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void file_Click(object sender, EventArgs e)
        {
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                file.Text = openfile.FileName;
            }
        }
    }
}
