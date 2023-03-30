using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Chat
{
    public partial class Form2 : Form
    {
        public Form2()
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
                    IPEndPoint groupIPe = new IPEndPoint(IPAddress.Any, 8080);
                    rec_byte = listen.Receive(ref groupIPe);
                    string rec_data = Encoding.ASCII.GetString(rec_byte, 1, rec_byte.Length);
                    txtServerShow.Text = groupIPe.Address.ToString() + ":" + rec_data.ToString() + "\n";
                }
            }
            catch
            {
                MessageBox.Show("Can't connect to client!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Thread udpSerThread = new Thread(new ThreadStart(SV_Thread));
            udpSerThread.Start();
        }
    }
}
