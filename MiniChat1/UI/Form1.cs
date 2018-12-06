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
using Networking;

namespace UI
{
    public partial class Form1 : Form
    {
        List<User> usersList = new List<User>();
        private delegate void UpdateDisplay(Entities.TextMessage msg);
        UDPComm com;
        public Form1()
        {
            InitializeComponent();
            com = new UDPComm();
            com.TextMessageRecieved += Com_MessageRecieved;
            com.Start();
        }

        private void Com_MessageRecieved(MessageRecievedEventArgs e)
        {
            Invoke(new UpdateDisplay(UpdateDisplayPanel), new object[] { e.Message });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string displayName = Entities.Properties.Settings.Default.DisplayName; 

            string textMessage = txtSend.Text;
            Entities.TextMessage msg = new Entities.TextMessage() {
              Msg = textMessage,
                    User = new User() {
                    DisplayName = displayName,
                    Status = UserStatus.Available,
                    IPAddress = "127.0.0.1"
                }
            };
            com.Send(msg, new System.Net.IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 8000));
        }
        private void UpdateDisplayPanel(Entities.TextMessage msg)
        {
            if (msg.Type == TextMessageType.TextMessage)
            {
                txtRecieved.Text = msg.Msg;
                ChatBallon ballon = new ChatBallon() { ChatText = msg.Msg, ChatBallonDirection = Direction.LeftToRight };

                ChatBallon cb = null;
                try
                {
                    cb = (ChatBallon)panel1.Controls[panel1.Controls.Count - 1];
                    ballon.Location = new Point(0, cb.Location.Y + cb.Height);
                    panel1.Controls.Add(ballon);
                }
                catch
                {
                    panel1.Controls.Add(ballon);
                }
            }
            else if (msg.Type == TextMessageType.StatusMessage)
            {
                if (usersList.Count(x => x.IPAddress == msg.User.IPAddress) == 0)
                {
                    usersList.Add(msg.User);
                    StatusIndicator si = new StatusIndicator(msg.User.DisplayName, msg.User.Status, msg.User.IPAddress);
                    flowLayoutPanel1.Controls.Add(si);
                }
                listBox1.DataSource = usersList.Select(u => u.DisplayName).ToList<string>();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            com.Stop();
        }
    }
}
