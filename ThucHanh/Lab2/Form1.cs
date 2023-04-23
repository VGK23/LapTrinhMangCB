using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Bai1 = new Form2();
            Bai1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form3 Bai2 = new Form3();
            Bai2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form4 Bai3 = new Form4();
            Bai3.Show();
        }
    }
}
