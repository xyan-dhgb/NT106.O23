using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai05Form : Form
    {
        private string inputA, inputB;
        public Bai05Form()
        {
            InitializeComponent();
        }
        private bool checkLetter(string input)
        {
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }
            return false;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            inputA = ATextBox.Text.Trim();
            inputB = BTextBox.Text.Trim();
            if (checkLetter(inputA)  || checkLetter(inputB))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            long numberA = long.Parse(inputA);
            long numberB = long.Parse(inputB);
            // Đề kêu tìm bảng cửu chương của B - A
            long subtractForFirstChoice = numberB - numberA;
            StringBuilder resultBox = new StringBuilder();
            // Tính toán nếu user chọn "Bảng cửu chương" của B - A
            if (ChoiceComboBox.Items.Contains("Bảng cửu chương"))
            {
                if (subtractForFirstChoice > 0)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        resultBox.AppendLine($"{subtractForFirstChoice} x {i} = {subtractForFirstChoice * i}");
                    }
                }
                else if (subtractForFirstChoice < 0)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        resultBox.AppendLine($"{subtractForFirstChoice} x {j} = {subtractForFirstChoice * j}");
                    }
                }
                ResultGroupBox.Text = resultBox.ToString();
            }
            // Tính toán nếu user chọn "Tính toán giá trị"
            // (A – B)!
            // Tổng S = A^1 + A^2 + A^3 + A^4 + … +A^B
            long subtractForSecondChoice = numberA - numberB;
            long multiplyFirst = 1;
            long sum = 0;
            if (ChoiceComboBox.Items.Contains("Tính toán giá trị"))
            {
                // (A - B)!
                for(int i = 1; i <= subtractForSecondChoice; i++)
                {
                    multiplyFirst *= i;
                }
                // Tổng S = A^1 + A^2 + A^3 + A^4 + … +A^B
                for (int i = 1; i <= numberB; i++)
                {
                    sum += (long)Math.Pow(numberA, i);
                }
                // Hiển thị kết quả của cả hai biểu thức
                ResultGroupBox.Text = $"(A - B)! = {multiplyFirst}, Tổng S = {sum}";
            }
            
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ATextBox.Clear();
            BTextBox.Clear();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
