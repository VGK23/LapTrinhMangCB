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
    public partial class Lab1B2 : Form
    {
        public Lab1B2()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            double min, max, n1, n2, n3;
            n1 = double.Parse(num1.Text.Trim());
            n2 = double.Parse(num2.Text.Trim());
            n3 = double.Parse(num3.Text.Trim());
            
            if (n1 >= n2)
            {
                if (n2 >= n3)
                {
                    min = n3;
                    max = n1;
                }
                else//n2 < n3
                {
                    min = n2;
                    if (n1 >= n3) max = n1;
                    else max = n3;
                }
            }
            else //n2 > n1
            {
                if (n1 >= n3)
                {
                    min = n3;
                    max = n2;
                }
                else//n1 < n3
                {
                    min = n1;
                    if (n2 >= n3) max = n2;
                    else max = n3;
                }
            }
            maxN.Text = max.ToString();
            minN.Text = min.ToString();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            num1.Text = string.Empty;
            num2.Text = string.Empty;
            num3.Text = string.Empty;
            minN.Text = string.Empty;
            maxN.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
