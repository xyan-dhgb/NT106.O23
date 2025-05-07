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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }
        private void Bai1Button_Click(object sender, EventArgs e)
        {
            Bai01Form Bai1 = new Bai01Form();
            Bai1.ShowDialog();
        }

        private void Bai2Button_Click(object sender, EventArgs e)
        {
            Bai02Form Bai2 = new Bai02Form();
            Bai2.ShowDialog();
        }
        private void Bai3Button_Click(object sender, EventArgs e)
        {
            Bai03Form Bai3 = new Bai03Form();
            Bai3.ShowDialog();
        }
        // Đọc số nâng cao
        private void Bai31Button_Click(object sender, EventArgs e)
        {
            Bai031Form Bai31 = new Bai031Form();
            Bai31.ShowDialog();
        }
        private void Bai4Button_Click(object sender, EventArgs e)
        {
            Bai04Form Bai4 = new Bai04Form();
            Bai4.ShowDialog();
        }
        private void Bai5Button_Click(object sender, EventArgs e)
        {
            Bai05Form Bai5 = new Bai05Form();
            Bai5.ShowDialog();
        }
        private void Bai06Button_Click(object sender, EventArgs e)
        {
            Bai06Form Bai6 = new Bai06Form();
            Bai6.ShowDialog(); 
        }
        private void Bai07Button_Click(object sender, EventArgs e)
        {
            Bai07Form Bai7 = new Bai07Form();
            Bai7.ShowDialog();
        }

        private void Bai08Button_Click(object sender, EventArgs e)
        {
            AddButton Bai8 = new AddButton();
            Bai8.ShowDialog();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
