using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace SimpleChatApplication
{
    #region udp port manager start here
    class UdpPortManager 
    {
        public event EventHandler DataReceived_udp;
        #region variable declaretion start here
        Socket sck;
        EndPoint epLocal, epRemote;
        IPHostEntry host;
        private string IP_no;
        private string localip;
        private string localport;
        private string remotip;
        private string remotport;
        public string messge;
        private string preamble;
        private string frameID;
        private string userID;
        private string status;
        private string postamble;
        byte[] data;
        int size = 1024;
        private KeyValuePair<Socket, byte[]> kvPair = new KeyValuePair<Socket, byte[]>();
        #endregion variable declaration ends here
        #region properties start here
        public Socket socket { get; set; }
        public string Msg { get; set; }
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
            set { messge = value; }
        }

        public string Preamble { get { return preamble; } set { preamble = value; } }
        public string FrameID { get { return frameID; } set { frameID = value; } }
        public string UserID { get { return userID; } set { userID = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Postamble { get { return postamble; } set { postamble = value; } }
        #endregion properties end here
        public UdpPortManager()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }
        #region Ip Geting start here
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
        #endregion Ip Geting end here
        #region Create Connection start here
        public void OpenConnection()
        {
            //binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(Local_Ip), Convert.ToInt32(Local_Port));
            sck.Bind(epLocal);
            //connecting to the remote ip
            epRemote = new IPEndPoint(IPAddress.Parse(Remot_Ip), Convert.ToInt32(Remot_Port));
            sck.Connect(epRemote);
            //listing the specific port
            kvPair = new KeyValuePair<Socket, byte[]>(socket, new byte[size]);
            sck.BeginReceiveFrom(kvPair.Value, 0, size, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), kvPair);
            //sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
        #endregion Create Connection end here
        #region Message Call back sratr here
        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                kvPair = (KeyValuePair<Socket, byte[]>)aResult.AsyncState;
                string mMsg = DecodeMessage(kvPair.Value);
                if (DataReceived_udp != null)
                DataReceived_udp(this, new udpEventArgs() {ReceivedData_udp = mMsg });
                kvPair = new KeyValuePair<Socket, byte[]>(socket, new byte[size]);
                sck.BeginReceiveFrom(kvPair.Value, 0, size, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), kvPair);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion Mesage Call Back end here
        #region encoding start here
        public byte[] EncodeMessage(List<udpEventArgs> msg)
        {
            udpEventArgs c = msg[0];
            udpEventArgs c2 = msg[1];
            byte[] pre = Encoding.Default.GetBytes(c.Preamble+",");
            byte[] fre = Encoding.Default.GetBytes(c.FrameID + ",");
            byte[] mess = Encoding.Default.GetBytes(c.Message + ",");
            byte[] pos = Encoding.Default.GetBytes(c.Postamble);
            byte[] sta = Encoding.Default.GetBytes(c2.Status+ ",");
            byte[] Usid = Encoding.Default.GetBytes(c2.UserID + ",");

            List<byte> frame = new List<byte>();
            foreach (byte preamble in pre) { frame.Add(preamble); }
            foreach(byte frameid in fre) { frame.Add(frameid); }
            foreach(byte userid in Usid) { frame.Add(userid); }
            foreach(byte status in sta) { frame.Add(status); }
            foreach(byte message in mess) { frame.Add(message); }
            foreach(byte postamble in pos) { frame.Add(postamble); }
            return frame.ToArray();
        }
        #endregion encoding end here 
        #region decoding start here
        public string DecodeMessage(byte[] data)
        {
            string mmMessage = Encoding.Default.GetString(data);
            return mmMessage;
        }
        #endregion decoding end here
        #region Send start here
        public void send()
        {
            udpEventArgs dataframe = new udpEventArgs() { Preamble = Preamble, FrameID=FrameID,Message=Message,Postamble=Postamble };
            udpEventArgs statusframe = new udpEventArgs() { Preamble = Preamble, FrameID = FrameID, UserID = UserID, Status = Status, Postamble = Postamble };
            List<udpEventArgs> pro = new List<udpEventArgs>(1);
            pro.Add(dataframe);
            pro.Add(statusframe);
             data = EncodeMessage(pro);
         sck.Send(data);
        }
        #endregion send end here
    }
    #endregion udp potr end here

    public class udpEventArgs : EventArgs
    {
        public string Message { get ; set; }
        public string Preamble { get; set; }
        public string FrameID { get; set; }
        public string UserID { get; set; }
        public string Status { get; set; }
        public string Postamble { get; set; }
        public string ReceivedData_udp { get; set; }
    }
}
