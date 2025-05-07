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
using MailKit.Net.Pop3;
using MimeKit;
using MailKit.Net.Pop3;



namespace Bai03
{
    public partial class Bai03Form : Form
    {
        public Bai03Form()
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
                using (var popClient = new Pop3Client())
                {
                    // Bỏ qua kiểm tra chứng chỉ
                    popClient.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                    await popClient.ConnectAsync("pop.gmail.com", 995, true);
                    await popClient.AuthenticateAsync(email, password);


                    dataGridView.Rows.Clear();

                    for (int i = 0; i < popClient.Count; i++)
                    {
                        var message = await popClient.GetMessageAsync(i);
                        dataGridView.Rows.Add(message.Subject, message.From.ToString(), message.Date.DateTime);
                    }
                    await popClient.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
