using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai03Form : Form
    {
        private string input;
        public Bai03Form()
        {
            InitializeComponent();
        }
        private bool checkLetter(string letterString)
        {
            foreach (char character in letterString)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }
            return false;
        }
        static string DocSo(string so)
        {
            string[] donVi = { "", "mốt", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] chuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] tram = { "", "trăm", "nghìn", "triệu", "tỷ" };

            string chuoiSo = "";
            int n = so.Length;
            for (int i = 0; i < n; i++)
            {
                int soHang = n - i - 1;
                int chuSo = so[i] - '0';

                // Đọc đơn vị
                if (soHang % 3 == 2)
                {
                    chuoiSo = donVi[chuSo] + " " + chuoiSo;
                }

                // Đọc chục
                else if (soHang % 3 == 1)
                {
                    if (chuSo == 1)
                    {
                        chuoiSo = "mười" + " " + chuoiSo;
                    }
                    else if (chuSo > 0)
                    {
                        chuoiSo = chuc[chuSo] + " " + chuoiSo;
                    }
                }

                // Đọc trăm
                else if (soHang % 3 == 0)
                {
                    if (chuSo > 0)
                    {
                        chuoiSo = donVi[chuSo] + " " + tram[soHang / 3] + " " + chuoiSo;
                    }
                }
            }

            // Xử lý trường hợp số có 12 chữ số
            if (n == 12 && so[0] == '0')
            {
                chuoiSo = "không " + chuoiSo;
            }

            return chuoiSo;
        }
        private void ReadingButton_Click(object sender, EventArgs e)
        {
            input = InputTextBox.Text.Trim();
            if (checkLetter(input))
            {
                MessageBox.Show("Bạn cần nhập số nguyên!");
                return;
            }
            long number = long.Parse(input);
            string result;
            switch (number)
            {
                case 0: 
                    result = "Không";
                    ResultTextBox.Text = result;
                    break;
                case 1:
                    result = "Một";
                    ResultTextBox.Text = result;
                    break;
                case 2:
                    result = "Hai";
                    ResultTextBox.Text = result;
                    break;
                case 3:
                    result = "Ba";
                    ResultTextBox.Text = result;
                    break;
                case 4:
                    result = "Bốn";
                    ResultTextBox.Text = result;
                    break;
                case 5:
                    result = "Năm";
                    ResultTextBox.Text = result;
                    break;
                case 6:
                    result = "Sáu";
                    ResultTextBox.Text = result;
                    break;
                case 7:
                    result = "Bảy";
                    ResultTextBox.Text = result;
                    break;
                case 8:
                    result = "Tám";
                    ResultTextBox.Text = result;
                    break;
                case 9:
                    result = "Chín";
                    ResultTextBox.Text = result;
                    break;
                default:
                    result = "Không thể đọc được số của bạn!";
                    break;
            }
        }
        private void DeletingButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            ResultTextBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
