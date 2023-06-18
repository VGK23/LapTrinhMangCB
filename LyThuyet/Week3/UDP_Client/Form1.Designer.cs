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
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientShow
            // 
            this.txtClientShow.Location = new System.Drawing.Point(8, 8);
            this.txtClientShow.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientShow.Multiline = true;
            this.txtClientShow.Name = "txtClientShow";
            this.txtClientShow.ReadOnly = true;
            this.txtClientShow.Size = new System.Drawing.Size(410, 165);
            this.txtClientShow.TabIndex = 3;
            // 
            // txtClientMess
            // 
            this.txtClientMess.Location = new System.Drawing.Point(8, 185);
            this.txtClientMess.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientMess.Multiline = true;
            this.txtClientMess.Name = "txtClientMess";
            this.txtClientMess.Size = new System.Drawing.Size(265, 31);
            this.txtClientMess.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(276, 185);
            this.Send.Margin = new System.Windows.Forms.Padding(2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(71, 28);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(351, 185);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(71, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 226);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.txtClientMess);
            this.Controls.Add(this.txtClientShow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientShow;
        private System.Windows.Forms.TextBox txtClientMess;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button btnConnect;
    }
}

