using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Net;
using System.Windows.Forms;

namespace Lab05Bai4
{
    public partial class EmailSetting : Form
    {
        public EmailSetting()
        {
            InitializeComponent();
        }

        
        // Kiểm tra kết nối 
        private void button1_Click(object sender, EventArgs e)
        {

            bool b = false;
            if (checkBox2.Checked)
            {
                b = true;
            }
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect(txtsmtp.Text, (int)numericUpDown2.Value, SecureSocketOptions.StartTls);
            try
            {
                smtpClient.Authenticate(txtname.Text, txtmatkhau.Text);
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(txtnickname.Text, txtname.Text));
                mimeMessage.To.Add(new MailboxAddress("", "22520101@gm.uit.edu.vn"));
                mimeMessage.Body = new TextPart("plain")
                {
                    Text = "Test",
                };
                smtpClient.Send(mimeMessage);
                MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed");
            }
        }

        // Đồng ý cài đặt và thoát
        private void button2_Click_1(object sender, EventArgs e)
        {
            string a = "false";
            if (checkBox2.Checked)
            {
                a = "true";
            }
            string mailServer = txtsmtp.Text;
            int port = (int)numericUpDown2.Value;
            string username = txtname.Text;
            string password = txtmatkhau.Text;
            string nickname = txtnickname.Text;
            // Lưu thông tin cấu hình vào SQLite
            ConfigHelper.SaveConfig(mailServer, port, username, password, a, nickname);
            MessageBox.Show("Config saved successfully!");
            this.Close();
        }
    }
}
