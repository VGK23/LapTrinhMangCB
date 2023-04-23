using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SV_Thread()
        {
            try
            {
                UdpClient listen = new UdpClient(8080);
                byte[] rec_byte;
                while (true)
                {
                    IPEndPoint groupIPe = new IPEndPoint(IPAddress.Any,0);
                    rec_byte = listen.Receive(ref groupIPe);
                    string rec_data = Encoding.ASCII.GetString(rec_byte);
                    txtServerShow.Text = groupIPe.Address.ToString() + ":" + rec_data + "\n";
                }
            }
            catch
            {
                MessageBox.Show("Can't connect to client!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread udpSerThread = new Thread(new ThreadStart(SV_Thread));
            udpSerThread.Start();
        }
    }
}
