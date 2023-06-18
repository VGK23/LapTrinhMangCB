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

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient listen = new UdpClient(8080);
                IPEndPoint groupIPe = new IPEndPoint(IPAddress.Any, 8080);
                rtbShow.Text += "Server is starting on port 8080...\n";
                byte[] rec_byte;
                Thread recThread = new Thread(() =>
                {
                    while (true)
                    {
                        rec_byte = listen.Receive(ref groupIPe);
                        string mes = Encoding.ASCII.GetString(rec_byte);
                        this.Invoke((MethodInvoker)delegate
                        {
                            rtbShow.Text += groupIPe.Address.ToString() + ":" + mes + "\n";
                        });
                        byte[] send_byte = Encoding.ASCII.GetBytes("Message received!");
                        listen.Send(send_byte, send_byte.Length, groupIPe);
                        while (listen.Available > 0) { }
                    }
                });
                recThread.Start();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("An error occurred while listening for incoming messages: " + ex.Message);
            }
        }
    }
}