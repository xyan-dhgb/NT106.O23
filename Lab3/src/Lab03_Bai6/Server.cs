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

namespace Lab_3___Bài_6
{
    public partial class Server : Form
    {
        private TcpListener? listener;
        private TcpClient? client;
        private NetworkStream? stream;
        private int port;

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void StartServer()
        {
            this.listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            this.listener.Start();

            MessageBox.Show("Server has started.");

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    AcceptConnection();
                }
            });

            thread.Start();
        }

        private void AcceptConnection()
        {
            this.client = this.listener?.AcceptTcpClient();
            this.stream = this.client?.GetStream();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadClientMessage();
        }

        private void ReadClientMessage()
        {
            byte[] buffer = new byte[1024];
            int bytesRead = this.stream?.Read(buffer, 0, buffer.Length) ?? 0;

            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Invoke(new Action(() => textBox1.AppendText(message + "\n")));
        }
    }
}
