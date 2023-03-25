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
    public partial class Lab1B3 : Form
    {
        public Lab1B3()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(num.Text.Trim());
            if (n == 0) txtRead.Text = "Zero";
            if (n == 1) txtRead.Text = "One";
            if (n == 2) txtRead.Text = "Two";
            if (n == 3) txtRead.Text = "Three";
            if (n == 4) txtRead.Text = "Four";
            if (n == 5) txtRead.Text = "Five";
            if (n == 6) txtRead.Text = "Six";
            if (n == 7) txtRead.Text = "Seven";
            if (n == 8) txtRead.Text = "Eight";
            if (n == 9) txtRead.Text = "Nine";
            if (n == 10) txtRead.Text = "Ten";
            if (n == 11) txtRead.Text = "Eleven";
            if (n == 12) txtRead.Text = "Twelve";
            if (n == 13) txtRead.Text = "Thirteen";
            if (n == 14) txtRead.Text = "Fourteen";
            if (n == 15) txtRead.Text = "Fifteen";
            if (n == 16) txtRead.Text = "Sixteen";
            if (n == 17) txtRead.Text = "Seventeen";
            if (n == 18) txtRead.Text = "Eighteen";
            if (n == 19) txtRead.Text = "Nineteen";
            if (n == 20) txtRead.Text = "Twenty";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            num.Text = string.Empty;
            txtRead.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
