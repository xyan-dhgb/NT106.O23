using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3___Bài_6
{
    public partial class Form1 : Form
    {
        // Tạo một Dictionary để lưu trữ thông tin tài khoản
        public static Dictionary<string, string> accounts = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            Sign_up signUpForm = new Sign_up();
            signUpForm.Show();
        }
        
        private void signinButton_Click(object sender, EventArgs e)
        {
            string username = nameTextBox.Text;
            string password = textBox2.Text;

            if (accounts.ContainsKey(username))
            {
                if (accounts[username] == password)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Client clientForm = new Client(username);
                    clientForm.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng. Vui lòng kiểm tra lại.");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại. Vui lòng kiểm tra lại.");
            }
            nameTextBox.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            accounts.Clear();
            MessageBox.Show("Đã xóa tất cả dữ liệu tài khoản.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
