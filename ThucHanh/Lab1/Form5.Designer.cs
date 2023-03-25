namespace Practice
{
    partial class Lab1B4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ExRate = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURRENCY CONVERTING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount to change";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(208, 124);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(184, 26);
            this.money.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // cbB
            // 
            this.cbB.FormattingEnabled = true;
            this.cbB.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.cbB.Location = new System.Drawing.Point(444, 122);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(121, 28);
            this.cbB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(254, 279);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(289, 26);
            this.txtResult.TabIndex = 6;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(99, 192);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(160, 49);
            this.change.TabIndex = 7;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exchange rate";
            // 
            // ExRate
            // 
            this.ExRate.Location = new System.Drawing.Point(254, 328);
            this.ExRate.Name = "ExRate";
            this.ExRate.Size = new System.Drawing.Size(289, 26);
            this.ExRate.TabIndex = 9;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(305, 192);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(160, 49);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(513, 192);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(160, 49);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Lab1B4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ExRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.change);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab1B4";
            this.Text = "Lab01_Bai04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExRate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
    }
}