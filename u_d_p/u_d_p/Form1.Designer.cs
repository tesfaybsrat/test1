namespace u_d_p
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
            this.bSTART = new System.Windows.Forms.Button();
            this.bSEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tIP = new System.Windows.Forms.TextBox();
            this.tPORT = new System.Windows.Forms.TextBox();
            this.tTTL = new System.Windows.Forms.TextBox();
            this.tSEND = new System.Windows.Forms.TextBox();
            this.tRECIEVE = new System.Windows.Forms.TextBox();
            this.tNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bSTART
            // 
            this.bSTART.Location = new System.Drawing.Point(63, 156);
            this.bSTART.Name = "bSTART";
            this.bSTART.Size = new System.Drawing.Size(75, 23);
            this.bSTART.TabIndex = 0;
            this.bSTART.Text = "Start";
            this.bSTART.UseVisualStyleBackColor = true;
            this.bSTART.Click += new System.EventHandler(this.bSTART_Click);
            // 
            // bSEND
            // 
            this.bSEND.Location = new System.Drawing.Point(557, 12);
            this.bSEND.Name = "bSEND";
            this.bSEND.Size = new System.Drawing.Size(75, 23);
            this.bSEND.TabIndex = 1;
            this.bSEND.Text = "Send";
            this.bSEND.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TTl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(63, 49);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(100, 20);
            this.tIP.TabIndex = 5;
            // 
            // tPORT
            // 
            this.tPORT.Location = new System.Drawing.Point(63, 84);
            this.tPORT.Name = "tPORT";
            this.tPORT.Size = new System.Drawing.Size(100, 20);
            this.tPORT.TabIndex = 6;
            // 
            // tTTL
            // 
            this.tTTL.Location = new System.Drawing.Point(63, 116);
            this.tTTL.Name = "tTTL";
            this.tTTL.Size = new System.Drawing.Size(100, 20);
            this.tTTL.TabIndex = 7;
            // 
            // tSEND
            // 
            this.tSEND.Location = new System.Drawing.Point(283, 15);
            this.tSEND.Multiline = true;
            this.tSEND.Name = "tSEND";
            this.tSEND.Size = new System.Drawing.Size(228, 26);
            this.tSEND.TabIndex = 8;
            // 
            // tRECIEVE
            // 
            this.tRECIEVE.Location = new System.Drawing.Point(283, 64);
            this.tRECIEVE.Multiline = true;
            this.tRECIEVE.Name = "tRECIEVE";
            this.tRECIEVE.Size = new System.Drawing.Size(228, 72);
            this.tRECIEVE.TabIndex = 9;
            // 
            // tNAME
            // 
            this.tNAME.Location = new System.Drawing.Point(63, 15);
            this.tNAME.Name = "tNAME";
            this.tNAME.Size = new System.Drawing.Size(100, 20);
            this.tNAME.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(178, 78);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(78, 19);
            this.progressBar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 261);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tNAME);
            this.Controls.Add(this.tRECIEVE);
            this.Controls.Add(this.tSEND);
            this.Controls.Add(this.tTTL);
            this.Controls.Add(this.tPORT);
            this.Controls.Add(this.tIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSEND);
            this.Controls.Add(this.bSTART);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSTART;
        private System.Windows.Forms.Button bSEND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.TextBox tPORT;
        private System.Windows.Forms.TextBox tTTL;
        private System.Windows.Forms.TextBox tSEND;
        private System.Windows.Forms.TextBox tRECIEVE;
        private System.Windows.Forms.TextBox tNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

