namespace UDP_Chat
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
            this.txtClientMess = new System.Windows.Forms.TextBox();
            this.txtClientShow = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientMess
            // 
            this.txtClientMess.Location = new System.Drawing.Point(12, 280);
            this.txtClientMess.Multiline = true;
            this.txtClientMess.Name = "txtClientMess";
            this.txtClientMess.Size = new System.Drawing.Size(396, 45);
            this.txtClientMess.TabIndex = 0;
            // 
            // txtClientShow
            // 
            this.txtClientShow.Location = new System.Drawing.Point(12, 12);
            this.txtClientShow.Multiline = true;
            this.txtClientShow.Name = "txtClientShow";
            this.txtClientShow.ReadOnly = true;
            this.txtClientShow.Size = new System.Drawing.Size(509, 251);
            this.txtClientShow.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(414, 282);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(107, 43);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 337);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.txtClientShow);
            this.Controls.Add(this.txtClientMess);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientMess;
        private System.Windows.Forms.TextBox txtClientShow;
        private System.Windows.Forms.Button Send;
    }
}

