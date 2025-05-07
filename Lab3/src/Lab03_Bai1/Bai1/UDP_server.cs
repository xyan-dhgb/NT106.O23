using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22520101_DinhHuynhGiaBao_Lab03_Bai1
{
    public partial class UDP_SERVER : Form
    {
        private UdpClient udpServer;
        private IPEndPoint clientEP;
        public UDP_SERVER()
        {
            InitializeComponent();
            ServerPortTextBox.Text = "8080";
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(ServerPortTextBox.Text);
                udpServer = new UdpClient(port);
                clientEP = new IPEndPoint(IPAddress.Any, 0);
                ListenForData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListenForData()
        {
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                byte[] data = udpServer.EndReceive(ar, ref clientEP);
                string message = Encoding.ASCII.GetString(data);
                AddMessageToReceivedTextBox(clientEP.ToString(), message); 
                ListenForData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddMessageToReceivedTextBox(string sender, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string>(AddMessageToReceivedTextBox), sender, message);
                return;
            }
            ReceivedTextBox.Text += sender + ": " + message + "\n";  // Thêm sender và message vào TextBox
        }
    }

}
