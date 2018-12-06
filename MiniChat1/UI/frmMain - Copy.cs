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
    public partial class frmMain : Form
    {
        int x, y;
        bool mousePressed = false;
        List<User> usersList = new List<User>();
        List<frmChatWindow> chatWindows = new List<frmChatWindow>();
        private delegate void UpdateDisplay(Entities.Message msg);
        public User Me { get; set; }
        UDPComm com;

        private FormState frmState;
        public frmMain()
        {
            InitializeComponent();
            frmState = FormState.Maximize;
            com = new UDPComm();
            com.MessageRecieved += Com_MessageRecieved;
            Me = new User(Entities.Properties.Settings.Default.DisplayName, (UserStatus)Entities.Properties.Settings.Default.Status, com.GetMyIPAddress());
            com.Start();
        }

        private void Com_MessageRecieved(MessageRecievedEventArgs e)
        {
            Invoke(new UpdateDisplay(UpdateDisplayPanel), new object[] { e.Message });
        }
        private void UpdateDisplayPanel(Entities.Message msg)
        {
            if (msg.Type == MessageType.TextMessage)
            {
                if (msg.User.IPAddress != Me.IPAddress)
                {
                    try
                    {
                        frmChatWindow frm = chatWindows.Where(f => f.SI.IpAddress == msg.User.IPAddress).FirstOrDefault();
                        if (frm == null)
                        {
                            frm = new frmChatWindow(new StatusIndicator(msg.User.DisplayName, msg.User.Status, msg.User.IPAddress));
                            frm.FormClosing += Frm_FormClosing;
                            Me = new User(Entities.Properties.Settings.Default.DisplayName, (UserStatus)Entities.Properties.Settings.Default.Status, com.GetMyIPAddress());

                            frm.ClientIPAddress = msg.User.IPAddress;
                            frm.Me = Me;

                            if (chatWindows.Count(x => x.SI.IpAddress == msg.User.IPAddress) == 0)
                            {
                                chatWindows.Add(frm);
                            }
                            //frm.DisplayChat(msg);
                            if (Me.Status == UserStatus.Available)
                            {
                                frm.Show();
                            }
                            else //This is for testing purpose
                            {
                                foreach (StatusIndicator s in flContainer.Controls)
                                {
                                    if (msg.User.IPAddress == s.IpAddress)
                                    {
                                        s.NumberOfUnreadMessages++;
                                        break;
                                    }
                                }
                            }
                            frm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (Width + frm.Width), Screen.PrimaryScreen.WorkingArea.Height - frm.Height);
                        }
                        else //This is for testing purpose
                        {
                            foreach (StatusIndicator s in flContainer.Controls)
                            {
                                if (msg.User.IPAddress == s.IpAddress)
                                {
                                    s.NumberOfUnreadMessages++;
                                    break;
                                }
                            }
                        }
                        frm.DisplayChat(msg);

                    }
                    catch
                    {

                    }
                }
            }
            else if (msg.Type == MessageType.StatusMessage)
            {
                if (usersList.Count(x => x.IPAddress == msg.User.IPAddress) == 0)
                {
                    usersList.Add(msg.User);
                    StatusIndicator si = new StatusIndicator(msg.User.DisplayName, msg.User.Status, msg.User.IPAddress);
                    si.Click += Si_Click;
                    si.Width = flContainer.Width - 2;
                    flContainer.Controls.Add(si);
                }
                else
                {
                    int index = usersList.IndexOf(usersList.Where(x => x.IPAddress == msg.User.IPAddress).First());
                    ((StatusIndicator)flContainer.Controls[index]).Status = msg.User.Status;
                    ((StatusIndicator)flContainer.Controls[index]).DisplayName = msg.User.DisplayName;
                }
            }
        }

        private void Si_Click(object sender, EventArgs e)
        {
            StatusIndicator si = (StatusIndicator)sender;
            frmChatWindow frm = new frmChatWindow(si);
            frm.FormClosing += Frm_FormClosing;
            Me = new User(Entities.Properties.Settings.Default.DisplayName, (UserStatus)Entities.Properties.Settings.Default.Status, com.GetMyIPAddress());

            frm.ClientIPAddress = si.IpAddress;
            frm.Me = Me;

            if (chatWindows.Count(x => x.SI.IpAddress == si.IpAddress) == 0)
            {
                chatWindows.Add(frm);
            }
            frm.Show();
            frm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (Width + frm.Width), Screen.PrimaryScreen.WorkingArea.Height - frm.Height);
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChatWindow frm = (frmChatWindow)sender;
            int index = chatWindows.IndexOf(chatWindows.Where(x => x.SI.IpAddress == frm.SI.IpAddress).First());
            chatWindows.RemoveAt(index);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.WorkingArea.Width / 8;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (Width + 0), 0);
            ddlStatus.DataSource = Enum.GetNames(typeof(Entities.UserStatus));
            //ddlStatus.SelectedIndex = Entities.Properties.Settings.Default.Status;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            frmState = frmState == FormState.Maximize ? FormState.Minimize : FormState.Maximize;

            if (frmState == FormState.Minimize)
            {
                Height = pnlHeader.Height;
                btnMinimize.Text = "";
            }
            else
            {
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                btnMinimize.Text = "";
            }
        }

        private void ChangeFormSize()
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new UI.frmSettings();
            frm.ShowDialog();
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entities.Properties.Settings.Default.Status = ddlStatus.SelectedIndex;
            Entities.Properties.Settings.Default.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit from this application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
                Application.Exit();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            mousePressed = true;
        }
    }
    public enum FormState
    {
        Maximize,
        Minimize
    }
}
