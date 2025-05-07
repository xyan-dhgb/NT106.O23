using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai4Form : Form
    {
        public Bai4Form()
        {
            InitializeComponent();
        }
        string filePath;
        private void readFileButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text |*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                ReadFile();
            }
        }
        private void ReadFile()
        {
            FileStream fileStream = new FileStream("ENTER-YOUR-FILE-PATH", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            studentInfoTextBox.Text = streamReader.ReadToEnd();

            streamReader.Close();
            fileStream.Close();

            if (studentInfoTextBox.Text != string.Empty)
            {
                numPage = 1;
                ReadEachStudent();
            }
            else
            {
                numPage = 0;
                pageNumLabel.Text = "NaN";
                backButton.Enabled = false;
                nextButton.Enabled = false;
            }
        }
        int numPage = 1;
        private void ReadEachStudent()
        {
            try
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);

                for (int i = 0; i < (numPage - 1) * 7; i++)
                {
                    streamReader.ReadLine();
                }

                pageNumLabel.Text = numPage.ToString();
                nameOutput.Text = streamReader.ReadLine();
                idOutput.Text = streamReader.ReadLine();
                phoneOutput.Text = streamReader.ReadLine();
                course1Output.Text = streamReader.ReadLine();
                course2Output.Text = streamReader.ReadLine();
                course3Output.Text = streamReader.ReadLine();
                double averageScore = (double.Parse(course1Output.Text) + double.Parse(course2Output.Text) + double.Parse(course3Output.Text)) / 3;
                averageOutput.Text = averageScore.ToString();
                streamReader.ReadLine();

                backButton.Enabled = true;
                nextButton.Enabled = true;
                if (numPage == 1)
                {
                    backButton.Enabled = false;
                }
                if (streamReader.Peek() == -1)
                {
                    nextButton.Enabled = false;
                }

                streamReader.Close();
                fileStream.Close();
            }
            catch
            {
                MessageBox.Show("File được đọc không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void nextButton_Click_1(object sender, EventArgs e)
        {
            numPage++;
            ReadEachStudent();
        }
        private void backButton_Click_1(object sender, EventArgs e)
        {
            numPage--;
            ReadEachStudent();
        }

        private void writeFileButton_Click_1(object sender, EventArgs e)
        {
            if (nameInput.Text != string.Empty && idInput.Text != string.Empty && phoneInput.Text != string.Empty && course1Input.Text != string.Empty && course2Input.Text != string.Empty && course3Input.Text != string.Empty)
            {
                int temp;
                if (!int.TryParse(idInput.Text, out temp) && idInput.Text.Length != 8)
                {
                    MessageBox.Show("Mã sinh viên phải là một số có 8 chữ số!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(phoneInput.Text, out temp) && phoneInput.Text.Length != 10 && phoneInput.Text[0] != '0')
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bởi số 0!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (double.Parse(course1Input.Text) < 0 || double.Parse(course1Input.Text) > 10 || double.Parse(course2Input.Text) < 0 || double.Parse(course2Input.Text) > 10 || double.Parse(course3Input.Text) < 0 || double.Parse(course3Input.Text) > 10)
                {
                    MessageBox.Show("Các điểm của từng học phần phải từ 0 đến 10!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    studentInfoTextBox.AppendText(Environment.NewLine);
                    studentInfoTextBox.AppendText(nameInput.Text + Environment.NewLine);
                    studentInfoTextBox.AppendText(idInput.Text + Environment.NewLine);
                    studentInfoTextBox.AppendText(phoneInput.Text + Environment.NewLine);
                    studentInfoTextBox.AppendText(course1Input.Text + Environment.NewLine);
                    studentInfoTextBox.AppendText(course2Input.Text + Environment.NewLine);
                    studentInfoTextBox.AppendText(course3Input.Text + Environment.NewLine);
                    studentInfoTextBox.AppendText(averageInput.Text + Environment.NewLine);

                    FileStream fileStream = new FileStream("ENTER-YOUR-FILE-PATH", FileMode.Open, FileAccess.Write);
                    StreamWriter streamWrite = new StreamWriter(fileStream);
                    streamWrite.Write(studentInfoTextBox.Text);
                    streamWrite.Close();
                    fileStream.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
