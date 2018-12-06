namespace School
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.tage = new System.Windows.Forms.TextBox();
            this.tgender = new System.Windows.Forms.TextBox();
            this.tcolor = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tname
            // 
            resources.ApplyResources(this.tname, "tname");
            this.tname.Name = "tname";
            // 
            // tage
            // 
            resources.ApplyResources(this.tage, "tage");
            this.tage.Name = "tage";
            // 
            // tgender
            // 
            resources.ApplyResources(this.tgender, "tgender");
            this.tgender.Name = "tgender";
            // 
            // tcolor
            // 
            resources.ApplyResources(this.tcolor, "tcolor");
            this.tcolor.Name = "tcolor";
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Result
            // 
            resources.ApplyResources(this.Result, "Result");
            this.Result.Name = "Result";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.tcolor);
            this.Controls.Add(this.tgender);
            this.Controls.Add(this.tage);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tage;
        private System.Windows.Forms.TextBox tgender;
        private System.Windows.Forms.TextBox tcolor;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Result;
    }
}

