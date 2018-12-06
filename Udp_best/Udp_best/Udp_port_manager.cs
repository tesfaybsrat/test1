using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udp_best
{
    class Udp_port_manager
    {
        private string name;
        private string data_to_send;
        private string data_to_recieve;
        private string statusBar;
        private TextBox textboxshow;
        private Button buttonStart;

        private bool done = true; //flag to stop listener thread
        private UdpClient client; //Client Socket
        private IPAddress groupAddress; // multicast group address
        private int localPort; //loalport torecieve messages
        private int remotePort;  //remote port to send messages
        private int ttl;

        private IPEndPoint remoteEP;
        private UnicodeEncoding encoding = new UnicodeEncoding();

        UdpClient udpc = new UdpClient();


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Data_to_go
        {
            get
            {
                return data_to_send;
            }
            set
            {
                data_to_send = value;
            }
        }

        public string Data_to_receive
        {
            get
            {
                return data_to_recieve;
            }
            set
            {
                data_to_recieve = value;
            }
        }

        public string StatusBar
        {
            get
            {
                return statusBar;
            }
            set
            {
                statusBar = value;
            }
        }

        public TextBox Receive_Window
        {
            get
            {
                return textboxshow;
            }
            set
            {
                textboxshow = value;
            }
        }

        public void must_ini()
        {
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

                //groupAddress = IPAddress.Parse(Properties.Settings.Default.GroupAddress);
                //localPort = int.Parse(Properties.Settings.Default.LocalPort);
                //remotePort = int.Parse(Properties.Settings.Default.RemotePort);
                //ttl = int.Parse(Properties.Settings.Default.TTL);
            }
            catch
            {
                MessageBox.Show("Error in application configuratio file", "Error Multicast chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //buttonStart.Enabled = false;
            }
        }

        public void Open_connection()
        {
            string name = Name;
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
                //buttonSend.Enabled = true;
                //buttonStop.Enabled = true;
            }
            catch (SocketException ex)
            {
             MessageBox.Show(ex.Message, "Error MulticastChat",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //main method of the listener thread that receives the data 
        private void Listener()
        {
            done = false;

            try
            {
                while (!done)
                {
                    IPEndPoint ep = null;

                    byte[] buffer = client.Receive(ref ep);
                    Data_to_go = encoding.GetString(buffer);

                    DisplayReceivedMessage();

                    //this.Invoke(new MethodInvoker(DisplayReceivedMessage));

                    //textboxshow.Invoke(new EventHandler(delegate {
                    //    textboxshow.Text += Data_to_receive;
                    //    //textboxshow.Text = textboxshow.Text.Insert(0, textboxshow);
                    //}));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error multicastChat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // we write the receoved message to the textMessages text box, and write some informational text to the status bar
        private void DisplayReceivedMessage()
        {
            string time = DateTime.Now.ToString("t");
            Data_to_receive = time + " " + Data_to_go + "\r\n" + Data_to_receive;
            //StatusBart = "Received last Message at " + time;
        }

        public void Send()
        {
            try
            {
                //send a message to the group
                byte[] data = encoding.GetBytes(Name + ": " + Data_to_go);
                client.Send(data, data.Length, remoteEP);
                //textMessage.Clear();
                //textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Error multicastchat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
