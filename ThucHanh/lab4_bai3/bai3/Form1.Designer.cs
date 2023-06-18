namespace bai3
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
            this.GoToWeb = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.pnWeb = new System.Windows.Forms.Panel();
            this.DLResource = new System.Windows.Forms.Button();
            this.DLHtml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToWeb
            // 
            this.GoToWeb.Location = new System.Drawing.Point(491, 12);
            this.GoToWeb.Name = "GoToWeb";
            this.GoToWeb.Size = new System.Drawing.Size(74, 30);
            this.GoToWeb.TabIndex = 1;
            this.GoToWeb.Text = "Go";
            this.GoToWeb.UseVisualStyleBackColor = true;
            this.GoToWeb.Click += new System.EventHandler(this.GoToWeb_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(473, 30);
            this.tbUrl.TabIndex = 3;
            // 
            // pnWeb
            // 
            this.pnWeb.Location = new System.Drawing.Point(12, 48);
            this.pnWeb.Name = "pnWeb";
            this.pnWeb.Size = new System.Drawing.Size(776, 390);
            this.pnWeb.TabIndex = 4;
            // 
            // DLResource
            // 
            this.DLResource.Location = new System.Drawing.Point(672, 12);
            this.DLResource.Name = "DLResource";
            this.DLResource.Size = new System.Drawing.Size(116, 30);
            this.DLResource.TabIndex = 5;
            this.DLResource.Text = "DownloadResource";
            this.DLResource.UseVisualStyleBackColor = true;
            this.DLResource.Click += new System.EventHandler(this.DLResource_Click);
            // 
            // DLHtml
            // 
            this.DLHtml.Location = new System.Drawing.Point(571, 12);
            this.DLHtml.Name = "DLHtml";
            this.DLHtml.Size = new System.Drawing.Size(95, 30);
            this.DLHtml.TabIndex = 6;
            this.DLHtml.Text = "DownloadHTML";
            this.DLHtml.UseVisualStyleBackColor = true;
            this.DLHtml.Click += new System.EventHandler(this.DLHtml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DLHtml);
            this.Controls.Add(this.DLResource);
            this.Controls.Add(this.pnWeb);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.GoToWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToWeb;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Panel pnWeb;
        private System.Windows.Forms.Button DLResource;
        private System.Windows.Forms.Button DLHtml;
    }
}

