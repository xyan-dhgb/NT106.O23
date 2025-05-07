using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Security.Policy;

namespace Bai02
{
    public partial class Bai02Form : Form
    {
        public Bai02Form()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            // Khởi tạo WebClient
            using (WebClient webClient = new WebClient())
            {
                // Kiểm tra người dùng đã nhập URL hay chưa
                if (string.IsNullOrEmpty(webInputTextBox.Text))
                {
                    MessageBox.Show("YOU NEED TO ENTER URL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra người dùng đã nhập đường dẫn lưu file hay chưa
                if (string.IsNullOrEmpty(downloadTextBox.Text))
                {
                    MessageBox.Show("YOU NEED TO ENTER FILE PATH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Sử dụng phương thức OpenRead để đọc nội dung trang web vào một Stream
                    Stream response = webClient.OpenRead(webInputTextBox.Text);

                    // Sử dụng phương thức DownloadFile để tải nội dung trang web và lưu vào file
                    webClient.DownloadFile(webInputTextBox.Text, downloadTextBox.Text);

                    // Đọc nội dung file đã tải về
                    string result = File.ReadAllText(downloadTextBox.Text);

                    // Hiển thị nội dung file lên contentRichTextBox
                    contentRichTextBox.Text = result;

                    MessageBox.Show("DOWNLOAD AND SAVE SUCCESSFUL!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading the content: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
