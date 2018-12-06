namespace Udp_chatform
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupAddress = new System.Windows.Forms.TextBox();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.LocalPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TTL = new System.Windows.Forms.TextBox();
            this.Save_Setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remot Port";
            // 
            // GroupAddress
            // 
            this.GroupAddress.Location = new System.Drawing.Point(179, 36);
            this.GroupAddress.Name = "GroupAddress";
            this.GroupAddress.Size = new System.Drawing.Size(100, 20);
            this.GroupAddress.TabIndex = 3;
            // 
            // RemotePort
            // 
            this.RemotePort.Location = new System.Drawing.Point(179, 128);
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(100, 20);
            this.RemotePort.TabIndex = 4;
            // 
            // LocalPort
            // 
            this.LocalPort.Location = new System.Drawing.Point(179, 87);
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.Size = new System.Drawing.Size(100, 20);
            this.LocalPort.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TTL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TTL
            // 
            this.TTL.Location = new System.Drawing.Point(179, 165);
            this.TTL.Name = "TTL";
            this.TTL.Size = new System.Drawing.Size(100, 20);
            this.TTL.TabIndex = 7;
            // 
            // Save_Setting
            // 
            this.Save_Setting.Location = new System.Drawing.Point(352, 46);
            this.Save_Setting.Name = "Save_Setting";
            this.Save_Setting.Size = new System.Drawing.Size(75, 23);
            this.Save_Setting.TabIndex = 8;
            this.Save_Setting.Text = "SAVE";
            this.Save_Setting.UseVisualStyleBackColor = true;
            this.Save_Setting.Click += new System.EventHandler(this.Save_Setting_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 214);
            this.Controls.Add(this.Save_Setting);
            this.Controls.Add(this.TTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LocalPort);
            this.Controls.Add(this.RemotePort);
            this.Controls.Add(this.GroupAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GroupAddress;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.TextBox LocalPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TTL;
        private System.Windows.Forms.Button Save_Setting;
    }
}