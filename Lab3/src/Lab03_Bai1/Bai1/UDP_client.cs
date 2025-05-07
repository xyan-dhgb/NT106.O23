using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520101_DinhHuynhGiaBao_Lab03_Bai1
{
    public partial class UDP_CLIENT : Form
    {
        private UdpClient UDPclient = new UdpClient(); 
        public UDP_CLIENT()
        {
            InitializeComponent();
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string clientIP = IPTextBox.Text;
                int port = int.Parse(ClientPortTextBox.Text);
                string message = MessageTextBox.Text;

                IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse(clientIP), port);
                byte[] data = Encoding.ASCII.GetBytes(message);
                UDPclient.Send(data, data.Length, serverEP);
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
