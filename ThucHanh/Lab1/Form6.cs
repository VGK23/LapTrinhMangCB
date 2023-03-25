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
    public partial class Lab1B5 : Form
    {
        public Lab1B5()
        {
            InitializeComponent();
        }

        private void Cal_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(num1.Text.Trim());
            float n2 = float.Parse(num2.Text.Trim());
            while (n1 != (Int32)n1 || n2 != (Int32)n2)
            {
                MessageBox.Show("Please enter an integer!");
                return;
            }
            int reA=1, reB=1, S1=0, S2=0, S3=0;
            string str1 = "0", str2="0", str3 = "";
            //A!
            for (int i = 1; i <= n1 ;i++)
            {
                reA = reA * i;
            }
            //B!
            for (int i = 1; i <= n2; i++)
            {
                reB = reB * i;
            }
            //S1
            for (int i = 1; i <= n1; i++)
            {
                S1+=i;
                str1 = str1 + " + " + i.ToString();
            }
            //S2
            for (int i = 1; i <= n2; i++)
            {
                S2 += i;
                str2 = str2 + " + " + i.ToString();
            }
            //S3
            int s3;
            for (int i = 1; i <= (Int32)n2; i++)
            {
                s3 = (Int32)n1;
                for(int j = 2; j<=i; j++)
                {
                    s3*=(Int32)n1;
                }
                S3 += s3;
                str3 = str3 + n1 + "^" + i.ToString() + " + ";
            }
            rtb.Text = num1.Text.Trim() + "! = " + reA.ToString() + "\t\t" + num2.Text.Trim() + "! = " + reB.ToString();
            rtb.Text = rtb.Text + "\n\nS1 = " + str1 + " = " + S1.ToString();
            rtb.Text = rtb.Text + "\n\nS2 = " + str2 + " = " + S2.ToString();
            rtb.Text = rtb.Text +"\n\nS3 = " + str3 + " 0 = " + S3.ToString();

        }

        private void Del_Click(object sender, EventArgs e)
        {
            num1.Text = string.Empty;
            num2.Text = string.Empty;
            rtb.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
