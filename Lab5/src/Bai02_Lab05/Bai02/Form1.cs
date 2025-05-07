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
using MailKit; // MailKit là một thư viện .NET mã nguồn mở cho IMAP, POP3 và SMTP
using System.Runtime.InteropServices;
using Org.BouncyCastle.Asn1.Cms;
using MailKit.Net.Imap;
using MimeKit;



namespace Bai02
{
    public partial class Bai02Form : Form
    {
        public Bai02Form()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwdTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("You need to enter both informtion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadEmails(email, password);
            }
        }

        private async void LoadEmails(string email, string password)
        {
            try
            {
                using (var imapClient = new ImapClient())
                {
                    // Bỏ qua kiểm tra chứng chỉ
                    imapClient.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                    await imapClient.ConnectAsync("imap.gmail.com", 993, true);
                    await imapClient.AuthenticateAsync(email, password);

                    var inbox = imapClient.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    dataGridView.Rows.Clear();
                    
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = await inbox.GetMessageAsync(i);
                        dataGridView.Rows.Add(message.Subject, message.From.ToString(), message.Date.DateTime);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
