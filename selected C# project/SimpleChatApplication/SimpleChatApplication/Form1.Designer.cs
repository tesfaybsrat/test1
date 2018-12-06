namespace SimpleChatApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SendMessage = new System.Windows.Forms.Button();
            this.tBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBoxreciev = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textRemotPort = new System.Windows.Forms.TextBox();
            this.textRemotIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxparitybits = new System.Windows.Forms.ComboBox();
            this.cBoxstopbits = new System.Windows.Forms.ComboBox();
            this.cBoxdatabits = new System.Windows.Forms.ComboBox();
            this.cBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.cBoxbaudrate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTSMIudp_serial = new System.Windows.Forms.ToolStripMenuItem();
            this.serialSettingTSMISerial = new System.Windows.Forms.ToolStripMenuItem();
            this.existTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.udpControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMIUdp = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTSMIUdp = new System.Windows.Forms.ToolStripMenuItem();
            this.serialControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMIserial = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTSMIserial = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(2, 11);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(580, 23);
            this.progressBar.TabIndex = 10;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(482, 173);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(100, 23);
            this.SendMessage.TabIndex = 9;
            this.SendMessage.Text = "Send";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // tBoxMessage
            // 
            this.tBoxMessage.Location = new System.Drawing.Point(2, 175);
            this.tBoxMessage.Name = "tBoxMessage";
            this.tBoxMessage.Size = new System.Drawing.Size(474, 20);
            this.tBoxMessage.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar);
            this.groupBox5.Controls.Add(this.SendMessage);
            this.groupBox5.Controls.Add(this.tBoxreciev);
            this.groupBox5.Controls.Add(this.tBoxMessage);
            this.groupBox5.Location = new System.Drawing.Point(5, 241);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 200);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // tBoxreciev
            // 
            this.tBoxreciev.Location = new System.Drawing.Point(2, 39);
            this.tBoxreciev.Multiline = true;
            this.tBoxreciev.Name = "tBoxreciev";
            this.tBoxreciev.Size = new System.Drawing.Size(580, 131);
            this.tBoxreciev.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(306, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 194);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textLocalPort);
            this.groupBox2.Controls.Add(this.textLocalIP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 86);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sender ";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(76, 51);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(184, 20);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(76, 16);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(184, 20);
            this.textLocalIP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRemotPort);
            this.groupBox3.Controls.Add(this.textRemotIP);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(6, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 86);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver";
            // 
            // textRemotPort
            // 
            this.textRemotPort.Location = new System.Drawing.Point(81, 53);
            this.textRemotPort.Name = "textRemotPort";
            this.textRemotPort.Size = new System.Drawing.Size(184, 20);
            this.textRemotPort.TabIndex = 5;
            // 
            // textRemotIP
            // 
            this.textRemotIP.Location = new System.Drawing.Point(81, 16);
            this.textRemotIP.Name = "textRemotIP";
            this.textRemotIP.Size = new System.Drawing.Size(184, 20);
            this.textRemotIP.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "data bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "baud rate";
            // 
            // cBoxparitybits
            // 
            this.cBoxparitybits.FormattingEnabled = true;
            this.cBoxparitybits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxparitybits.Location = new System.Drawing.Point(126, 127);
            this.cBoxparitybits.Name = "cBoxparitybits";
            this.cBoxparitybits.Size = new System.Drawing.Size(120, 21);
            this.cBoxparitybits.TabIndex = 9;
            this.cBoxparitybits.Text = "None";
            // 
            // cBoxstopbits
            // 
            this.cBoxstopbits.DisplayMember = "one";
            this.cBoxstopbits.FormattingEnabled = true;
            this.cBoxstopbits.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.cBoxstopbits.Location = new System.Drawing.Point(126, 100);
            this.cBoxstopbits.Name = "cBoxstopbits";
            this.cBoxstopbits.Size = new System.Drawing.Size(120, 21);
            this.cBoxstopbits.TabIndex = 8;
            this.cBoxstopbits.Tag = "";
            this.cBoxstopbits.Text = "One";
            // 
            // cBoxdatabits
            // 
            this.cBoxdatabits.DisplayMember = "8";
            this.cBoxdatabits.FormattingEnabled = true;
            this.cBoxdatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxdatabits.Location = new System.Drawing.Point(126, 73);
            this.cBoxdatabits.Name = "cBoxdatabits";
            this.cBoxdatabits.Size = new System.Drawing.Size(120, 21);
            this.cBoxdatabits.TabIndex = 7;
            this.cBoxdatabits.Text = "8";
            this.cBoxdatabits.ValueMember = "8";
            // 
            // cBoxPortSelect
            // 
            this.cBoxPortSelect.FormattingEnabled = true;
            this.cBoxPortSelect.Location = new System.Drawing.Point(125, 19);
            this.cBoxPortSelect.Name = "cBoxPortSelect";
            this.cBoxPortSelect.Size = new System.Drawing.Size(121, 21);
            this.cBoxPortSelect.TabIndex = 1;
            // 
            // cBoxbaudrate
            // 
            this.cBoxbaudrate.FormattingEnabled = true;
            this.cBoxbaudrate.Location = new System.Drawing.Point(126, 46);
            this.cBoxbaudrate.Name = "cBoxbaudrate";
            this.cBoxbaudrate.Size = new System.Drawing.Size(120, 21);
            this.cBoxbaudrate.TabIndex = 6;
            this.cBoxbaudrate.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "parity bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "stop bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "com port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxparitybits);
            this.groupBox1.Controls.Add(this.cBoxstopbits);
            this.groupBox1.Controls.Add(this.cBoxdatabits);
            this.groupBox1.Controls.Add(this.cBoxPortSelect);
            this.groupBox1.Controls.Add(this.cBoxbaudrate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 194);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.udpControlToolStripMenuItem,
            this.serialControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTSMIudp_serial,
            this.serialSettingTSMISerial,
            this.existTSMI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetTSMIudp_serial
            // 
            this.resetTSMIudp_serial.Name = "resetTSMIudp_serial";
            this.resetTSMIudp_serial.Size = new System.Drawing.Size(142, 22);
            this.resetTSMIudp_serial.Text = "Reset";
            this.resetTSMIudp_serial.Click += new System.EventHandler(this.resetTSMIudp_serial_Click);
            // 
            // serialSettingTSMISerial
            // 
            this.serialSettingTSMISerial.Name = "serialSettingTSMISerial";
            this.serialSettingTSMISerial.Size = new System.Drawing.Size(142, 22);
            this.serialSettingTSMISerial.Text = "Serial Setting";
            this.serialSettingTSMISerial.Click += new System.EventHandler(this.serialSettingTSMISerial_Click);
            // 
            // existTSMI
            // 
            this.existTSMI.Name = "existTSMI";
            this.existTSMI.Size = new System.Drawing.Size(142, 22);
            this.existTSMI.Text = "Exist";
            this.existTSMI.Click += new System.EventHandler(this.existTSMI_Click);
            // 
            // udpControlToolStripMenuItem
            // 
            this.udpControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTSMIUdp,
            this.closeTSMIUdp});
            this.udpControlToolStripMenuItem.Name = "udpControlToolStripMenuItem";
            this.udpControlToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.udpControlToolStripMenuItem.Text = "Udp Control";
            // 
            // openTSMIUdp
            // 
            this.openTSMIUdp.Name = "openTSMIUdp";
            this.openTSMIUdp.Size = new System.Drawing.Size(152, 22);
            this.openTSMIUdp.Text = "Open";
            this.openTSMIUdp.Click += new System.EventHandler(this.openTSMIUdp_Click);
            // 
            // closeTSMIUdp
            // 
            this.closeTSMIUdp.Name = "closeTSMIUdp";
            this.closeTSMIUdp.Size = new System.Drawing.Size(152, 22);
            this.closeTSMIUdp.Text = "Close";
            this.closeTSMIUdp.Click += new System.EventHandler(this.closeTSMIUdp_Click);
            // 
            // serialControlToolStripMenuItem
            // 
            this.serialControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTSMIserial,
            this.closeTSMIserial});
            this.serialControlToolStripMenuItem.Name = "serialControlToolStripMenuItem";
            this.serialControlToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.serialControlToolStripMenuItem.Text = "Serial Control";
            // 
            // openTSMIserial
            // 
            this.openTSMIserial.Name = "openTSMIserial";
            this.openTSMIserial.Size = new System.Drawing.Size(152, 22);
            this.openTSMIserial.Text = "Open";
            this.openTSMIserial.Click += new System.EventHandler(this.openTSMIserial_Click);
            // 
            // closeTSMIserial
            // 
            this.closeTSMIserial.Name = "closeTSMIserial";
            this.closeTSMIserial.Size = new System.Drawing.Size(152, 22);
            this.closeTSMIserial.Text = "Close";
            this.closeTSMIserial.Click += new System.EventHandler(this.closeTSMIserial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 444);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Chat Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.TextBox tBoxMessage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tBoxreciev;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRemotPort;
        private System.Windows.Forms.TextBox textRemotIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxparitybits;
        private System.Windows.Forms.ComboBox cBoxstopbits;
        private System.Windows.Forms.ComboBox cBoxdatabits;
        private System.Windows.Forms.ComboBox cBoxPortSelect;
        private System.Windows.Forms.ComboBox cBoxbaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem udpControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTSMIUdp;
        private System.Windows.Forms.ToolStripMenuItem closeTSMIUdp;
        private System.Windows.Forms.ToolStripMenuItem serialControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTSMIserial;
        private System.Windows.Forms.ToolStripMenuItem closeTSMIserial;
        private System.Windows.Forms.ToolStripMenuItem resetTSMIudp_serial;
        private System.Windows.Forms.ToolStripMenuItem serialSettingTSMISerial;
        private System.Windows.Forms.ToolStripMenuItem existTSMI;
    }
}

