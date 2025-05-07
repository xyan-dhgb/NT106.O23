using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Bai06
{
    public partial class SendEmail : Form
    {
        private string attachmentFilePath; // Link đính kèm tập tin
        public SendEmail()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fromTextBox.Text) || string.IsNullOrEmpty(toTextBox.Text) || string.IsNullOrEmpty(subjectTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("You need to fill all!", "Annonucement!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string from, to, pass, content;
            from = fromTextBox.Text.Trim();
            to = toTextBox.Text.Trim();
            pass = passwordTextBox.Text.Trim();
            content = contentRichTextBox.Text;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to); // Địa chỉ người nhận
            mailMessage.From = new MailAddress(from); // Địa chỉ người gửi
            mailMessage.Subject = subjectTextBox.Text;
            mailMessage.Body = contentRichTextBox.Text;

            if (string.IsNullOrEmpty(filePathTextBox.Text))
            {
                MessageBox.Show("You need to choose your file", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Đính kèm file vào email
                Attachment attachment = new Attachment(filePathTextBox.Text);
                mailMessage.Attachments.Add(attachment);
            }

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass); // Từ email và mật khẩu của người gửi
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đóng form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Đính kèm file
        private void browsePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        // Xóa thông tin để gửi mail khác
        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            fromTextBox.Clear();
            toTextBox.Clear();
            subjectTextBox.Clear();
            passwordTextBox.Clear();
            filePathTextBox.Clear();
        }
    }
}
