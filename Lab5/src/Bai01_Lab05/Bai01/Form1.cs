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


namespace Bai01
{
    public partial class Bai01Form : Form
    {
        private string placeholderFrom = "From";
        private string placeholderTo = "To";
        private string placeholderSubject = "Subject";
        private string placeholderPassword = "Password";
        public Bai01Form()
        {
            InitializeComponent();
        }

        private void fromTextBox_Enter(object sender, EventArgs e)
        {
            if (fromTextBox.Text == placeholderFrom)
            {
                fromTextBox.Text = "";
                fromTextBox.ForeColor = Color.Black;
            }
        }

        private void fromTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fromTextBox.Text))
            {
                fromTextBox.Text = placeholderFrom;
                fromTextBox.ForeColor = Color.Gray;
            }
        }

        private void toTextBox_Enter(object sender, EventArgs e)
        {
            if (toTextBox.Text == placeholderTo)
            {
                toTextBox.Text = "";
                toTextBox.ForeColor = Color.Black;
            }
        }

        private void toTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toTextBox.Text))
            {
                toTextBox.Text = placeholderTo;
                toTextBox.ForeColor = Color.Gray;
            }
        }

        private void subjectTextBox_Enter(object sender, EventArgs e)
        {
            if (subjectTextBox.Text == placeholderSubject)
            {
                subjectTextBox.Text = "";
                subjectTextBox.ForeColor = Color.Black;
            }
        }

        private void subjectTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                subjectTextBox.Text = placeholderSubject;
                subjectTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwdTextBox_Enter(object sender, EventArgs e)
        {
            if (passwdTextBox.Text == placeholderPassword)
            {
                passwdTextBox.Text = "";
                passwdTextBox.ForeColor = Color.Black;
            }
        }

        private void passwdTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwdTextBox.Text))
            {
                passwdTextBox.Text = placeholderPassword;
                passwdTextBox.ForeColor = Color.Gray;
            }
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = fromTextBox.Text.Trim();
            to = toTextBox.Text.Trim();
            pass = passwdTextBox.Text.Trim();
            content = contentRichTextBox.Text;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to); // Địa chỉ người nhận
            mailMessage.From = new MailAddress(from); // Địa chỉ người gửi
            mailMessage.Subject = subjectTextBox.Text;
            mailMessage.Body = contentRichTextBox.Text;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass); // From gmail of sender (from), password of gmail of sender
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
