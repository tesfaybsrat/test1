using Entities;
using Entities.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Networking
{
    public delegate void MessageRecievedEventHandler (MessageRecievedEventArgs e);
    public delegate void FileMessageRecievedEventHandler(FileMessageRecievedEventArgs e);

    public class MessageRecievedEventArgs : EventArgs
    {
        public TextMessage Message { get; set; }
        public MessageRecievedEventArgs(TextMessage msg)
        {
            Message = msg;
        }
    }
    public class FileMessageRecievedEventArgs : EventArgs
    {
        public FileMessage Message { get; set; }
        public FileMessageRecievedEventArgs(FileMessage msg)
        {
            Message = msg;
        }
    }


    public class UDPComm
    {
        User me;
        public event MessageRecievedEventHandler TextMessageRecieved;
        public event FileMessageRecievedEventHandler FileMessageRecieved;
        IPEndPoint ipEndPoint;
        IPEndPoint broadcastEndPoint;
        EndPoint ep;
        byte[] data;
        int size = 1024;

        public Socket socket { get; set; }
        public Socket broadcastSocket { get; set; }
        public TextMessage Msg { get; set; }

        Thread thread;
        Thread broadcastTread;
        private KeyValuePair<Socket, byte[]> kvPair = new KeyValuePair<Socket, byte[]>();

        public UDPComm()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Any, 8000);
            broadcastEndPoint = new IPEndPoint(IPAddress.Broadcast, 8000);
            thread = new Thread(Listen);
            broadcastTread = new Thread(BroadcastMessage);
        }
        public void Start()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                broadcastSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                broadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
                socket.Bind(ipEndPoint);
                //socket.BeginAccept(new AsyncCallback(AcceptCon), thread);
                thread.Start();
                broadcastTread.Start();
            }
            catch { }
        }
        private void BroadcastMessage()
        {
            try
            {
                me = new User() { DisplayName = Entities.Properties.Settings.Default.DisplayName,
                    Status = (UserStatus)Entities.Properties.Settings.Default.Status, IPAddress = GetMyIPAddress() };

                TextMessage msg = new TextMessage() { Msg = "broadcast test", Type = TextMessageType.StatusMessage, User = me };
                byte[] testdata = TextMessage.EncodeMessage(msg);
                broadcastSocket.SendTo(testdata, broadcastEndPoint);
                Thread.Sleep(5000);
                //BroadcastMessage();
            }
            catch { }
        }

        public void Stop()
        {
            socket.Close();
            broadcastSocket.Close();
        }
        public void Listen()
        {
            ep = ipEndPoint;
            kvPair = new KeyValuePair<Socket, byte[]>(socket, new byte[size]);
            socket.BeginReceiveFrom(kvPair.Value, 0, size, SocketFlags.None, ref ep,  new AsyncCallback(RecieveData), kvPair);
        }
        private void RecieveData(IAsyncResult iar)
        {
            try
            {
                ep = ipEndPoint;
                kvPair = (KeyValuePair<Socket, byte[]>)iar.AsyncState;
                int recv = kvPair.Key.EndReceiveFrom(iar, ref ep);
                if (recv > 0)
                {
                    string preamble = Encoding.Default.GetString(kvPair.Value, 0, 2);
                    if (preamble == "AA")
                    {
                        Msg = TextMessage.DecodeMessage(kvPair.Value);
                        if (TextMessageRecieved != null)
                            TextMessageRecieved(new MessageRecievedEventArgs(Msg));
                    }
                    else if (preamble == "BB")
                    {
                        FileMessage msg = FileMessage.DecodeMessage(kvPair.Value);
                        if (FileMessageRecieved != null)
                            FileMessageRecieved(new FileMessageRecievedEventArgs(msg));
                    }
                }
                Listen();
            }
            catch(Exception ex) { }
        }
        public void Send(TextMessage msg, IPEndPoint ipEp)
        {
            try
            {
                data = TextMessage.EncodeMessage(msg);
                socket.BeginSendTo(data, 0, data.Length, SocketFlags.None, ipEp, new AsyncCallback(SendData), socket);
            }
            catch (Exception ex) { }
        }
        public void Send(FileMessage msg, IPEndPoint ipEp)
        {
            try
            {
                data = FileMessage.EncodeMessage(msg);
                socket.BeginSendTo(data, 0, data.Length, SocketFlags.None, ipEp, new AsyncCallback(SendData), socket);
            }
            catch (Exception ex) { }
        }
        private void SendData(IAsyncResult iar)
        {
            Socket sock = (Socket)iar.AsyncState;
            sock.EndSendTo(iar);
        }

        public string GetMyIPAddress()
        {
            string ip = null;
            // Resolves a host name or IP address to an IPHostEntry instance.	    
            // IPHostEntry - Provides a container class for Internet host address information.            
            IPHostEntry ipHostEntry = System.Net.Dns.GetHostEntry(Dns.GetHostName());
            try
            {
                // IPAddress class contains the address of a computer on an IP network.	    
                foreach (IPAddress ipAdd in ipHostEntry.AddressList)
                {
                    // InterNetwork indicates that an IP version 4 address is expected	        
                    // when a Socket connects to an endpoint	       
                    if (ipAdd.AddressFamily.ToString() == "InterNetwork")
                    {
                        if (ipAdd.ToString() != "127.0.0.1")
                            ip = ipAdd.ToString();
                        //if (ip == "127.0.0.1")
                        //{
                        //    MessageBox.Show("Please, Check for Network Connection Default IP set to 127.0.0.1");
                        //    break;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            if (string.IsNullOrEmpty(ip))
                ip = "127.0.0.1";

            return ip;
        }
    }

}