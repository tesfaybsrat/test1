using Entities;
using Networking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmChatWindow : Form
    {
        private delegate void UpdateDisplay(Entities.TextMessage msg);
        int x, y;
        bool mousePressed = false;
        public string ClientIPAddress { get; set; }
        public StatusIndicator SI { get; set; }
        public Entities.User Me { get; set; }
        Direction chatBallonDirection = Direction.LeftToRight;
        UDPComm com;
        public frmChatWindow()
        {
            InitializeComponent();
            com = new UDPComm();
            Me = new Entities.User(Entities.Properties.Settings.Default.DisplayName, (UserStatus)Entities.Properties.Settings.Default.Status, com.GetMyIPAddress());
            com.TextMessageRecieved += Com_MessageRecieved;
            com.Start();
        }
        public frmChatWindow(StatusIndicator si)
        {
            InitializeComponent();
            SI = si;
            Me = new Entities.User();
            com = new UDPComm();
            com.TextMessageRecieved += Com_MessageRecieved;
            com.Start();
        }

        private void UpdateDisplayPanel(Entities.TextMessage msg)
        {
            if (msg.Type == TextMessageType.TextMessage)
            {
                //txtRecieved.Text = msg.Msg;
                ChatBallon ballon = new ChatBallon() { ChatText = msg.Msg, ChatBallonDirection = Direction.LeftToRight };
                int top = 0;
                //ChatBallon cb = null;
                try
                {
                    //cb = (ChatBallon)pnlChatDisplay.Controls[pnlChatDisplay.Controls.Count - 1];

                    foreach (Control c in pnlChatDisplay.Controls)
                    {
                        top += c.Height;
                    }
                    ballon.Location = new Point(0, top);
                    pnlChatDisplay.Controls.Add(ballon);
                }
                catch
                {
                    //pnlChatDisplay.Controls.Add(ballon);
                }
            }
            //else if (msg.Type == MessageType.StatusMessage)
            //{
            //    //if (usersList.Count(x => x.IPAddress == msg.User.IPAddress) == 0)
            //    //{
            //    //    usersList.Add(msg.User);
            //    //    StatusIndicator si = new StatusIndicator(msg.User.DisplayName, msg.User.Status, msg.User.IPAddress);
            //    //    flowLayoutPanel1.Controls.Add(si);
            //    //}
            //    //listBox1.DataSource = usersList.Select(u => u.DisplayName).ToList<string>();

            //}
        }

        public void DisplayChat(Entities.TextMessage msg)
        {
            ChatBallon ballon = new UI.ChatBallon();
            ballon.ChatText = msg.Msg;
            ballon.Time = DateTime.Now.ToShortTimeString();
            ballon.ChatBallonDirection = msg.User.IPAddress == com.GetMyIPAddress() ? Direction.LeftToRight : Direction.RightToLeft;

            int top = 0;
            foreach (Control c in pnlChatDisplay.Controls)
            {
                top += c.Height + 10;
            }
            if (com.GetMyIPAddress() == msg.User.IPAddress)
                ballon.Location = new Point(0, top);
            else
                ballon.Location = new Point(pnlChatDisplay.Width - ballon.Width, top);

            ballon.Size = new Size(pnlChatDisplay.Width - 20, ballon.Height);
            pnlChatDisplay.Controls.Add(ballon);

        }

        private void Com_MessageRecieved(MessageRecievedEventArgs e)
        {
            //chatBallonDirection = Direction.RightToLeft;
            //Invoke(new UpdateDisplay(UpdateDisplayPanel), new object[] { e.Message });
        }

        private void frmChatWindow_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = SI.DisplayName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            mousePressed = true;
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string textMessage = txtChatText.Text;
            Entities.TextMessage msg = new Entities.TextMessage() { Type = TextMessageType.TextMessage, Msg = textMessage, User = Me };
            chatBallonDirection = Direction.LeftToRight;
            com.Send(msg, new System.Net.IPEndPoint(System.Net.IPAddress.Parse(ClientIPAddress), 8000));
            txtChatText.Focus();
            txtChatText.Text = "";
            UpdateDisplayPanel(msg);
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileMessage msg = new FileMessage()
                {
                    Preamble = "BB",
                    FileName = dlg.FileName,
                    FileMessageType = FileMessageType.Responese,
                    FileStatus = FileStatus.NotStarted,
                    Index = 0,
                    IpAddress = com.GetMyIPAddress(),
                    FileNameLength = dlg.FileName.Length,
                    IPLength = com.GetMyIPAddress().Length,
                    Data = new byte[1]
                };
                com.Send(msg, new System.Net.IPEndPoint(System.Net.IPAddress.Parse(ClientIPAddress), 8000));
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
        }
    }
}