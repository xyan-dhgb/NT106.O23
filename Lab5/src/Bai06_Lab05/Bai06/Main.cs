using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;

namespace Bai06
{
    public partial class Bai06Form : Form
    {
        private string account, password;
        private ImapClient imapClient;
        private MailKit.Net.Smtp.SmtpClient smtpClient;
        private bool stopLoadingEmails = false;

        public Bai06Form()
        {
            InitializeComponent();
            imapClient = new ImapClient();
            smtpClient = new MailKit.Net.Smtp.SmtpClient();
            afterLoginPanel.Visible = false;
            loadButton.Enabled = false;
            stopButton.Enabled = false;
        }

        // Đăng nhập
        private async void loginButton_Click(object sender, EventArgs e)
        {
            account = accountTextBox.Text;
            password = passwordTextBox.Text;

            try
            {
                imapClient.ServerCertificateValidationCallback = (certSender, certificate, chain, sslPolicyErrors) => true;
                await imapClient.ConnectAsync(imapTextBox.Text, 993, true);
                await imapClient.AuthenticateAsync(account, password);
                MessageBox.Show("Logged in successfully!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                afterLoginPanel.Visible = true; // Hiển thị bảng điều khiển sau khi đăng nhập
                loadButton.Enabled = true;
                stopButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đăng xuất
        private async void logoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                lock (imapClient.SyncRoot)
                {
                    imapClient.Disconnect(true);
                }
                MessageBox.Show("Logged out successfully!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                afterLoginPanel.Visible = false; // Ẩn bảng điều khiển sau khi đăng xuất
                accountTextBox.Clear();
                passwordTextBox.Clear();
                loadButton.Enabled = false;
                stopButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Logout failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị các email hiện có trong tài khoản
        private async void loadButton_Click(object sender, EventArgs e)
        {
            stopLoadingEmails = false;
            await LoadEmails();
        }

        private async Task LoadEmails()
        {
            try
            {
                lock (imapClient.SyncRoot)
                {
                    imapClient.Inbox.Open(FolderAccess.ReadOnly);
                }

                emailListView.Items.Clear();

                for (int i = 0; i < imapClient.Inbox.Count; i++)
                {
                    if (stopLoadingEmails)
                    {
                        break; // Thoát khỏi vòng lặp nếu stopLoadingEmails là true
                    }

                    MimeMessage message;
                    lock (imapClient.SyncRoot)
                    {
                        message = imapClient.Inbox.GetMessage(i);
                    }

                    var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.DateTime.ToString() });
                    emailListView.Items.Add(item);

                    // Kiểm tra biến stopLoadingEmails thường xuyên
                    await Task.Delay(1); // Giúp nhường thời gian cho việc kiểm tra stopLoadingEmails
                }

                if (stopLoadingEmails)
                {
                    MessageBox.Show("Loading emails stopped.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                emailListView.SelectedIndexChanged += EmailListView_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading emails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EmailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emailListView.SelectedItems.Count == 0)
                return;

            var selectedIndex = emailListView.SelectedItems[0].Index;

            try
            {
                MimeMessage message;
                lock (imapClient.SyncRoot)
                {
                    message = imapClient.Inbox.GetMessage(selectedIndex);
                }
                string emailContent = message.TextBody;

                // Tạo và hiển thị form EmailReading với nội dung email
                EmailReading emailReadingForm = new EmailReading(emailContent);
                emailReadingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading email content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        // Dừng việc load mail
        private void stopButton_Click(object sender, EventArgs e)
        {
            stopLoadingEmails = true;
        }

        private void sendEmailFeatureButton_Click(object sender, EventArgs e)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.ShowDialog();
        }
    }
}
