namespace scheduleApp
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
            this.save = new System.Windows.Forms.Button();
            this.majoractivities = new System.Windows.Forms.TextBox();
            this.read = new System.Windows.Forms.Button();
            this.datafrom = new System.Windows.Forms.TextBox();
            this.dateeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.impname = new System.Windows.Forms.TextBox();
            this.bodysinger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.workdir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(3, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(136, 23);
            this.save.TabIndex = 0;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // majoractivities
            // 
            this.majoractivities.Location = new System.Drawing.Point(3, 167);
            this.majoractivities.Multiline = true;
            this.majoractivities.Name = "majoractivities";
            this.majoractivities.Size = new System.Drawing.Size(447, 151);
            this.majoractivities.TabIndex = 1;
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(145, 3);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(156, 23);
            this.read.TabIndex = 2;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // datafrom
            // 
            this.datafrom.Location = new System.Drawing.Point(161, 35);
            this.datafrom.Name = "datafrom";
            this.datafrom.Size = new System.Drawing.Size(127, 20);
            this.datafrom.TabIndex = 3;
            // 
            // dateeto
            // 
            this.dateeto.Location = new System.Drawing.Point(323, 35);
            this.dateeto.Name = "dateeto";
            this.dateeto.Size = new System.Drawing.Size(127, 20);
            this.dateeto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Outcome Assessment Time From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Full name of the implementer";
            // 
            // impname
            // 
            this.impname.Location = new System.Drawing.Point(161, 64);
            this.impname.Name = "impname";
            this.impname.Size = new System.Drawing.Size(289, 20);
            this.impname.TabIndex = 9;
            // 
            // bodysinger
            // 
            this.bodysinger.Location = new System.Drawing.Point(161, 116);
            this.bodysinger.Name = "bodysinger";
            this.bodysinger.Size = new System.Drawing.Size(289, 20);
            this.bodysinger.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "The body of the singer";
            // 
            // workdir
            // 
            this.workdir.Location = new System.Drawing.Point(161, 90);
            this.workdir.Name = "workdir";
            this.workdir.Size = new System.Drawing.Size(289, 20);
            this.workdir.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Working Directorate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Major activities";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 327);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.workdir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bodysinger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.impname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateeto);
            this.Controls.Add(this.datafrom);
            this.Controls.Add(this.read);
            this.Controls.Add(this.majoractivities);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox majoractivities;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.TextBox datafrom;
        private System.Windows.Forms.TextBox dateeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox impname;
        private System.Windows.Forms.TextBox bodysinger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox workdir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

