namespace UDP_Client
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
            this.txtClientShow = new System.Windows.Forms.TextBox();
            this.txtClientMess = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientShow
            // 
            this.txtClientShow.Location = new System.Drawing.Point(12, 12);
            this.txtClientShow.Multiline = true;
            this.txtClientShow.Name = "txtClientShow";
            this.txtClientShow.ReadOnly = true;
            this.txtClientShow.Size = new System.Drawing.Size(509, 251);
            this.txtClientShow.TabIndex = 3;
            // 
            // txtClientMess
            // 
            this.txtClientMess.Location = new System.Drawing.Point(12, 284);
            this.txtClientMess.Multiline = true;
            this.txtClientMess.Name = "txtClientMess";
            this.txtClientMess.Size = new System.Drawing.Size(396, 45);
            this.txtClientMess.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(414, 284);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(107, 43);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.txtClientMess);
            this.Controls.Add(this.txtClientShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientShow;
        private System.Windows.Forms.TextBox txtClientMess;
        private System.Windows.Forms.Button Send;
    }
}

