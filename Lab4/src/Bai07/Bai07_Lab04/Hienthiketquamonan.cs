using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05Bai4
{
    public partial class Hienthiketquamonan : Form
    {
        int a = 0;
        string in4 = "";
        public Hienthiketquamonan(Control selectedControl, string s, int dem)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(selectedControl);
            in4 = s;
            a = dem;
        }

    }
}
