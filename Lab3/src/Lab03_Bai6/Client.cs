using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Lab_3___Bài_6
{
    public partial class Client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream ns;
        private IPAddress ipAddress;
        private IPEndPoint ipEndPoint;

        private void Client_Load(object sender, EventArgs e)
        {
            InitializeConnection();
            ConnectToServer();
        }

        private void InitializeConnection()
        {
            this.tcpClient = new TcpClient();
        }

        private void ConnectToServer()
        {
            this.tcpClient?.Connect(this.ipEndPoint);
            this.ns = this.tcpClient?.GetStream();
            MessageBox.Show("Connected to the server.");
        }

        private void SendMessage(string message)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            this.ns?.Write(data, 0, data.Length);
        }

        private Dictionary<string, Dictionary<string, List<string>>> privateChats = new Dictionary<string, Dictionary<string, List<string>>>();
        public static event Action<string>? MessageSent;
        public static event Action<string, string>? PrivateMessageSent;
        public static List<Client> AllClients = new List<Client>();

        public Client(string username)
        {
            InitializeComponent();
            textBox1.Text = username;
            MessageSent += UpdateChat;
            PrivateMessageSent += UpdatePrivateChat;
            LoadComboBoxItems();
            AllClients.Add(this);
            this.ipAddress = IPAddress.Parse("127.0.0.1");
            this.ipEndPoint = new IPEndPoint(this.ipAddress, 8080);
        }

        private void LoadComboBoxItems()
        {
            comboBox1.Items.AddRange(Form1.accounts.Keys.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedUser = comboBox1.SelectedItem.ToString();
                textBox4.Text = "";
                if (privateChats.ContainsKey(selectedUser) && privateChats[selectedUser].ContainsKey(textBox1.Text))
                {
                    foreach (var message in privateChats[selectedUser][textBox1.Text])
                    {
                        textBox4.AppendText(message + Environment.NewLine);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text + ": " + textBox3.Text;
            if (comboBox1.SelectedItem != null)
            {
                string recipient = comboBox1.SelectedItem.ToString();
                if (recipient != textBox1.Text)
                {
                    AddPrivateMessage(recipient, message);
                }
                else
                {
                    MessageBox.Show("Bạn không thể tự gửi tin nhắn cho chính mình.");
                }
            }
            else
            {
                MessageSent?.Invoke(message);
            }
            string message1 = textBox2.Text;
            SendMessage(message1);

            textBox3.Clear();
        }

        private void AddPrivateMessage(string recipient, string message)
        {
            if (!privateChats.ContainsKey(recipient))
            {
                privateChats[recipient] = new Dictionary<string, List<string>>();
            }
            if (!privateChats[recipient].ContainsKey(textBox1.Text))
            {
                privateChats[recipient][textBox1.Text] = new List<string>();
            }
            privateChats[recipient][textBox1.Text].Add(message);

            if (!privateChats.ContainsKey(textBox1.Text))
            {
                privateChats[textBox1.Text] = new Dictionary<string, List<string>>();
            }
            if (!privateChats[textBox1.Text].ContainsKey(recipient))
            {
                privateChats[textBox1.Text][recipient] = new List<string>();
            }
            privateChats[textBox1.Text][recipient].Add(message);

            var recipientClient = AllClients.FirstOrDefault(c => c.textBox1.Text == recipient);
            recipientClient?.UpdatePrivateChat(recipient, message);

            if (comboBox1.SelectedItem.ToString() == recipient)
            {
                textBox4.AppendText(message + Environment.NewLine);
            }
        }

        private void UpdateChat(string message)
        {
            if (!textBox2.IsDisposed && comboBox1.SelectedItem == null)
            {
                textBox2.AppendText(message + Environment.NewLine);
                textBox2.SelectionStart = textBox2.Text.Length;
                textBox2.ScrollToCaret();
            }
        }

        private void UpdatePrivateChat(string recipient, string message)
        {
            if (textBox1.Text == recipient)
            {
                textBox4.AppendText(message + Environment.NewLine);
                textBox4.SelectionStart = textBox4.Text.Length;
                textBox4.ScrollToCaret();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
