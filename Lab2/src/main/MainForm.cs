using Lab_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520101_BaoCaoLab02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            Bai01Form bai1 = new Bai01Form();
            bai1.ShowDialog();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            Bai02Form bai2 = new Bai02Form();
            bai2.ShowDialog();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            Bai03Form bai3 = new Bai03Form();
            bai3.ShowDialog();
        }
        private void Task5Button_Click(object sender, EventArgs e)
        {
            Bai05Form bai5 = new Bai05Form();
            bai5.ShowDialog();
        }

        private void Task6Button_Click(object sender, EventArgs e)
        {
            Bai06Form bai6 = new Bai06Form();
            bai6.ShowDialog();
        }

        private void Task7Button_Click(object sender, EventArgs e)
        {
            Bai07Form bai7 = new Bai07Form();
            bai7.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai4Button_Click(object sender, EventArgs e)
        {
            Bai4Form bai4 = new Bai4Form();
            bai4.ShowDialog();
        }
    }
}
