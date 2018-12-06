namespace Best
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
            this.components = new System.ComponentModel.Container();
            this.cBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.tBoxgo = new System.Windows.Forms.TextBox();
            this.tBoxreciev = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.recieverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxrtsenable = new System.Windows.Forms.CheckBox();
            this.cBoxdtrenable = new System.Windows.Forms.CheckBox();
            this.cBoxparitybits = new System.Windows.Forms.ComboBox();
            this.cBoxstopbits = new System.Windows.Forms.ComboBox();
            this.cBoxdatabits = new System.Windows.Forms.ComboBox();
            this.cBoxbaudrate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxPortSelect
            // 
            this.cBoxPortSelect.FormattingEnabled = true;
            this.cBoxPortSelect.Location = new System.Drawing.Point(125, 19);
            this.cBoxPortSelect.Name = "cBoxPortSelect";
            this.cBoxPortSelect.Size = new System.Drawing.Size(121, 21);
            this.cBoxPortSelect.TabIndex = 1;
            // 
            // tBoxgo
            // 
            this.tBoxgo.Location = new System.Drawing.Point(283, 35);
            this.tBoxgo.Name = "tBoxgo";
            this.tBoxgo.Size = new System.Drawing.Size(254, 20);
            this.tBoxgo.TabIndex = 2;
            // 
            // tBoxreciev
            // 
            this.tBoxreciev.Location = new System.Drawing.Point(283, 81);
            this.tBoxreciev.Multiline = true;
            this.tBoxreciev.Name = "tBoxreciev";
            this.tBoxreciev.Size = new System.Drawing.Size(254, 74);
            this.tBoxreciev.TabIndex = 3;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(554, 35);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(100, 23);
            this.SendMessage.TabIndex = 4;
            this.SendMessage.Text = "Send";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.comControlToolStripMenuItem,
            this.transmiterToolStripMenuItem,
            this.recieverToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.existToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.existToolStripMenuItem.Text = "Exist";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // comControlToolStripMenuItem
            // 
            this.comControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.comControlToolStripMenuItem.Name = "comControlToolStripMenuItem";
            this.comControlToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.comControlToolStripMenuItem.Text = "Com control";
            this.comControlToolStripMenuItem.Click += new System.EventHandler(this.comControlToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // transmiterToolStripMenuItem
            // 
            this.transmiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.endLineToolStripMenuItem});
            this.transmiterToolStripMenuItem.Name = "transmiterToolStripMenuItem";
            this.transmiterToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.transmiterToolStripMenuItem.Text = "Transmiter";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.endLineToolStripMenuItem.Text = "End Line";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "None",
            "Both",
            "New Line",
            "Carriage Return"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // recieverToolStripMenuItem
            // 
            this.recieverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.showDataWithToolStripMenuItem});
            this.recieverToolStripMenuItem.Name = "recieverToolStripMenuItem";
            this.recieverToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.recieverToolStripMenuItem.Text = "Reciever";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // showDataWithToolStripMenuItem
            // 
            this.showDataWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.showDataWithToolStripMenuItem.Name = "showDataWithToolStripMenuItem";
            this.showDataWithToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showDataWithToolStripMenuItem.Text = "Show data with";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Always Update",
            "Add to old data"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(554, 96);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxrtsenable);
            this.groupBox1.Controls.Add(this.cBoxdtrenable);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 178);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com port control";
            // 
            // cBoxrtsenable
            // 
            this.cBoxrtsenable.AutoSize = true;
            this.cBoxrtsenable.Location = new System.Drawing.Point(153, 161);
            this.cBoxrtsenable.Name = "cBoxrtsenable";
            this.cBoxrtsenable.Size = new System.Drawing.Size(93, 17);
            this.cBoxrtsenable.TabIndex = 11;
            this.cBoxrtsenable.Text = "RTS ENABLE";
            this.cBoxrtsenable.UseVisualStyleBackColor = true;
            this.cBoxrtsenable.CheckedChanged += new System.EventHandler(this.cBoxrtsenable_CheckedChanged);
            // 
            // cBoxdtrenable
            // 
            this.cBoxdtrenable.AutoSize = true;
            this.cBoxdtrenable.Location = new System.Drawing.Point(15, 155);
            this.cBoxdtrenable.Name = "cBoxdtrenable";
            this.cBoxdtrenable.Size = new System.Drawing.Size(91, 17);
            this.cBoxdtrenable.TabIndex = 10;
            this.cBoxdtrenable.Text = "DTRENABLE";
            this.cBoxdtrenable.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "com port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.tBoxreciev);
            this.Controls.Add(this.tBoxgo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxPortSelect;
        private System.Windows.Forms.TextBox tBoxgo;
        private System.Windows.Forms.TextBox tBoxreciev;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recieverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxrtsenable;
        private System.Windows.Forms.CheckBox cBoxdtrenable;
        private System.Windows.Forms.ComboBox cBoxparitybits;
        private System.Windows.Forms.ComboBox cBoxstopbits;
        private System.Windows.Forms.ComboBox cBoxdatabits;
        private System.Windows.Forms.ComboBox cBoxbaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
    }
}

