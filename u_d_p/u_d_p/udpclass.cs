using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace u_d_p
{
    public delegate void onNewReceive();
    //public event onNewReceive onNewReceiveEvent;
    class udpclass
    {

       // event Mydelegate Myevent;

       // private UdpClient client; //Client Socket
        private IPAddress IP; // multicast group address
        private int localPort; //loalport torecieve messages
        private int remotePort;  //remote port to send messages
        private int ttl;
        private string Data_receive;

        bool isClientConnected = false;

        private IPEndPoint remoteEP;
        private UnicodeEncoding encoding = new UnicodeEncoding();

        private string name;  // user name in chat
        private string message; //message to send;

        UdpClient udp = new UdpClient();

        public IPAddress IP_Address{
            get{ return IP; }
            set { IP = value; }
            }
        public int L_Port
        {
            get { return localPort; }
            set { localPort = value; }
        }
        public int R_Port
        {
            get { return remotePort; }
            set { remotePort = value; }
        }
        public int TTL
        {
            get { return ttl; }
            set { ttl = value; }
        }
        public string Client_Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public string data_to_reciev
        {
            get { return Data_receive; }
            set { Data_receive = value; }
        }

        //// bool isClientConnected = false;
        // var connector = new System.ComponentModel.BackgroundWorker();

        // public void connectToUDP()
        // {
        //     connector.DoWork += OpenConnection;
        //     connector.RunWorkerAsync();
        // }

        public event onNewReceive onNewReceiveEvent;

    public void OpenConnection()
        {

            IPEndPoint server_ip = new IPEndPoint(IP_Address, 5685);

            try
            {
                //Console.WriteLine("Waiting for server...");
                udp.Connect(server_ip);
                byte[] send_data = Encoding.ASCII.GetBytes("INIT");
                udp.Send(send_data, send_data.Length);
                byte[] received_bytes = udp.Receive(ref server_ip);
                string received_data = Encoding.ASCII.GetString(received_bytes);
                if (received_data == "INIT")
                {
                    isClientConnected = true;
                    Console.WriteLine("now connected");
                   // listen(server_ip);
                }

                onNewReceiveEvent += new onNewReceive(this.Data);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
       }

        private void Data()
        {
            data_to_reciev = "hi";
            ShowData();
        }
        public void ShowData()
        {
            textboxshow.Invoke(new EventHandler(delegate {
                textboxshow.Text += data_to_reciev;
                //textboxshow.Text = textboxshow.Text.Insert(0, textboxshow);
            }));

        }



        //private delegate void onNewReceive(string message);
        //public event onNewReceive onNewReceiveEvent;
        //public void fireEvent(string message)
        //{
        //    onNewReceiveEvent.Invoke(message);
        //}
        //private void waitForData(object sender, DoWorkEventArgs e)
        //{
        //    //this is the backgroundworker
        //    while (true)
        //    {
        //        receive();
        //        fireEvent(message);
        //    }
        //}

    }
}
