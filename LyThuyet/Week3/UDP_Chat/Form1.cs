using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace UDP_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SendMess()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint IPe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            byte[] send = Encoding.ASCII.GetBytes(txtClientMess.Text.Trim());
            socket.SendTo(send,IPe);

            txtClientShow.Text = "Client:\t" + txtClientMess.Text + "\n";
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
