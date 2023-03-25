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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab1B1 b1 = new Lab1B1();
            b1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab1B2 b2 = new Lab1B2();
            b2.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab1B3 b3 = new Lab1B3();
            b3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab1B4 b4 = new Lab1B4();
            b4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Lab1B5 b5 = new Lab1B5();
            b5.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
