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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string rePassword = textBox3.Text;

            if (password == rePassword)
            {
                if (Form1.accounts.ContainsKey(username))
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng chọn một username khác.");
                    return;
                }

                MessageBox.Show("Tạo tài khoản thành công!");
                Form1.accounts[username] = password;

                //Form1 chatRoomForm = new Form1();
                //chatRoomForm.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp. Vui lòng thử lại.");
            }
            this.Close();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}
