using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Lab06
{
    public partial class bai01Form : Form
    {
        public bai01Form()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string plainText = plainTextRichTextBox.Text;
            
            if (int.TryParse(shiftTextBox.Text, out int shiftNum))
            {
                string encodedText = CaesarEncoded(plainText, shiftNum);
                encodeRichTextBox.Text = encodedText;
            }

            else
            {
                MessageBox.Show("Please enter a valid number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private string CaesarEncoded(string text, int shift)
        {
            // Tạo mảng ký tự lưu trữ các ký tự của chuỗi đầu vào
            char[] bufferArray = text.ToCharArray();

            // Duyệt qua từng ký tự trong mảng bufferArray
            for (int index = 0; index < bufferArray.Length; index++)
            {
                char letter = bufferArray[index];
                // Kiểm tra xem letter có phải là một ký tự chữ cái
                if (char.IsLetter(letter)) 
                {
                    // Xác định giá trị bắt đầu của bảng chữ cái
                    char startValue = char.IsUpper(letter) ? 'A' : 'a';

                    // letter + shift dịch chuyển ký tự letter theo giá trị shift
                    // letter - startValue điều chỉnh giá trị ASCII của letter để bắt đầu từ 0 thay vì từ giá trị ASCII của 'A' hoặc 'a'
                    // (letter + shift - offset) % 26 đảm bảo rằng kết quả luôn nằm trong phạm vi của bảng chữ cái (0-25)
                    // + startValue thêm lại giá trị bắt đầu của bảng chữ cái để có giá trị ASCII đúng cho ký tự mã hóa.
                    letter = (char)(((letter + shift - startValue) % 26) + startValue);
                }

                bufferArray[index] = letter;
            }

            return new string(bufferArray);
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string encodedText = encodeRichTextBox.Text;
            if (int.TryParse(shiftTextBox.Text, out int shift))
            {
                // Sử dụng cùng phương thức nhưng với shift âm để giải mã
                string decodedText = CaesarEncoded(encodedText, -shift); 
                decodeRichTextBox.Text = decodedText;
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            plainTextRichTextBox.Clear();
            shiftTextBox.Clear();
            encodeRichTextBox.Clear();
            decodeRichTextBox.Clear();
        }
    }
}
