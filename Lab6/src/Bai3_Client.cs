using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Lab06
{
    public partial class bai3Client : Form
    {
        RSA_Algorithm rsaAlgo = new RSA_Algorithm();
        private RSAParameters serverPublickey;
        public bai3Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        static volatile bool connected = false;

        private void Connect()
        {
            try
            {
                tcpClient = new TcpClient();
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddressTextBox.Text), int.Parse(portTextBox.Text));
                tcpClient.Connect(ipEndPoint);

                rsaAlgo.GenerateKeys();

                // Send client's public key to server
                RSAParameters publicKey = rsaAlgo.GetPublicKey();
                byte[] publicKeyBytes = ConvertRSAParametersToBytes(publicKey);

                SendPublicKey(publicKeyBytes);

                connected = true;

                #region Thông báo đã kết nối thành công
                chatScreenRichTextBox.Invoke(new MethodInvoker(delegate
                {
                    chatScreenRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    chatScreenRichTextBox.SelectionFont = new Font("Lucida Fax", 12, FontStyle.Italic);
                    chatScreenRichTextBox.AppendText("Connected" + Environment.NewLine);
                    chatScreenRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    chatScreenRichTextBox.SelectionFont = new Font("Lucida Fax", 12, FontStyle.Regular);
                }));
                #endregion

                

                #region Điều chỉnh khả năng tương tác với giao diện
                connectButton.Invoke(new MethodInvoker(delegate
                {
                    connectButton.Enabled = false;
                }));
                disconnectButton.Invoke(new MethodInvoker(delegate
                {
                    disconnectButton.Enabled = true;
                }));
                sendButton.Invoke(new MethodInvoker(delegate
                {
                    sendButton.Enabled = true;
                }));
                usernameTextBox.Invoke(new MethodInvoker(delegate
                {
                    usernameTextBox.Enabled = false;
                }));
                ipAddressTextBox.Invoke(new MethodInvoker(delegate
                {
                    ipAddressTextBox.Enabled = false;
                }));
                portTextBox.Invoke(new MethodInvoker(delegate
                {
                    portTextBox.Enabled = false;
                }));
                #endregion

                while (IsConnected(tcpClient))
                {
                    Thread.Sleep(100);
                    Stream stream = tcpClient.GetStream();
                    byte[] bytes = new byte[1024];
                    int count = stream.Read(bytes, 0, bytes.Length);
                    string message = Encoding.UTF8.GetString(bytes, 0, count);

                    if (message == "Server đã đóng, tự động ngắt kết nối" || message == "Client yêu cầu đóng kết nối")
                    {
                        Disconect();
                        return;
                    }

                    chatScreenRichTextBox.Invoke(new MethodInvoker(delegate
                    {
                        chatScreenRichTextBox.AppendText(message);
                    }));

                    if (!IsConnected(tcpClient))
                    {
                        connected = false;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connected = false;
                return;
            }
        }

        private static byte[] ConvertRSAParametersToBytes(RSAParameters parameters)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(parameters.Modulus.Length);
                    writer.Write(parameters.Modulus);
                    writer.Write(parameters.Exponent.Length);
                    writer.Write(parameters.Exponent);
                }
                return stream.ToArray();
            }
        }

        private void SendPublicKey(byte[] publicKey)
        {
            Stream stream = tcpClient.GetStream();
            stream.Write(publicKey, 0, publicKey.Length);
        }

        private static bool IsConnected(TcpClient client)
        {
            try
            {
                if (client != null && client.Client != null && client.Client.Connected)
                {
                    if (client.Client.Poll(0, SelectMode.SelectRead))
                    {
                        byte[] buff = new byte[1];
                        if (client.Client.Receive(buff, SocketFlags.Peek) == 0)
                            return false;
                    }
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void Disconect()
        {
            try
            {
                Thread.Sleep(100);

                string message = "Client yêu cầu đóng kết nối";
                Stream stream = tcpClient.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);

                connected = false;

                tcpClient.Close();
                tcpClient.Dispose();

                #region Thông báo đã ngắt kết nối
                chatScreenRichTextBox.Invoke(new MethodInvoker(delegate
                {
                    chatScreenRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    chatScreenRichTextBox.SelectionFont = new Font("Lucida Fax", 12, FontStyle.Italic);
                    chatScreenRichTextBox.AppendText("Disconected" + Environment.NewLine);
                    chatScreenRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    chatScreenRichTextBox.SelectionFont = new Font("Lucida Fax", 12, FontStyle.Regular);
                }));
                #endregion

                #region Điều chỉnh khả năng tương tác với giao diện
                connectButton.Invoke(new MethodInvoker(delegate
                {
                    connectButton.Enabled = true;
                }));
                disconnectButton.Invoke(new MethodInvoker(delegate
                {
                    disconnectButton.Enabled = false;
                }));
                sendButton.Invoke(new MethodInvoker(delegate
                {
                    sendButton.Enabled = false;
                }));
                usernameTextBox.Invoke(new MethodInvoker(delegate
                {
                    usernameTextBox.Enabled = true;
                }));
                ipAddressTextBox.Invoke(new MethodInvoker(delegate
                {
                    ipAddressTextBox.Enabled = true;
                }));
                portTextBox.Invoke(new MethodInvoker(delegate
                {
                    portTextBox.Enabled = true;
                }));
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connected = false;
                return;
            }

        }


        private void sendButton_Click_1(object sender, EventArgs e)
        {
            if (importTextBox.Text != string.Empty)
            {
                string message = "[" + usernameTextBox.Text + "]: " + importTextBox.Text + "\r\n";
                Stream stream = tcpClient.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);

                chatScreenRichTextBox.Invoke(new MethodInvoker(delegate
                {
                    chatScreenRichTextBox.AppendText(message);
                }));
                importTextBox.Invoke(new MethodInvoker(delegate
                {
                    importTextBox.Clear();
                }));
            }
        }

        private void connectButton_Click_1(object sender, EventArgs e)
        {
            #region Yêu cầu nhập
            if (usernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ipAddressTextBox.Text == string.Empty)
            {
                MessageBox.Show("IP Address is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (portTextBox.Text == string.Empty)
            {
                MessageBox.Show("Port is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Tạo client Thread
            Thread thread = new Thread(Connect);
            thread.IsBackground = true;
            thread.Start();
            #endregion
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Disconect();
        }
    }
}
