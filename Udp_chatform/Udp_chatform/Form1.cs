using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace Wrox.Networking.Multicast
namespace Udp_chatform
{
    public partial class Form1 : Form
    {

        private bool done = true; //flag to stop listener thread
        private UdpClient client; //Client Socket
        private IPAddress groupAddress; // multicast group address
        private int localPort; //loalport torecieve messages
        private int remotePort;  //remote port to send messages
        private int ttl;

        private IPEndPoint remoteEP;
        private UnicodeEncoding encoding = new UnicodeEncoding();

        private string name;  // user name in chat
        private string message; //message to send;

        public Form1()
        {
            InitializeComponent();

            try
            {
                //// read the application configuration file
                //NameValueCollection configuration = ConfigurationSettings.AppSettings;
                //groupAddress = IPAddress.Parse(configuration["GroupAddress"]);
                //localPort = int.Parse(configuration["LocalPort"]);
                //remotePort = int.Parse(configuration["RemotePort"]);
                //ttl = int.Parse(configuration["TTL"]);

                groupAddress = IPAddress.Parse("234.5.6.11");
                localPort = int.Parse("7777");
                remotePort = int.Parse("7777");
                ttl = int.Parse("32");

                //groupAddress =IPAddress.Parse(Properties.Settings.Default.GroupAddress);
                //localPort = int.Parse(Properties.Settings.Default.LocalPort);
                //remotePort = int.Parse(Properties.Settings.Default.RemotePort);
                //ttl = int.Parse(Properties.Settings.Default.TTL);
            }
            catch
            {
                MessageBox.Show(this,
                    "Error in application configuratio file",
                    "Error Multicast chat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                buttonStart.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setting.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            name = textName.Text;
            textName.ReadOnly = true;

            try
            {
                // join the multicast group
                client = new UdpClient(localPort);
                client.JoinMulticastGroup(groupAddress, ttl);

                remoteEP = new IPEndPoint(groupAddress, remotePort);

                //start the receiving thread
                Thread receiver = new Thread(new ThreadStart(Listener));
                receiver.IsBackground = true;
                receiver.Start();

                //send the first message to the group
                byte[] data = encoding.GetBytes(name + "has join to the chat");
                client.Send(data, data.Length, remoteEP);

                buttonStart.Enabled = false;
                buttonSend.Enabled = true;
                buttonStop.Enabled = true;
            }
            catch(SocketException ex)
            {
                MessageBox.Show(this, ex.Message, "Error MulticastChat",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //main method of the listener thread that receives the data 
        private void Listener()
        {
           // done = false;

            try
            {
                while (!done)
                {
                    IPEndPoint ep = null;

                    byte[] buffer = client.Receive(ref ep);
                    message = encoding.GetString(buffer);

                    this.Invoke(new MethodInvoker(DisplayReceivedMessage));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error multicastChat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // we write the receoved message to the textMessages text box, and write some informational text to the status bar
        private void DisplayReceivedMessage()
        {
            string time = DateTime.Now.ToString("t");
            textMessages.Text = time + " " + message + "\r\n" + textMessages.Text;
            statusBar.Text = "Received last Message at " + time;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                //send a message to the group
                byte[] data = encoding.GetBytes(name + ": " + textMessage.Text);
                client.Send(data, data.Length, remoteEP);
                textMessage.Clear();
                textMessage.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error multicastchat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopListener();
        }
        private void StopListener()
        {
            //Send a leaving message to the groups
            byte[] data = encoding.GetBytes(name + "has left the chat");
            client.Send(data, data.Length, remoteEP);

            //leave the group
            client.DropMulticastGroup(groupAddress);
            client.Close();

            //tell the receiving thread to stop 
            done = true;

            buttonStart.Enabled = true;
            Setting.Enabled = true;
            buttonSend.Enabled = false;
            buttonStop.Enabled = false; 
        }

        private void buttononClose_Click(object sender, EventArgs e)
        {
            if (!done)
            {
                StopListener();
            }
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            //this.Close();
            s.ShowDialog();
        }
    }
}
