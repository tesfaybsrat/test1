namespace UI
{
    partial class ChatBallon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChatText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChatText
            // 
            this.txtChatText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChatText.Enabled = false;
            this.txtChatText.Location = new System.Drawing.Point(226, 38);
            this.txtChatText.Multiline = true;
            this.txtChatText.Name = "txtChatText";
            this.txtChatText.Size = new System.Drawing.Size(100, 38);
            this.txtChatText.TabIndex = 0;
            // 
            // ChatBallon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChatText);
            this.Name = "ChatBallon";
            this.Size = new System.Drawing.Size(650, 150);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChatBallon_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChatText;
    }
}
