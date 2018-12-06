namespace Serial_port_chat
{
    partial class Setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxrtsenable = new System.Windows.Forms.CheckBox();
            this.cBoxdtrenable = new System.Windows.Forms.CheckBox();
            this.cBoxparitybits = new System.Windows.Forms.ComboBox();
            this.cBoxstopbits = new System.Windows.Forms.ComboBox();
            this.cBoxdatabits = new System.Windows.Forms.ComboBox();
            this.cBoxbaudrate = new System.Windows.Forms.ComboBox();
            this.cBoxcomport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_setting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxrtsenable);
            this.groupBox1.Controls.Add(this.cBoxdtrenable);
            this.groupBox1.Controls.Add(this.cBoxparitybits);
            this.groupBox1.Controls.Add(this.cBoxstopbits);
            this.groupBox1.Controls.Add(this.cBoxdatabits);
            this.groupBox1.Controls.Add(this.cBoxbaudrate);
            this.groupBox1.Controls.Add(this.cBoxcomport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com port control";
            // 
            // cBoxrtsenable
            // 
            this.cBoxrtsenable.AutoSize = true;
            this.cBoxrtsenable.Location = new System.Drawing.Point(188, 155);
            this.cBoxrtsenable.Name = "cBoxrtsenable";
            this.cBoxrtsenable.Size = new System.Drawing.Size(93, 17);
            this.cBoxrtsenable.TabIndex = 11;
            this.cBoxrtsenable.Text = "RTS ENABLE";
            this.cBoxrtsenable.UseVisualStyleBackColor = true;
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
            this.cBoxparitybits.Size = new System.Drawing.Size(155, 21);
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
            this.cBoxstopbits.Size = new System.Drawing.Size(155, 21);
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
            this.cBoxdatabits.Size = new System.Drawing.Size(155, 21);
            this.cBoxdatabits.TabIndex = 7;
            this.cBoxdatabits.Text = "8";
            this.cBoxdatabits.ValueMember = "8";
            // 
            // cBoxbaudrate
            // 
            this.cBoxbaudrate.FormattingEnabled = true;
            this.cBoxbaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxbaudrate.Location = new System.Drawing.Point(126, 46);
            this.cBoxbaudrate.Name = "cBoxbaudrate";
            this.cBoxbaudrate.Size = new System.Drawing.Size(155, 21);
            this.cBoxbaudrate.TabIndex = 6;
            this.cBoxbaudrate.Text = "9600";
            // 
            // cBoxcomport
            // 
            this.cBoxcomport.FormattingEnabled = true;
            this.cBoxcomport.Location = new System.Drawing.Point(126, 19);
            this.cBoxcomport.Name = "cBoxcomport";
            this.cBoxcomport.Size = new System.Drawing.Size(155, 21);
            this.cBoxcomport.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "com port";
            // 
            // Save_setting
            // 
            this.Save_setting.Location = new System.Drawing.Point(6, 11);
            this.Save_setting.Name = "Save_setting";
            this.Save_setting.Size = new System.Drawing.Size(75, 23);
            this.Save_setting.TabIndex = 2;
            this.Save_setting.Text = "Save";
            this.Save_setting.UseVisualStyleBackColor = true;
            this.Save_setting.Click += new System.EventHandler(this.Save_setting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exite);
            this.groupBox2.Controls.Add(this.Save_setting);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 39);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // Exite
            // 
            this.Exite.Location = new System.Drawing.Point(215, 11);
            this.Exite.Name = "Exite";
            this.Exite.Size = new System.Drawing.Size(75, 23);
            this.Exite.TabIndex = 3;
            this.Exite.Text = "Exit";
            this.Exite.UseVisualStyleBackColor = true;
            this.Exite.Click += new System.EventHandler(this.Exite_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxrtsenable;
        private System.Windows.Forms.CheckBox cBoxdtrenable;
        private System.Windows.Forms.ComboBox cBoxparitybits;
        private System.Windows.Forms.ComboBox cBoxstopbits;
        private System.Windows.Forms.ComboBox cBoxdatabits;
        private System.Windows.Forms.ComboBox cBoxbaudrate;
        private System.Windows.Forms.ComboBox cBoxcomport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_setting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Exite;
    }
}