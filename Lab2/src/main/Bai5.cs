using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace _22520101_BaoCaoLab02
{
    public partial class Bai05Form : Form
    {
        public Bai05Form()
        {
            InitializeComponent();
        }
        public class Movie
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public List<int> PhongChieu { get; set; }
            public Dictionary<int, List<bool>> ChoNgoi { get; set; }
            public int SoVeBanRa { get; set; }
            public int SoLuongVeTon { get; set; }
            public double TiLeVeBanRa { get; set; }
            public int DoanhThu { get; set; }
            public int XepHangDoanhThu { get; set; }
            public Movie()
            {
                ChoNgoi = new Dictionary<int, List<bool>>();
                SoVeBanRa = 0;
            }

        }

        List<Movie> movies;

        private void readFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON file |*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string jsonContent = File.ReadAllText(filePath);
                    movies = JsonSerializer.Deserialize<List<Movie>>(jsonContent);

                    foreach (Movie movie in movies)
                    {
                        movieNameComboBox.Items.Add(movie.TenPhim);
                        movie.SoLuongVeTon = 15 * movie.PhongChieu.Count;
                        foreach (int phong in movie.PhongChieu)
                        {
                            List<bool> list = Enumerable.Repeat(false, 15).ToList<bool>();
                            movie.ChoNgoi.Add(phong, list);
                        }
                    }

                    movieInfoPanel.Enabled = true;
                    exportButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void movieNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatsPanel.Enabled = false;
            infoPanel.Enabled = false;
            roomComboBox.Text = string.Empty;
            roomComboBox.Items.Clear();
            string selectedMovieName = movieNameComboBox.Text;

            Movie selectedMovie;
            foreach (Movie movie in movies)
            {
                if (movie.TenPhim == selectedMovieName)
                {
                    selectedMovie = movie;
                    foreach (int room in selectedMovie.PhongChieu)
                    {
                        roomComboBox.Items.Add(room);
                    }
                    movieNameComboBox.Text = selectedMovieName;
                    return;
                }
            }
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatsPanel.Enabled = true;
            infoPanel.Enabled = true;
            roomTextBox.Text = roomComboBox.Text;
            movieTextBox.Text = movieNameComboBox.Text;
            seatsTextBox.Clear();
            totalMoneyTextBox.Text = "0";

            Dictionary<int, List<bool>> seats;
            foreach (Movie movie in movies)
            {
                if (movie.TenPhim == movieNameComboBox.Text)
                {
                    seats = movie.ChoNgoi;
                    List<bool> seatStatus = seats[int.Parse(roomComboBox.Text)];
                    for (int i = 0; i < 15; i++)
                    {
                        CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + (i + 1).ToString(), true)[0];
                        if (seatStatus[i] == false)
                        {
                            cb.Enabled = true;
                            cb.Checked = false;

                            if (LoaiGhe(TenGhe(i)) == "Vot")
                            {
                                cb.BackColor = Color.Gray;
                            }
                            else if (LoaiGhe(TenGhe(i)) == "Chuan")
                            {
                                cb.BackColor = Color.White;
                            }
                            else if (LoaiGhe(TenGhe(i)) == "VIP")
                            {
                                cb.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            cb.Enabled = false;
                            cb.Checked = true;
                            cb.BackColor = Color.Black;
                        }
                    }

                    standardPriceTextBox.Text = movie.GiaVeChuan.ToString();
                }
            }
        }
        private void SeatCheckChanged(object sender, EventArgs e)
        {
            seatsTextBox.Clear();
            totalMoneyTextBox.Text = "0";
            int totalMoney = 0;

            for (int i = 0; i < 15; i++)
            {
                CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + (i + 1).ToString(), true)[0];
                string seatName = TenGhe(i);
                if (cb.Checked == true && cb.Enabled == true)
                {
                    seatsTextBox.AppendText(seatName + " ");

                    foreach (Movie movie in movies)
                    {
                        if (movie.TenPhim == movieNameComboBox.Text)
                        {
                            totalMoney += GiaVe(movie.GiaVeChuan, seatName);
                            break;
                        }
                    }
                }
            }
            totalMoneyTextBox.Text = totalMoney.ToString();
        }
            private string TenGhe(int i)
        {
            switch (i)
            {
                case 0: return "A1";
                case 1: return "A2";
                case 2: return "A3";
                case 3: return "A4";
                case 4: return "A5";
                case 5: return "B1";
                case 6: return "B2";
                case 7: return "B3";
                case 8: return "B4";
                case 9: return "B5";
                case 10: return "C1";
                case 11: return "C2";
                case 12: return "C3";
                case 13: return "C4";
                case 14: return "C5";
            }
            return "";
        }

        private string LoaiGhe(string seat)
        {
            if (seat == "A1" || seat == "A5" || seat == "B1" || seat == "B5" || seat == "C1" || seat == "C5") return "Vot";
            else if (seat == "B2" || seat == "B3" || seat == "B4") return "VIP";
            else return "Chuan";
        }
        private int GiaVe(int giaVeChuan, string seat)
        {
            if (seat == "A1" || seat == "A5" || seat == "B1" || seat == "B5" || seat == "C1" || seat == "C5") return giaVeChuan / 4;
            else if (seat == "B2" || seat == "B3" || seat == "B4") return giaVeChuan * 2;
            else return giaVeChuan;
        }
        private void seatPriceInfoButton_MouseHover(object sender, EventArgs e)
        {
            seatPriceInfoTextBox.Visible = true;
        }

        private void seatPriceInfoButton_MouseLeave(object sender, EventArgs e)
        {
            seatPriceInfoTextBox.Visible = false;
        }
        public class CustomComparer : IComparer<Movie>
        {
            public int Compare(Movie A, Movie B)
            {
                return B.DoanhThu.CompareTo(A.DoanhThu);
            }
        }
        public class MovieJSON
        {
            public string TenPhim { get; set; }
            public int SoVeBanRa { get; set; }
            public int SoLuongVeTon { get; set; }
            public double TiLeVeBanRa { get; set; }
            public int DoanhThu { get; set; }
            public int XepHangDoanhThu { get; set; }
            public MovieJSON(Movie movie)
            {
                this.TenPhim = movie.TenPhim;
                this.SoVeBanRa = movie.SoVeBanRa;
                this.SoLuongVeTon = movie.SoLuongVeTon;
                this.TiLeVeBanRa = movie.TiLeVeBanRa;
                this.DoanhThu = movie.DoanhThu;
                this.XepHangDoanhThu = movie.XepHangDoanhThu;
            }
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON file |*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                movies.Sort(new CustomComparer());

                List<MovieJSON> moviesJSON = new List<MovieJSON>();
                int i = 1;
                foreach (Movie movie in movies)
                {
                    movie.TiLeVeBanRa = (double)movie.SoVeBanRa / (double)movie.SoLuongVeTon;
                    movie.TiLeVeBanRa = Math.Round(movie.TiLeVeBanRa, 4);
                    movie.XepHangDoanhThu = i;
                    i++;

                    MovieJSON movieJSON = new MovieJSON(movie);
                    moviesJSON.Add(movieJSON);
                }
                try
                {
                    JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.Latin1Supplement)
                    };
                    string jsonString = JsonSerializer.Serialize(moviesJSON, jsonSerializerOptions);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);
                    MessageBox.Show("Xuất thống kê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (fullNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên người đặt vé!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (seatsTextBox.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 chỗ ngồi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (Movie movie in movies)
                {
                    if (movie.TenPhim == movieNameComboBox.Text)
                    {
                        movie.DoanhThu += int.Parse(totalMoneyTextBox.Text);

                        List<bool> seatStatus = movie.ChoNgoi[int.Parse(roomComboBox.Text)];
                        for (int i = 0; i < 15; i++)
                        {
                            CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + (i + 1).ToString(), true)[0];
                            if (cb.Checked == true && cb.Enabled == true)
                            {
                                movie.SoVeBanRa++;
                                movie.SoLuongVeTon--;

                                seatStatus[i] = true;
                                cb.Enabled = false;
                            }
                        }
                        movie.ChoNgoi[int.Parse(roomComboBox.Text)] = seatStatus;
                        break;
                    }
                }

                MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fullNameTextBox.Clear();
                seatsTextBox.Clear();
                totalMoneyTextBox.Clear();
                roomComboBox_SelectedIndexChanged(sender, new EventArgs());
                return;
            }
        }
    }
}
