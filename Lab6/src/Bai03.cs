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
    public partial class bai03Form : Form
    {
        public bai03Form()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            bai3Client client = new bai3Client();
            client.Show();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            bai3Server server = new bai3Server();
            server.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
