using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Lab1B1 : Form
    {
        public Lab1B1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            float n1, n2;
            n1 = float.Parse(txtnum1.Text.Trim());
            n2 = float.Parse(txtnum2.Text.Trim());
            while(n1 != (Int32)n1 || n2 != (Int32)n2)
            {
                MessageBox.Show("Please enter an integer!");
                return;
            }
            double s = n1 + n2;
            result.Text = s.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            txtnum1.Text = string.Empty;
            txtnum2.Text = string.Empty;
            result.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
