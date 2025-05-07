using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22520101_DinhHuynhGiaBao_Lab03_Bai2
{
    public partial class Bai2Form : Form
    {
        public Bai2Form()
        {
            InitializeComponent();
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        private bool isListening = false; // Trạng thái của nút lắng nghe
        private Socket listenerSocket;
        private string receivedData = "";
        private Socket clientSocket;

        private void ListenButton_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                isListening = true;
                ListenButton.Text = "Stop connection.";
                MessageTextBox.AppendText("Telnet running on 127.0.0.1:8080. Currently listening for connections...\r\n");

                CheckForIllegalCrossThreadCalls = false;
                Thread severthread = new Thread(new ThreadStart(StartUnsafeThread));
                severthread.Start();
            }
            else
            {
                listenerSocket.Close();
                ListenButton.Text = "Listen";
                MessageTextBox.AppendText("Stop listening for connections and close Telnet!\r\n");
            }
        }
        void StartUnsafeThread()
        {
            int bytesRecv = 0;
            // Khởi tạo mảng bytes nhận dữ liệu
            byte[] recv = new byte[1];

            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            MessageTextBox.AppendText("New client connected!\r\n");

            while (clientSocket.Connected)
            {
                bytesRecv = clientSocket.Receive(recv);
                receivedData += Encoding.ASCII.GetString(recv, 0, bytesRecv);

                if (receivedData.EndsWith("\r\n"))
                {
                    if (isListening) // Kiểm tra trạng thái của nút Listen trước khi nhập dữ liệu vào ListView
                    {
                        MessageTextBox.AppendText("Client: " + receivedData);
                    }
                    receivedData = "";
                }
            }
            listenerSocket.Close();
        }
    }
}