using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520101_BaoCaoLab02
{
    public partial class Bai02Form : Form
    {
        public Bai02Form()
        {
            InitializeComponent();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            // Láy thông tin cơ bản của file
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên file
                string nameOfFile = Path.GetFileName(openFile.FileName);
                NameTextBox.Text = nameOfFile;

                // Lấy kích thước file
                FileInfo fileInformation = new FileInfo(openFile.FileName);
                long lengthOfFile = fileInformation.Length;
                string returnSize = $"{lengthOfFile} bytes";
                SizeTextBox.Text = returnSize;

                // Lấy đường dẫn URL
                string URL = openFile.FileName;
                URLTextBox.Text = URL;

                // Số dòng
                int lineCount = File.ReadLines(openFile.FileName).Count();
                LineCountTextBox.Text = lineCount.ToString();

                // Số từ
                string[] words = File.ReadAllText(openFile.FileName).Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                WordCountTextBox.Text = wordCount.ToString();

                // Số ký tự
                int characterCount = File.ReadAllText(openFile.FileName).Length;
                CharacterCountTextBox.Text = characterCount.ToString();
            }
            // Hiển thị nội dung
            FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open);
            StreamReader streamRead = new StreamReader(fileStream);
            string content = streamRead.ReadToEnd();
            ContentRichTextBox.Text = content;
            streamRead.Close();
            fileStream.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
