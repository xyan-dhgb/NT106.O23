using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    
    public partial class Bai04Form : Form
    {
        public Bai04Form()
        {
            InitializeComponent();

        }
        private void FirstScreen_Click(object sender, EventArgs e)
        {
            FirstScreen PhongChieuSoMot = new FirstScreen();
            PhongChieuSoMot.ShowDialog();
        }

        private void SecondScreen_Click(object sender, EventArgs e)
        {
            SecondScreen PhongChieuSoHai = new SecondScreen();
            PhongChieuSoHai.ShowDialog();
        }

        private void ThirdScreen_Click(object sender, EventArgs e)
        {
            ThirdScreen PhongChieuSoBa = new ThirdScreen();
            PhongChieuSoBa.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
