using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;

namespace BT_Tuan2
{
    public partial class Form1 : Form
    {
        //Tạo chuỗi kết nối
        string Sconnect = @"Data Source=GIAKIET;Initial Catalog=StudentManagement;Integrated Security=True";
        //Tạo biến đối tượng kết nối
        SqlConnection SqlObj = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try 
            {
                if (SqlObj == null)
                {
                    SqlObj = new SqlConnection(Sconnect);
                }
                if (SqlObj.State == ConnectionState.Closed)
                {
                    SqlObj.Open();
                    MessageBox.Show("Connected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
                return;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (SqlObj != null && SqlObj.State == ConnectionState.Open)
            {
                SqlObj.Close();
                MessageBox.Show("Closed!");
            }
            else
            {
                MessageBox.Show("The connection wasn't created!");
            }
        }

        private void Add_Table_Click(object sender, EventArgs e)
        {
            if(SqlObj==null) MessageBox.Show("The connection wasn't created!!");
            else if(SqlObj.State == ConnectionState.Closed) MessageBox.Show("The connection is closing!!");
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("create table Student(id int not null, name varchar(40), birth smalldatetime, address varchar(40))",SqlObj);
                    MessageBox.Show("Create table successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex);
                }
                SqlObj.Close();
            }
        }

        private void Find_Data_Click(object sender, EventArgs e)
        {
            if (SqlObj == null) MessageBox.Show("The connection wasn't created!!");
            else if (SqlObj.State == ConnectionState.Closed) MessageBox.Show("The connection is closing!!");
            else
            {
                SqlCommand query = new SqlCommand("select * from Student where id = @ID_F",SqlObj);
                SqlParameter ParamID_F = new SqlParameter("@ID_F", SqlDbType.Int);
                ParamID_F.Value = txtID_F.Text.Trim();
                query.Parameters.Add(ParamID_F);

                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader.GetString(1);
                    string birth = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                    string address = reader.GetString(3);

                    txtName.Text = name;
                    txtBirth.Text = birth;
                    txtAddress.Text = address;
                }
                SqlObj.Close();
            }
            
        }

        private void Add_Data_Click(object sender, EventArgs e)
        {
            if (SqlObj == null) MessageBox.Show("The connection wasn't created!!");
            else if (SqlObj.State == ConnectionState.Closed) MessageBox.Show("The connection is closing!!");
            else
            {
                SqlCommand query = new SqlCommand("insert into Student values(@ID_Add, @Name_Add, @Birth_Add, @Address_Add)",SqlObj); 

                SqlParameter ParamID_Add = new SqlParameter("@ID_Add", SqlDbType.Int);
                SqlParameter ParamName_Add = new SqlParameter("@Name_Add", SqlDbType.VarChar);
                SqlParameter ParamBirth_Add = new SqlParameter("@Birth_Add", SqlDbType.SmallDateTime);
                SqlParameter ParamAddress_Add = new SqlParameter("@Address_Add", SqlDbType.VarChar);

                ParamID_Add.Value = txtID_Ins.Text.Trim();
                ParamName_Add.Value = txtName_Ins.Text.Trim();
                ParamBirth_Add.Value = txtBirth_Ins.Text.Trim();
                ParamAddress_Add.Value = txtAddress_Ins.Text.Trim();

                query.Parameters.Add(ParamID_Add);
                query.Parameters.Add(ParamName_Add);
                query.Parameters.Add(ParamBirth_Add);
                query.Parameters.Add(ParamAddress_Add);
                
                int result = query.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Unsuccessfully insert!!");
                }
                else
                {
                    MessageBox.Show("Inserted successfully!");
                    ShowTable();
                }
                SqlObj.Close();

            }
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void ShowTable()
        {
            if (SqlObj == null) SqlObj = new SqlConnection(Sconnect);
            if (SqlObj.State == ConnectionState.Closed) SqlObj.Open();
            
            SqlCommand query = new SqlCommand("select * from Student", SqlObj);
            SqlObj.Close();
            SqlObj.Open();
            SqlDataReader reader = query.ExecuteReader();
            lvStudent.Items.Clear();
            while (reader.Read())
            {
                ListViewItem show = new ListViewItem(reader.GetInt32(0).ToString());
                show.SubItems.Add(reader.GetString(1));
                show.SubItems.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                show.SubItems.Add(reader.GetString(3));

                lvStudent.Items.Add(show);
            }
            SqlObj.Close();
        }

        private void Del_Table_Click(object sender, EventArgs e)
        {
            if (SqlObj == null) MessageBox.Show("The connection wasn't created!!");
            if (SqlObj.State == ConnectionState.Closed) MessageBox.Show("The connection is closing!!");
            try
            {
                SqlCommand cmd = new SqlCommand("drop table Student", SqlObj);
                MessageBox.Show("Delete table successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
            SqlObj.Close();
        }

        private void Delete_Data_Click(object sender, EventArgs e)
        {
            if (SqlObj == null) MessageBox.Show("The connection wasn't created!!");
            else if (SqlObj.State == ConnectionState.Closed) MessageBox.Show("The connection is closing!!");
            else
            {
                SqlCommand query = new SqlCommand("delete from Student where id = @ID_Del", SqlObj);
                SqlParameter ParamID_Del = new SqlParameter("@ID_Del", SqlDbType.Int);
                ParamID_Del.Value = txtID_Del.Text.Trim();
                query.Parameters.Add(ParamID_Del);

                SqlDataReader reader = query.ExecuteReader();
                ShowTable();
            }
            SqlObj.Close();
        }

        private void Update_Data_Click(object sender, EventArgs e)
        {
            if (SqlObj == null) MessageBox.Show("The connection wasn't created!!");
            else if (SqlObj.State == ConnectionState.Closed) MessageBox.Show("The connection is closing!!");
            else
            {
                SqlCommand query = new SqlCommand("update Student set name = @Name_up, birth = @Birth_up, address = @Address_up where id = @ID_up", SqlObj);

                SqlParameter ParamID_up = new SqlParameter("@ID_up", SqlDbType.Int);
                SqlParameter ParamName_up = new SqlParameter("@Name_up", SqlDbType.VarChar);
                SqlParameter ParamBirth_up = new SqlParameter("@Birth_up", SqlDbType.SmallDateTime);
                SqlParameter ParamAddress_up = new SqlParameter("@Address_up", SqlDbType.VarChar);

                ParamID_up.Value = txtID_Update.Text.Trim();
                ParamName_up.Value = txtName_Update.Text.Trim();
                ParamBirth_up.Value = txtBirth_Update.Text.Trim();
                ParamAddress_up.Value = txtAddress_Update.Text.Trim();

                query.Parameters.Add(ParamID_up);
                query.Parameters.Add(ParamName_up);
                query.Parameters.Add(ParamBirth_up);
                query.Parameters.Add(ParamAddress_up);

                int result = query.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Unsuccessfully update!!");
                }
                else
                {
                    MessageBox.Show("updated successfully!");
                    ShowTable();
                }
                SqlObj.Close();

            }
        }
    }
}
