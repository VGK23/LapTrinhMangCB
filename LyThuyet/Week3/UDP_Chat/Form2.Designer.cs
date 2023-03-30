namespace UDP_Chat
{
    partial class Form2
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
            this.txtServerShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtServerShow
            // 
            this.txtServerShow.Location = new System.Drawing.Point(12, 12);
            this.txtServerShow.Multiline = true;
            this.txtServerShow.Name = "txtServerShow";
            this.txtServerShow.ReadOnly = true;
            this.txtServerShow.Size = new System.Drawing.Size(509, 319);
            this.txtServerShow.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 343);
            this.Controls.Add(this.txtServerShow);
            this.Name = "Form2";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerShow;
    }
}