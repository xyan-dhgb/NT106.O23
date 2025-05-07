using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace Bai03
{
    public partial class Bai03Form : Form
    {
        public Bai03Form()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private string filePath = "D:\\bai3.html";
        private string saveDirectory = "D:\\";
        private async void InitializeWebView()
        {
            // Kiểm tra và đảm bảo WebView2 đã được cài đặt
            await webView.EnsureCoreWebView2Async(null);
        }

        private void Checking(string URL)
        {
            if (string.IsNullOrEmpty(urlTextBox.Text))
            {
                MessageBox.Show("YOU NEED TO ENTER URL!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Checking(urlTextBox.Text);
            try
            {
                // Kiểm tra nếu CoreWebView2 đã khởi tạo
                if (webView.CoreWebView2 != null)
                {
                    // Load trang web trong WebView
                    webView.CoreWebView2.Navigate(urlTextBox.Text);
                }
                else
                {
                    MessageBox.Show("WebView is not initialized yet. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the webpage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileDownLoadButton_Click(object sender, EventArgs e)
        {
            Checking(urlTextBox.Text);
            WebClient webClient = new WebClient();
            Stream response = webClient.OpenRead(urlTextBox.Text);
            webClient.DownloadFile(urlTextBox.Text, filePath);
            MessageBox.Show("DOWNLOAD AND SAVE SUCCESSFUL!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resourceDownloadButton_Click(object sender, EventArgs e)
        {
            Checking(urlTextBox.Text);

            try
            {
                string url = urlTextBox.Text;
                var web = new HtmlAgilityPack.HtmlWeb();
                var doc = web.Load(url);

                var client = new WebClient();
                Stream read = client.OpenRead(url);
                foreach (HtmlNode imgNode in doc.DocumentNode.SelectNodes("//img"))
                {
                    var imgUrl = imgNode.Attributes["src"].Value;

                    // Kiểm tra xem URL hình ảnh có đầy đủ không
                    if (!string.IsNullOrEmpty(imgUrl))
                    {
                        // Kiểm tra nếu URL là đường dẫn tương đối
                        if (!Uri.IsWellFormedUriString(imgUrl, UriKind.Absolute))
                        {
                            // Chuyển đổi URL tương đối thành URL tuyệt đối
                            Uri baseUri = new Uri(url);
                            imgUrl = new Uri(baseUri, imgUrl).AbsoluteUri;
                        }

                        // Tải xuống hình ảnh và lưu vào thư mục cục bộ
                        string fileName = Path.GetFileName(imgUrl);
                        string savePath = Path.Combine(saveDirectory, fileName);
                        client.DownloadFile(imgUrl, savePath);
                    }
                }

                MessageBox.Show("Images downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
