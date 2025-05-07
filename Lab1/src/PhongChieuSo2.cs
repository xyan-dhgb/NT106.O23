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
    public partial class SecondScreen : Form
    {
        public SecondScreen()
        {
            InitializeComponent();
        }

        private void BuyingButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            double vevot = 0, vethuong = 0, veVip = 0;
            double result = 0;
            string selectedMovie = ChooseComboBox.SelectedItem.ToString();
            if (selectedMovie == "Đào, phở và piano")
            {
                double veB1 = 0, veB5 = 0;
                if (A1.Checked || A5.Checked || C1.Checked || C5.Checked)
                {
                    vevot++;
                }
                if (A2.Checked || A3.Checked || A4.Checked || C2.Checked || C3.Checked || C4.Checked)
                {
                    vethuong++;
                }
                if (B2.Checked || B3.Checked || B4.Checked)
                {
                    veVip++;
                }
                if (B1.Checked)
                {
                    veB1++;
                }
                if (B5.Checked)
                {
                    veB5++;
                }
                result = (vevot * 45000 * 0.25) + (vethuong * 45000) + (veB1 * 45000) + (veB5 * 45000) + (veVip * 45000 * 2);
                // Xuất kết quả ra màn hình thông tin về thông tin khách hàng bao gồm: họ và tên, vé đã chọn,
                // tên phim, phòng chiếu, số tiền cần phải thanh toán.
                MessageBox.Show($"Họ và tên khách hàng: {name} \n" +
                                $"Tên phim: {selectedMovie} \n" +
                                $"Phòng chiếu: 1 \n" +
                                $"Số vé vớt: {vevot}\n" +
                                $"Số vé thường: {vethuong}\n" +
                                $"Số vé VIP: {veVip}\n" +
                                $"Tổng tiền cần thanh toán: {result}");
                return;
            }
            if (selectedMovie == "Mai")
            {
                double b1Ticket = 0, b5Ticket = 0;
                if (A1.Checked || A5.Checked || C1.Checked || C5.Checked)
                {
                    vevot++;
                }
                if (A2.Checked || A3.Checked || A4.Checked || C2.Checked || C3.Checked || C4.Checked)
                {
                    vethuong++;
                }
                if (B2.Checked || B3.Checked || B4.Checked)
                {
                    veVip++;
                }
                if (B1.Checked)
                {
                    b1Ticket++;
                }
                if (B5.Checked)
                {
                    b5Ticket++;
                }
                result = (vevot * 100000 * 0.25) + (vethuong * 100000) + (b1Ticket * 100000) + (b5Ticket * 100000) + (veVip * 100000 * 2);
                MessageBox.Show($"Họ và tên khách hàng: {name} \n" +
                                $"Tên phim: {selectedMovie} \n" +
                                $"Phòng chiếu: 1 \n" +
                                $"Số vé vớt: {vevot}\n" +
                                $"Số vé thường: {vethuong}\n" +
                                $"Số vé VIP: {veVip}\n" +
                                $"Tổng tiền cần thanh toán: {result}");
                return;
            }
        }
    }
}
