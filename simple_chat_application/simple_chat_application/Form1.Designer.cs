namespace simple_chat_application
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
            this.button3 = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxrtsenable = new System.Windows.Forms.CheckBox();
            this.cBoxdtrenable = new System.Windows.Forms.CheckBox();
            this.cBoxparitybits = new System.Windows.Forms.ComboBox();
            this.cBoxstopbits = new System.Windows.Forms.ComboBox();
            this.cBoxdatabits = new System.Windows.Forms.ComboBox();
            this.cBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.cBoxbaudrate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReceivedText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(290, 156);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(287, 20);
            this.SendText.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 178);
            this.groupBox1.TabIndex = 11;
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
            // ReceivedText
            // 
            this.ReceivedText.Location = new System.Drawing.Point(290, 22);
            this.ReceivedText.Multiline = true;
            this.ReceivedText.Name = "ReceivedText";
            this.ReceivedText.Size = new System.Drawing.Size(342, 126);
            this.ReceivedText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 304);
            this.Controls.Add(this.ReceivedText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxrtsenable;
        private System.Windows.Forms.CheckBox cBoxdtrenable;
        private System.Windows.Forms.ComboBox cBoxparitybits;
        private System.Windows.Forms.ComboBox cBoxstopbits;
        private System.Windows.Forms.ComboBox cBoxdatabits;
        private System.Windows.Forms.ComboBox cBoxPortSelect;
        private System.Windows.Forms.ComboBox cBoxbaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReceivedText;
    }
}

