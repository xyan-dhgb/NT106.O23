using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class bai02Form : Form
    {
        public bai02Form()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string plainText = plainTextRichTextBox.Text;
            string key = keyTextBox.Text;

            if (!string.IsNullOrEmpty(keyTextBox.Text)) 
            {
                string encodedText = encodedVigenere(plainText, key);
                encodeRichTextBox.Text = encodedText;
            }

            else
            {
                MessageBox.Show("Please enter a valid key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string encodedText = encodeRichTextBox.Text;
            string key = keyTextBox.Text;

            if (!string.IsNullOrEmpty(keyTextBox.Text))
            {
                string decodedText = decodedVigenere(encodedText, key);
                decodeRichTextBox.Text = decodedText;
            }

            else
            {
                MessageBox.Show("Please enter a valid key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string encodedVigenere (string plainText, string key)
        {
            return VigenereCode(plainText, key, true);
        }

        private string decodedVigenere(string plainText, string key)
        {
            return VigenereCode(plainText, key, false);
        }

        // Mã hóa hoặc giải mã văn bản sử dụng thuật toán Vigenère
        // encode là biến boolean xác định mã hóa (true) hay giải mã (false).
        private string VigenereCode (string text, string key, bool encode)
        {
            char[] bufferArray = text.ToCharArray();
            int keyIndex = 0, keyLength = key.Length;

            for (int index = 0;  index < bufferArray.Length; index++)
            {
                char letter = bufferArray[index];
                if (char.IsLetter(letter))
                {
                    char startValue = char.IsUpper(letter) ? 'A' : 'a';
                    int keyOffset = char.IsUpper(key[keyIndex % keyLength]) ? 'A' : 'a';
                    int shift = (key[keyIndex % keyLength] - keyOffset) * (encode ? 1 : -1);
                    letter = (char)(((letter + shift - startValue + 26) % 26) + startValue);
                    keyIndex++;
                }
                bufferArray[index] = letter;
            }
            return new string(bufferArray);            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            plainTextRichTextBox.Clear();
            keyTextBox.Clear();
            encodeRichTextBox.Clear();
            decodeRichTextBox.Clear();
        }
    }
}
