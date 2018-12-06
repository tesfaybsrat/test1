namespace SimpleChatApplication
{
    partial class Udp_Setting
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
            this.Exit_udp_setting = new System.Windows.Forms.Button();
            this.Save_udp_Setting = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Localip = new System.Windows.Forms.TextBox();
            this.Remotport = new System.Windows.Forms.TextBox();
            this.Remotip = new System.Windows.Forms.TextBox();
            this.Localport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Localport);
            this.groupBox1.Controls.Add(this.Remotip);
            this.groupBox1.Controls.Add(this.Remotport);
            this.groupBox1.Controls.Add(this.Localip);
            this.groupBox1.Controls.Add(this.Exit_udp_setting);
            this.groupBox1.Controls.Add(this.Save_udp_Setting);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 248);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Udp setting control";
            // 
            // Exit_udp_setting
            // 
            this.Exit_udp_setting.Location = new System.Drawing.Point(171, 205);
            this.Exit_udp_setting.Name = "Exit_udp_setting";
            this.Exit_udp_setting.Size = new System.Drawing.Size(75, 23);
            this.Exit_udp_setting.TabIndex = 13;
            this.Exit_udp_setting.Text = "Exist";
            this.Exit_udp_setting.UseVisualStyleBackColor = true;
            this.Exit_udp_setting.Click += new System.EventHandler(this.Exit_udp_setting_Click);
            // 
            // Save_udp_Setting
            // 
            this.Save_udp_Setting.Location = new System.Drawing.Point(6, 205);
            this.Save_udp_Setting.Name = "Save_udp_Setting";
            this.Save_udp_Setting.Size = new System.Drawing.Size(75, 23);
            this.Save_udp_Setting.TabIndex = 12;
            this.Save_udp_Setting.Text = "Save";
            this.Save_udp_Setting.UseVisualStyleBackColor = true;
            this.Save_udp_Setting.Click += new System.EventHandler(this.Save_udp_Setting_Click);
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Online",
            "Offline",
            "Bussy"});
            this.Status.Location = new System.Drawing.Point(126, 127);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(120, 21);
            this.Status.TabIndex = 9;
            this.Status.Text = "Online";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remot Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remot Ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Local Ip";
            // 
            // Localip
            // 
            this.Localip.Location = new System.Drawing.Point(126, 19);
            this.Localip.Name = "Localip";
            this.Localip.Size = new System.Drawing.Size(120, 20);
            this.Localip.TabIndex = 14;
            // 
            // Remotport
            // 
            this.Remotport.Location = new System.Drawing.Point(126, 100);
            this.Remotport.Name = "Remotport";
            this.Remotport.Size = new System.Drawing.Size(120, 20);
            this.Remotport.TabIndex = 15;
            // 
            // Remotip
            // 
            this.Remotip.Location = new System.Drawing.Point(126, 74);
            this.Remotip.Name = "Remotip";
            this.Remotip.Size = new System.Drawing.Size(120, 20);
            this.Remotip.TabIndex = 16;
            // 
            // Localport
            // 
            this.Localport.Location = new System.Drawing.Point(126, 45);
            this.Localport.Name = "Localport";
            this.Localport.Size = new System.Drawing.Size(120, 20);
            this.Localport.TabIndex = 17;
            // 
            // Udp_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Udp_Setting";
            this.Text = "Udp_Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit_udp_setting;
        private System.Windows.Forms.Button Save_udp_Setting;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Localport;
        private System.Windows.Forms.TextBox Remotip;
        private System.Windows.Forms.TextBox Remotport;
        private System.Windows.Forms.TextBox Localip;
    }
}