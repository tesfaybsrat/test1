using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class ChatBallon : UserControl
    {
        string chatText;
        SizeF actualChatTextSize;
        SizeF actualTimeSize;
        public Direction ChatBallonDirection { get; set; }
        public string ChatText { get { return chatText; } set { chatText = value; Invalidate(); } }
        public string Time { get; set; }

        public ChatBallon()
        {
            InitializeComponent();
            ChatBallonDirection = Direction.LeftToRight;
        }
        private void DrawBallon(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush;
            Pen pen = new Pen(Color.Red, 4);
            Point[] pathPoints = new Point[4];

            actualChatTextSize = g.MeasureString(ChatText, Font);
            actualTimeSize = g.MeasureString(Time, Font);

            int textBoxHeight = 0, textBoxWidth = 0;

            textBoxWidth = Width - ((int)actualTimeSize.Width + 50);
            textBoxHeight = (int)Math.Ceiling(actualChatTextSize.Width / txtChatText.Width) * (int)actualChatTextSize.Height;
            Height = textBoxHeight + 20;
            txtChatText.Size = new Size(textBoxWidth, textBoxHeight);

            if (ChatBallonDirection == Direction.LeftToRight)
            {
                brush = new SolidBrush(Color.FromName("ActiveCaption"));
                txtChatText.BackColor = Color.FromName("ActiveCaption");

                pathPoints[0] = new Point(5, 5);
                pathPoints[1] = new Point(Width - ((int)actualTimeSize.Width + 10), 5);
                pathPoints[2] = new Point(Width - ((int)actualTimeSize.Width + 10), Height - 5);
                pathPoints[3] = new Point(5, Height - 5);
            }
            else
            {
                brush = new SolidBrush(Color.FromName("GradientInactiveCaption"));
                txtChatText.BackColor = Color.FromName("GradientInactiveCaption");

                pathPoints[0] = new Point((int)actualTimeSize.Width + 15, 5);
                pathPoints[1] = new Point(Width - 5, 5);
                pathPoints[2] = new Point(Width - 5, Height - 5);
                pathPoints[3] = new Point((int)actualTimeSize.Width + 15, Height - 5);
            }

            g.FillPolygon(brush, pathPoints);

            if (ChatBallonDirection == Direction.LeftToRight)
            {
                txtChatText.Location = new Point(10, 10);
                g.DrawString(Time, Font, new SolidBrush(Color.Black), new Point(Width - ((int)actualTimeSize.Width + 10), (int)(Height - actualTimeSize.Height) / 2));
            }
            else
            {
                txtChatText.Location = new Point((int)actualTimeSize.Width + 20, 10);
                g.DrawString(Time, Font, new SolidBrush(Color.Black), new Point(5, (int)(Height - actualTimeSize.Height) / 2));
            }
                txtChatText.Text = ChatText;
        }
        private void DrawBallon1(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush;
            Pen pen = new Pen(Color.Red, 4);
            Point[] pathPoints = new Point[7];

            actualChatTextSize = g.MeasureString(ChatText, Font);
            int textBoxHeight = 0;

            if (actualChatTextSize.Width > txtChatText.Width)
            {
                textBoxHeight = (int)Math.Ceiling(actualChatTextSize.Width / txtChatText.Width) * (int)actualChatTextSize.Height;
                Height = textBoxHeight + 20;
            }
            if (ChatBallonDirection == Direction.LeftToRight)
            {
                brush = new SolidBrush(Color.FromName("ActiveCaption"));
                pathPoints[0] = new Point(62, Height / 2);
                pathPoints[1] = new Point(80, Height / 2 - 10);
                pathPoints[2] = new Point(80, 0);
                pathPoints[3] = new Point(ClientRectangle.Width - 10, 0);
                pathPoints[4] = new Point(ClientRectangle.Width - 10, ClientRectangle.Height);
                pathPoints[5] = new Point(80, ClientRectangle.Height);
                pathPoints[6] = new Point(80, ClientRectangle.Height / 2 + 10);

                g.FillPolygon(brush, pathPoints);

                txtChatText.Location = new Point(85, 10);
                txtChatText.Size = new Size(ClientRectangle.Width - 100, textBoxHeight + 15);
                txtChatText.Text = ChatText;
                txtChatText.BackColor = Color.FromName("ActiveCaption");
            }
            else
            {
                brush = new SolidBrush(Color.FromName("GradientInactiveCaption"));
                pathPoints[0] = new Point(ClientRectangle.Width - 62, ClientRectangle.Height / 2);
                pathPoints[1] = new Point(ClientRectangle.Width - 80, ClientRectangle.Height / 2 - 10);
                pathPoints[2] = new Point(ClientRectangle.Width - 80, 5);
                pathPoints[3] = new Point(10, 5);
                pathPoints[4] = new Point(10, ClientRectangle.Height - 5);
                pathPoints[5] = new Point(ClientRectangle.Width - 80, ClientRectangle.Height - 5);
                pathPoints[6] = new Point(ClientRectangle.Width - 80, ClientRectangle.Height / 2 + 10);

                g.FillPolygon(brush, pathPoints);

                txtChatText.Size = new Size(ClientRectangle.Width - 100, textBoxHeight);
                txtChatText.Location = new Point(ClientRectangle.Width - (85 + txtChatText.Size.Width), 10);
                txtChatText.Text = ChatText;
                txtChatText.BackColor = Color.FromName("GradientInactiveCaption");
            }
        }
        private void ChatBallon_Paint(object sender, PaintEventArgs e)
        {
            DrawBallon(e.Graphics);
        }
    }
    public enum Direction
    {
        LeftToRight,
        RightToLeft
    }
}
