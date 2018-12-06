using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entities;
namespace L_udp
{
    public partial class Form1 : Form
    {
        List<User> usersList = new List<User>();
        private delegate void UpdateDisplay(Entities.TextMessage msg);
        udp_class obj;
        delegate void textUpdate(string txt);

        //Socket sck;
        //EndPoint epLocal, epRemote;
        //IPHostEntry host;
        //private byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ////set up socket
            //obj.form_loa
            obj  = new udp_class();
           // obj.DataReceived += new dataReceived(_workingObject_DataReceived);
            obj.DataReceived += _workingObject_DataReceived;
            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user Ip
            textLocalIP.Text = obj.GetLocalIP();
            textRemotIP.Text = obj.GetLocalIP();
        }

        void _workingObject_DataReceived(SerialPortEventArgs e)
        {
            //tBoxreciev.Text += arg.ReceivedData;
            //updateUi(arg.ReceivedData);
            Invoke(new UpdateDisplay(updateUi), new object[] { e.ReceivedData });
            //listMessage.Items.Add(" Frind:" + receivedMessage);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            obj.Local_Ip = textLocalIP.Text;
            obj.Local_Port = textLocalPort.Text;
            obj.Remot_Ip = textRemotIP.Text;
            obj.Remot_Port = textRemotPort.Text;
            obj.connection();
        }
       // private void updateUi(string msg)
        private void updateUi(Entities.TextMessage msg)
        {
            UserStatus statu = msg.User.Status;
            string Ip = msg.User.IPAddress;
            string nam = msg.User.DisplayName;
            if (msg.User.Status == UserStatus.Available) {
                if (msg.Type == TextMessageType.TextMessage)
                {
                    tBoxreciev.AppendText("\n" + nam + " :" + msg.Msg + " Status :" + statu + " IP :" + Ip + "\n");

                }
                else if (msg.Type == TextMessageType.StatusMessage)
                {
                    if (usersList.Count(x => x.IPAddress == msg.User.IPAddress) == 0)
                    {
                        usersList.Add(msg.User);
                        // StatusIndicator si = new StatusIndicator(msg.User.DisplayName, msg.User.Status, msg.User.IPAddress);
                        // flowLayoutPanel1.Controls.Add(si);
                        string n = msg.User.DisplayName;
                        UserStatus s = msg.User.Status;
                        string I = msg.User.IPAddress;
                        tBoxreciev.AppendText("Frind Name :" + n + "Status :" + s + "IP :" + I + "\n");
                    }
                    listBox1.DataSource = usersList.Select(u => u.DisplayName).ToList<string>();

                }
            }
            else if (msg.User.Status == UserStatus.Bussy)
            {
                if (msg.Type == TextMessageType.TextMessage)
                {
                    tBoxreciev.AppendText("\n" + nam + " :" + msg.Msg + " Status :" + statu + " IP :" + Ip + "\n");

                }
            }
            else if (msg.User.Status == UserStatus.Offline)
            {
                if (msg.Type == TextMessageType.TextMessage)
                {
                    tBoxreciev.AppendText("\n" + nam + " :" + msg.Msg + " Status :" + statu + " IP :" + Ip + "\n");

                }
            }
            else //if (msg.User.Status == UserStatus.UnAvailable)
            {
                if (msg.Type == TextMessageType.TextMessage)
                {
                    tBoxreciev.AppendText("\n" + nam + " :" + msg.Msg + " Status :" + statu + " IP :" + Ip + "\n");

                }
            }

            //this.Invoke(new EventHandler(delegate
            //{
            //    tBoxreciev.AppendText("Frind :"+msg + "\n");

            //}));

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //obj.Message = textMessage.Text; 
            //obj.send();
            //// adding to the list Box
            //tBoxreciev.Text = " Me :" + textMessage.Text+"\n";
            ////listMessage.Items.Add(" Me :" + textMessage.Text);
            //textMessage.Text = " ";

            string displayName = Entities.Properties.Settings.Default.DisplayName;

            string textMessage = txtSend.Text;
            //string textMessag = textMessage.Text;
            Entities.TextMessage msg = new Entities.TextMessage()
            {
                Msg = textMessage,
                User = new User()
                {
                    DisplayName = displayName,
                    Status = UserStatus.Offline,
                    IPAddress = textRemotIP.Text,
                }
            };
           obj.send(msg);
            tBoxreciev.Text = " Me :" + textMessage+ "\n";
           // textMessage.Text = " ";
         }
    }
}
