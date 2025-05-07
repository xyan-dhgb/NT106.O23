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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void bai1Button_Click(object sender, EventArgs e)
        {
            bai01Form bai1 = new bai01Form();
            bai1.ShowDialog();
        }

        private void bai2Button_Click(object sender, EventArgs e)
        {
            bai02Form bai2 = new bai02Form();
            bai2.ShowDialog();
        }

        private void bai3Button_Click(object sender, EventArgs e)
        {
            bai03Form bai03Form = new bai03Form();
            bai03Form.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
