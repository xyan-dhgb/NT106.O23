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
    public partial class Bai06Form : Form
    {
        public Bai06Form()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            string date = DatePicker.Text.Trim();
            string[] data = date.Split('/');
            string day = data[0];
            string month = data[1];
            string finalDay = day.TrimStart('0');
            string finalMonth = month.TrimStart('0');
            int zodiacDay = int.Parse(finalDay);
            int zodiacMonth = int.Parse(finalMonth);
            string zodiacSign = String.Empty;
            switch(zodiacMonth)
            {
                case 1:
                    zodiacSign = (zodiacDay <= 20) ? "Ma Kết" : "Bảo Bình";
                    break;
                case 2:
                    zodiacSign = (zodiacDay <= 19) ? "Bảo Bình" : "Song Ngư";
                    break;
                case 3:
                    zodiacSign = (zodiacDay <= 20) ? "Song Ngư" : "Bạch Dương";
                    break;
                case 4:
                    zodiacSign = (zodiacDay <= 20) ? "Bạch Dương" : "Kim Ngưu";
                    break;
                case 5:
                    zodiacSign = (zodiacDay <= 21) ? "Kim Ngưu" : "Song Tử";
                    break;
                case 6:
                    zodiacSign = (zodiacDay <= 21) ? "Song Tử" : "Cự Giải";
                    break;
                case 7:
                    zodiacSign = (zodiacDay <= 22) ? "Cự Giải" : "Sư Tử";
                    break;
                case 8:
                    zodiacSign = (zodiacDay <= 23) ? "Sư Tử" : "Xử Nữ";
                    break;
                case 9:
                    zodiacSign = (zodiacDay <= 23) ? "Xử Nữ" : "Thiên Bình";
                    break;
                case 10:
                    zodiacSign = (zodiacDay <= 23) ? "Thiên Bình" : "Thần Nông";
                    break;
                case 11:
                    zodiacSign = (zodiacDay <= 22) ? "Thần Nông" : "Nhân Mã";
                    break;
                case 12:
                    zodiacSign = (zodiacDay <= 21) ? "Nhân Mã" : "Ma Kết";
                    break;
                default:
                    zodiacSign = "Không xác định, vui lòng nhập lại thời gian";
                    break;
            }
            ResultTextbox.Text = zodiacSign;
        }
    }
}
