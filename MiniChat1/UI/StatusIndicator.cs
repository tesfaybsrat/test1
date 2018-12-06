using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;

namespace UI
{
    //public delegate void UserStatusChangedEventHandler(object sender, EventArgs e);
    public partial class StatusIndicator : UserControl
    {
        #region Variables
        //public event UserStatusChangedEventHandler StatusChanged;
        Color statusColor = Color.Black;
        SolidBrush brush;
        Pen pen;
        int offset = 6;
        int numberOfUnreadMessages = 0;
        UserStatus status;
        #endregion
        #region Properties
        public string DisplayName { set; get; }
        public string IpAddress { get; set; }
        public int NumberOfUnreadMessages
        {
            get
            {
                return numberOfUnreadMessages;
            }
            set
            {
                numberOfUnreadMessages = value;
                Invalidate();
            }
        }
        public UserStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                DrawStatusIndicator(this.CreateGraphics());
                lblDisplayName.Text = DisplayName;
                lblStatus.Text = status.ToString();
            }
        }
        #endregion

        public StatusIndicator()
        {
            InitializeComponent();
        }
        public StatusIndicator(string displayName, UserStatus s, string ipAddress)
        {
            InitializeComponent();
            DisplayName = displayName;
            this.Status = s;
            IpAddress = ipAddress;
        }

        private void StatusIndicator_Paint(object sender, PaintEventArgs e)
        {
            DrawStatusIndicator(e.Graphics);
        }

        private void DrawStatusIndicator(Graphics g)
        {
            int size = 2 * offset;
            Size rectangleSize = new Size(size, size);
            string strNumberOfUnreadMessages = NumberOfUnreadMessages > 9 ? "9+" : NumberOfUnreadMessages.ToString();
            SizeF NumberOfUnreadMessagesSize = g.MeasureString(NumberOfUnreadMessages.ToString(), Font);

            Point pntunreadMessages = new Point((int)((Width - NumberOfUnreadMessagesSize.Width - 5)), (int)((Height - NumberOfUnreadMessagesSize.Width) / 2));
            Rectangle rctNumberOfUnreadMessages = new Rectangle(pntunreadMessages.X - 1, pntunreadMessages.Y - 1, (int)NumberOfUnreadMessagesSize.Height + 2, (int)NumberOfUnreadMessagesSize.Height + 2);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, ClientRectangle);

            pen = new Pen(Color.DarkGray, 1);
            g.DrawLine(pen, 0, Height - 1, Width, Height - 1);
            if (Status == UserStatus.Available)
                statusColor = Color.Green;
            else if (Status == UserStatus.UnAvailable)
            {
                statusColor = Color.Red;
                brush = new SolidBrush(Color.Blue);
                if (numberOfUnreadMessages > 0)
                {
                    g.FillEllipse(brush, rctNumberOfUnreadMessages);
                    brush = new SolidBrush(Color.White);
                    g.DrawString(strNumberOfUnreadMessages, Font, brush, pntunreadMessages);
                }
            }
            else if (Status == UserStatus.Bussy)
                statusColor = Color.Gold;
            else
                statusColor = Color.Gray;

            brush = new SolidBrush(statusColor);
            Point point = new Point(offset, 0);
            Rectangle rect = new Rectangle(point, rectangleSize);
            g.FillEllipse(brush, rect);
        }

        private void StatusIndicator_MouseHover(object sender, EventArgs e)
        {
            //ttpStatusIndicator.Show(Status.ToString(), this, 6, 1);
        }
    }
}
