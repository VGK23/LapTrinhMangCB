namespace BT_Tuan2
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
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Add_Data = new System.Windows.Forms.Button();
            this.Delete_Data = new System.Windows.Forms.Button();
            this.Update_Data = new System.Windows.Forms.Button();
            this.Find_Data = new System.Windows.Forms.Button();
            this.Add_Table = new System.Windows.Forms.Button();
            this.Enter_ID = new System.Windows.Forms.Label();
            this.txtID_F = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName_Ins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirth_Ins = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress_Ins = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID_Ins = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.txtID_Show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName_Show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBirth_Show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAddress_Show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Del_Table = new System.Windows.Forms.Button();
            this.txtID_Del = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName_Update = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBirth_Update = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress_Update = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID_Update = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(29, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(156, 74);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(210, 12);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(156, 74);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Add_Data
            // 
            this.Add_Data.Location = new System.Drawing.Point(800, 110);
            this.Add_Data.Name = "Add_Data";
            this.Add_Data.Size = new System.Drawing.Size(115, 35);
            this.Add_Data.TabIndex = 2;
            this.Add_Data.Text = "Add Student";
            this.Add_Data.UseVisualStyleBackColor = true;
            this.Add_Data.Click += new System.EventHandler(this.Add_Data_Click);
            // 
            // Delete_Data
            // 
            this.Delete_Data.Location = new System.Drawing.Point(780, 324);
            this.Delete_Data.Name = "Delete_Data";
            this.Delete_Data.Size = new System.Drawing.Size(115, 35);
            this.Delete_Data.TabIndex = 3;
            this.Delete_Data.Text = "Delete Student";
            this.Delete_Data.UseVisualStyleBackColor = true;
            this.Delete_Data.Click += new System.EventHandler(this.Delete_Data_Click);
            // 
            // Update_Data
            // 
            this.Update_Data.Location = new System.Drawing.Point(336, 327);
            this.Update_Data.Name = "Update_Data";
            this.Update_Data.Size = new System.Drawing.Size(115, 35);
            this.Update_Data.TabIndex = 4;
            this.Update_Data.Text = "Update Student";
            this.Update_Data.UseVisualStyleBackColor = true;
            this.Update_Data.Click += new System.EventHandler(this.Update_Data_Click);
            // 
            // Find_Data
            // 
            this.Find_Data.Location = new System.Drawing.Point(312, 119);
            this.Find_Data.Name = "Find_Data";
            this.Find_Data.Size = new System.Drawing.Size(115, 35);
            this.Find_Data.TabIndex = 5;
            this.Find_Data.Text = "Find Student";
            this.Find_Data.UseVisualStyleBackColor = true;
            this.Find_Data.Click += new System.EventHandler(this.Find_Data_Click);
            // 
            // Add_Table
            // 
            this.Add_Table.Location = new System.Drawing.Point(395, 12);
            this.Add_Table.Name = "Add_Table";
            this.Add_Table.Size = new System.Drawing.Size(172, 74);
            this.Add_Table.TabIndex = 6;
            this.Add_Table.Text = "Add Table";
            this.Add_Table.UseVisualStyleBackColor = true;
            this.Add_Table.Click += new System.EventHandler(this.Add_Table_Click);
            // 
            // Enter_ID
            // 
            this.Enter_ID.AutoSize = true;
            this.Enter_ID.Location = new System.Drawing.Point(29, 134);
            this.Enter_ID.Name = "Enter_ID";
            this.Enter_ID.Size = new System.Drawing.Size(121, 20);
            this.Enter_ID.TabIndex = 7;
            this.Enter_ID.Text = "Enter ID to find:";
            // 
            // txtID_F
            // 
            this.txtID_F.Location = new System.Drawing.Point(156, 128);
            this.txtID_F.Name = "txtID_F";
            this.txtID_F.Size = new System.Drawing.Size(132, 26);
            this.txtID_F.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(156, 257);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(132, 26);
            this.txtAddress.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address:";
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(156, 215);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.ReadOnly = true;
            this.txtBirth.Size = new System.Drawing.Size(132, 26);
            this.txtBirth.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 169);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(132, 26);
            this.txtName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // txtName_Ins
            // 
            this.txtName_Ins.Location = new System.Drawing.Point(630, 160);
            this.txtName_Ins.Name = "txtName_Ins";
            this.txtName_Ins.Size = new System.Drawing.Size(132, 26);
            this.txtName_Ins.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name:";
            // 
            // txtBirth_Ins
            // 
            this.txtBirth_Ins.Location = new System.Drawing.Point(630, 206);
            this.txtBirth_Ins.Name = "txtBirth_Ins";
            this.txtBirth_Ins.Size = new System.Drawing.Size(132, 26);
            this.txtBirth_Ins.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birth:";
            // 
            // txtAddress_Ins
            // 
            this.txtAddress_Ins.Location = new System.Drawing.Point(630, 248);
            this.txtAddress_Ins.Name = "txtAddress_Ins";
            this.txtAddress_Ins.Size = new System.Drawing.Size(132, 26);
            this.txtAddress_Ins.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Address:";
            // 
            // txtID_Ins
            // 
            this.txtID_Ins.Location = new System.Drawing.Point(630, 119);
            this.txtID_Ins.Name = "txtID_Ins";
            this.txtID_Ins.Size = new System.Drawing.Size(132, 26);
            this.txtID_Ins.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter ID to add:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1192, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "TABLE STUDENT";
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtID_Show,
            this.txtName_Show,
            this.txtBirth_Show,
            this.txtAddress_Show});
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.GridLines = true;
            this.lvStudent.HideSelection = false;
            this.lvStudent.Location = new System.Drawing.Point(951, 61);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(510, 394);
            this.lvStudent.TabIndex = 24;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
            // 
            // txtID_Show
            // 
            this.txtID_Show.Text = "ID";
            this.txtID_Show.Width = 50;
            // 
            // txtName_Show
            // 
            this.txtName_Show.Text = "NAME";
            this.txtName_Show.Width = 120;
            // 
            // txtBirth_Show
            // 
            this.txtBirth_Show.Text = "BIRTH";
            this.txtBirth_Show.Width = 130;
            // 
            // txtAddress_Show
            // 
            this.txtAddress_Show.Text = "ADDRESS";
            this.txtAddress_Show.Width = 200;
            // 
            // Del_Table
            // 
            this.Del_Table.Location = new System.Drawing.Point(590, 12);
            this.Del_Table.Name = "Del_Table";
            this.Del_Table.Size = new System.Drawing.Size(172, 74);
            this.Del_Table.TabIndex = 25;
            this.Del_Table.Text = "Delete Table";
            this.Del_Table.UseVisualStyleBackColor = true;
            this.Del_Table.Click += new System.EventHandler(this.Del_Table_Click);
            // 
            // txtID_Del
            // 
            this.txtID_Del.Location = new System.Drawing.Point(628, 333);
            this.txtID_Del.Name = "txtID_Del";
            this.txtID_Del.Size = new System.Drawing.Size(132, 26);
            this.txtID_Del.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Enter ID to delete:";
            // 
            // txtName_Update
            // 
            this.txtName_Update.Location = new System.Drawing.Point(180, 374);
            this.txtName_Update.Name = "txtName_Update";
            this.txtName_Update.Size = new System.Drawing.Size(132, 26);
            this.txtName_Update.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Name:";
            // 
            // txtBirth_Update
            // 
            this.txtBirth_Update.Location = new System.Drawing.Point(180, 420);
            this.txtBirth_Update.Name = "txtBirth_Update";
            this.txtBirth_Update.Size = new System.Drawing.Size(132, 26);
            this.txtBirth_Update.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Birth:";
            // 
            // txtAddress_Update
            // 
            this.txtAddress_Update.Location = new System.Drawing.Point(180, 462);
            this.txtAddress_Update.Name = "txtAddress_Update";
            this.txtAddress_Update.Size = new System.Drawing.Size(132, 26);
            this.txtAddress_Update.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Address:";
            // 
            // txtID_Update
            // 
            this.txtID_Update.Location = new System.Drawing.Point(180, 336);
            this.txtID_Update.Name = "txtID_Update";
            this.txtID_Update.Size = new System.Drawing.Size(132, 26);
            this.txtID_Update.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Enter ID to update:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 515);
            this.Controls.Add(this.txtName_Update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBirth_Update);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAddress_Update);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtID_Update);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtID_Del);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Del_Table);
            this.Controls.Add(this.lvStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName_Ins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBirth_Ins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress_Ins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID_Ins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_F);
            this.Controls.Add(this.Enter_ID);
            this.Controls.Add(this.Add_Table);
            this.Controls.Add(this.Find_Data);
            this.Controls.Add(this.Update_Data);
            this.Controls.Add(this.Delete_Data);
            this.Controls.Add(this.Add_Data);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Add_Data;
        private System.Windows.Forms.Button Delete_Data;
        private System.Windows.Forms.Button Update_Data;
        private System.Windows.Forms.Button Find_Data;
        private System.Windows.Forms.Button Add_Table;
        private System.Windows.Forms.Label Enter_ID;
        private System.Windows.Forms.TextBox txtID_F;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName_Ins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBirth_Ins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress_Ins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID_Ins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.ColumnHeader txtID_Show;
        private System.Windows.Forms.ColumnHeader txtName_Show;
        private System.Windows.Forms.ColumnHeader txtBirth_Show;
        private System.Windows.Forms.ColumnHeader txtAddress_Show;
        private System.Windows.Forms.Button Del_Table;
        private System.Windows.Forms.TextBox txtID_Del;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName_Update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBirth_Update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress_Update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID_Update;
        private System.Windows.Forms.Label label13;
    }
}

