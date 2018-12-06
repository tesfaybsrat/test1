namespace classbasedMASD
{
    partial class AMDS
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
            this.tBox3 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.div = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.parameter_based_multiplication = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBox3);
            this.groupBox1.Controls.Add(this.tBox2);
            this.groupBox1.Controls.Add(this.tBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AMDS Calculator";
            // 
            // tBox3
            // 
            this.tBox3.Location = new System.Drawing.Point(161, 113);
            this.tBox3.Name = "tBox3";
            this.tBox3.Size = new System.Drawing.Size(181, 20);
            this.tBox3.TabIndex = 5;
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(161, 69);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(181, 20);
            this.tBox2.TabIndex = 4;
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(161, 25);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(181, 20);
            this.tBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.div);
            this.groupBox2.Controls.Add(this.sub);
            this.groupBox2.Controls.Add(this.mul);
            this.groupBox2.Controls.Add(this.sum);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(276, 20);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(78, 23);
            this.div.TabIndex = 3;
            this.div.Text = "Div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(192, 20);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(78, 23);
            this.sub.TabIndex = 2;
            this.sub.Text = "Sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(91, 20);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(78, 23);
            this.mul.TabIndex = 1;
            this.mul.Text = "Mult";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(7, 20);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(78, 23);
            this.sum.TabIndex = 0;
            this.sum.Text = "Sum";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // parameter_based_multiplication
            // 
            this.parameter_based_multiplication.Location = new System.Drawing.Point(12, 211);
            this.parameter_based_multiplication.Name = "parameter_based_multiplication";
            this.parameter_based_multiplication.Size = new System.Drawing.Size(124, 23);
            this.parameter_based_multiplication.TabIndex = 2;
            this.parameter_based_multiplication.Text = "parameter Bmult";
            this.parameter_based_multiplication.UseVisualStyleBackColor = true;
            this.parameter_based_multiplication.Click += new System.EventHandler(this.parameter_based_multiplication_Click);
            // 
            // AMDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.parameter_based_multiplication);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AMDS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AMDS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBox3;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button parameter_based_multiplication;
    }
}

