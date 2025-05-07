using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NCalc;
using System.Linq.Expressions;
using static System.Windows.Forms.LinkLabel;

namespace _22520101_BaoCaoLab02
{
    public partial class Bai03Form : Form
    {
        private string content;
        public Bai03Form()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            // Hiển thị nội dung file input3.txt thông qua một RichTextBox 
            FileStream fileInputStream = new FileStream("ENTER-YOUR-FILE-PATH", FileMode.Open);
            StreamReader streamRead = new StreamReader(fileInputStream);
            content = streamRead.ReadToEnd();
            ContentRichTextBox.Text = content;
            streamRead.Close();
            fileInputStream.Close();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            // Đọc từng dòng từ các nội dung trong ContentRichTextBox
            string[] lines = ContentRichTextBox.Text.Split('\n');

            FileStream fileOutputStream = new FileStream("ENTER-YOUR-FILE-PATH", FileMode.Create);
            StreamWriter streamWrite = new StreamWriter(fileOutputStream);

            // Xử lý biểu thức tính toán trên từng dòng
            foreach (string line in lines)
            {
                // Sử dụng NCalc để tính toán biểu thức từ mỗi dòng
                NCalc.Expression expressionOfFile = new NCalc.Expression(line);
                string result = expressionOfFile.Evaluate().ToString();

                // Ghi kết quả vào file output3.txt
                streamWrite.WriteLine(result);
            }

            // Đóng StreamWriter sau khi đã ghi xong
            streamWrite.Close();
        }
    }
}

