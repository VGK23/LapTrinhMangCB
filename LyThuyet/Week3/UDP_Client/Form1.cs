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
using System.Threading;
using System.Xml.Linq;

namespace UDP_Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPAddress SerIP;
        EndPoint SerEP;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Send_Click(object sender, EventArgs e)
        {
            string ClientMess = txtClientMess.Text;
            byte[] ClientData = new byte[1024];
            ClientData = Encoding.ASCII.GetBytes(ClientMess);
            client.SendTo(ClientData, SerEP);
            txtClientShow.Text = "\nClient:" + ClientMess;
            byte[] ServerData = new byte[1024];
            int ServerDataLenght = client.ReceiveFrom(ServerData,ref SerEP); 
            string ServerMess = Encoding.ASCII.GetString(ServerData,0,ServerDataLenght);
            txtClientShow.Text += "\nServer:" + ServerMess;
            txtClientMess.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                SerIP = IPAddress.Parse("127.0.0.1");
                SerEP = new IPEndPoint(SerIP, 8080);
                MessageBox.Show("Connected successfully!");
            }
            catch (Exception ex) { MessageBox.Show("Can't connect to server!"); };
        }
    }
}
