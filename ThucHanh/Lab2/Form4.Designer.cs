namespace Lab2
{
    partial class Form4
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
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWriteResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(0, 0);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(434, 370);
            this.rtbShow.TabIndex = 0;
            this.rtbShow.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(466, 24);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(157, 47);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Đọc đề";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(466, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWriteResult
            // 
            this.btnWriteResult.Location = new System.Drawing.Point(466, 160);
            this.btnWriteResult.Name = "btnWriteResult";
            this.btnWriteResult.Size = new System.Drawing.Size(157, 47);
            this.btnWriteResult.TabIndex = 3;
            this.btnWriteResult.Text = "Ghi kết quả";
            this.btnWriteResult.UseVisualStyleBackColor = true;
            this.btnWriteResult.Click += new System.EventHandler(this.btnWriteResult_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 373);
            this.Controls.Add(this.btnWriteResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.rtbShow);
            this.Name = "Form4";
            this.Text = "Bài 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWriteResult;
    }
}