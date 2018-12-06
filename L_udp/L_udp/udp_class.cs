using Entities;
//using Entities.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace L_udp
{
    public delegate void dataReceived(SerialPortEventArgs e);
   // public delegate void dataReceived(object sender, SerialPortEventArgs arg);
    public class SerialPortEventArgs : EventArgs
    {
        //public string ReceivedData { get; private set; }
        public TextMessage ReceivedData { get; set; }

        //public SerialPortEventArgs(string data)
        //{
        //    ReceivedData = data;
        //}
        public SerialPortEventArgs(TextMessage msg)
        {
            ReceivedData = msg;
        }
    }
    public delegate void MessageRecievedEventHandler(MessageRecievedEventArgs e);
    public class MessageRecievedEventArgs : EventArgs
    {
        public TextMessage Message { get; set; }
        public MessageRecievedEventArgs(TextMessage msg)
        {
            Message = msg;
        }
    }

    class udp_class
    {
         public event dataReceived DataReceived;
        /// <summary>
        /// event based on delegate 
        /// </summary>
        Socket sck;
        EndPoint epLocal, epRemote;
        IPHostEntry host;
        private string IP_no;
        private string localip;
        private string localport;
        private string remotip;
        private string remotport;
        public string messge;
        byte[] buffer;
        byte[] data;
        int size = 1024;
        private KeyValuePair<Socket, byte[]> kvPair = new KeyValuePair<Socket, byte[]>();
        public Socket socket { get; set; }
        public TextMessage Msg { get; set; }
        public string IP_Address
        {
            get { return IP_no; }
            set { IP_no = value; }
        }
        public string Local_Ip
        {
            get { return localip; }
            set { localip = value; }
        }
        public string Local_Port
        {
            get { return localport; }
            set { localport = value; }
        }
        public string Remot_Ip
        {
            get { return remotip; }
            set { remotip = value; }
        }
        public string Remot_Port
        {
            get { return remotport; }
            set { remotport = value; }
        }
        public string Message
        {
            get { return messge; }
            set { messge =value;}
        }

        public udp_class()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }
        public string GetLocalIP()
        {
            //IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        public void connection()
        {
            //binding socket
            //epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
            epLocal = new IPEndPoint(IPAddress.Parse(Local_Ip), Convert.ToInt32(Local_Port));
            sck.Bind(epLocal);
            //connecting to the remote ip
            //epRemote = new IPEndPoint(IPAddress.Parse(textRemotIP.Text), Convert.ToInt32(textRemotPort.Text));
            epRemote = new IPEndPoint(IPAddress.Parse(Remot_Ip), Convert.ToInt32(Remot_Port));
            sck.Connect(epRemote);

            //listing the specific port
            buffer = new byte[1500];
            kvPair = new KeyValuePair<Socket, byte[]>(socket, new byte[size]);
            sck.BeginReceiveFrom(kvPair.Value, 0, size, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), kvPair);
            //sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
               // byte[] receivedData = new byte[1500];
                //ep = epRemote;
                kvPair = (KeyValuePair<Socket, byte[]>)aResult.AsyncState;
                //int recv = kvPair.Key.EndReceiveFrom(aResult, ref epRemote);
                //if (recv > 0)
                //{
                    string preamble = Encoding.Default.GetString(kvPair.Value, 0, 2);
                    if (preamble == "AA")
                    {
                        Msg = TextMessage.DecodeMessage(kvPair.Value);
                        if (DataReceived != null)
                            DataReceived(new SerialPortEventArgs(Msg));
                    }
                //}
                //receivedData = (byte[])aResult.AsyncState;
                ////convert byte[] to string
                //ASCIIEncoding aEncoding = new ASCIIEncoding();
                //string receivedMessage = aEncoding.GetString(receivedData);

                ////adding this message into listbox
                //SerialPortEventArgs arg = new SerialPortEventArgs(receivedMessage);
                //DataReceived(this, arg);
                kvPair = new KeyValuePair<Socket, byte[]>(socket, new byte[size]);
                sck.BeginReceiveFrom(kvPair.Value, 0, size, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), kvPair);

                //buffer = new byte[1500];
               // sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           // Listen();
         }

       // public void send()
            public void send(TextMessage msg)
        {
            //// convert string message to byte
            //ASCIIEncoding aEncoding = new ASCIIEncoding();
            //byte[] sendingMessage = new byte[1500];
            //sendingMessage = aEncoding.GetBytes(Message);
            ////sending the Encoding messgae
            //sck.Send(sendingMessage);

            data = TextMessage.EncodeMessage(msg);
            MessageBox.Show("data sent" + data);
            sck.Send(data);
            //sck.BeginSendTo(data, 0, data.Length, SocketFlags.None, epRemote, new AsyncCallback(SendData), socket);
               
        }
        //public void Send(TextMessage msg, IPEndPoint ipEp)
        //{
        //    try
        //    {
        //        data = TextMessage.EncodeMessage(msg);
        //        socket.BeginSendTo(data, 0, data.Length, SocketFlags.None, ipEp, new AsyncCallback(SendData), socket);
        //    }
        //    catch (Exception ex) { }
        //}
        private void SendData(IAsyncResult iar)
        {
            Socket sock = (Socket)iar.AsyncState;
            sock.EndSendTo(iar);
        }

    }
}
