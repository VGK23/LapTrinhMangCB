using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void SendMess()
        {
            UdpClient Client = new UdpClient();
            byte[] sendByte = Encoding.ASCII.GetBytes(txtClientMess.Text.Trim());
            Client.Send(sendByte,sendByte.Length,txtClientMess.Text,8080);
            txtClientShow.Text = "Client:\t" + txtClientMess.Text + "\n";
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMess();
        }
    }
}
