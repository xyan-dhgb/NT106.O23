using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _22520101_DinhHuynhGiaBao_Lab03_Bai1
{
    public partial class Bai1Form : Form
    {
        public Bai1Form()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            UDP_CLIENT client = new UDP_CLIENT();
            client.Show();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            UDP_SERVER server = new UDP_SERVER();
            server.Show();
        }
    }
}
