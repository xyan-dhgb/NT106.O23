﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05Bai4
{
    public partial class Login : Form
    {
        private string tokentype;
        private string accesstoken;
        public string TokenType
        {
            get { return tokentype; }
            set { tokentype = value; }
        }

        public string AccessToken
        {
            get { return accesstoken; }
            set { accesstoken = value; }
        }
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = nameTextBox.Text;
            string password = passwdTextBox.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            HttpResponseMessage response = await httpClient.PostAsync("auth/token", formData);
            using (response)
            {
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    JObject jsonResponse = JObject.Parse(res);
                    if (jsonResponse["access_token"] != null)
                    {
                        tokentype = jsonResponse["token_type"].ToString();
                        accesstoken = jsonResponse["access_token"].ToString();
                    }
                    Form1 form1 = new Form1(tokentype, accesstoken);
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signupLabel_Click(object sender, EventArgs e)
        {
            Sign_up sign_Up = new Sign_up();
            sign_Up.Show();
        }
    }
}
