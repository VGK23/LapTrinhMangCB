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
    public partial class Lab1B4 : Form
    {
        public Lab1B4()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            double n;
            n = double.Parse(money.Text.Trim());
            string s = cbB.Text.Trim();
            if (s.Equals("USD"))
            {
                txtResult.Text = (n * 22772).ToString();
                ExRate.Text = "1 USD = 22772 VND";
            };
            if (s.Equals("EUR"))
            {
                txtResult.Text = (n * 28132).ToString();
                ExRate.Text = "1 EUR = 28132 VND";
            }
            if (s.Equals("GBP"))
            {
                txtResult.Text = (n * 31538).ToString();
                ExRate.Text = "1 GBP = 31538 VND";
            }
            if (s.Equals("SGD"))
            {
                txtResult.Text = (n * 17286).ToString();
                ExRate.Text = "1 SGD = 17286 VND";
            }
            if (s.Equals("JPY"))
            {
                txtResult.Text = (n * 214).ToString();
                ExRate.Text = "1 JPY = 214 VND";
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            money.Text = string.Empty;
            cbB.Text = string.Empty;
            txtResult.Text = string.Empty;
            ExRate.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
