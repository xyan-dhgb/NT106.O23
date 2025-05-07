using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3___Bài_4
{
    public partial class Client : Form
    {
        public Client()
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
            public void Clone(Movie movie)
            {
                this.TenPhim = movie.TenPhim;
                this.GiaVeChuan = movie.GiaVeChuan;
                this.PhongChieu = movie.PhongChieu;
                this.ChoNgoi = movie.ChoNgoi;
                this.SoVeBanRa = movie.SoVeBanRa;
                this.SoLuongVeTon = movie.SoLuongVeTon;
                this.TiLeVeBanRa = movie.TiLeVeBanRa;
                this.DoanhThu = movie.DoanhThu;
            }

        }
        static volatile List<Movie> movies;

        TcpClient client = new TcpClient();

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress iPAddress = IPAddress.Parse(ipAddressTextBox.Text);
                int port = int.Parse(portTextBox.Text);

                Thread clientThread = new Thread(() =>
                {
                    ConnectToServer(iPAddress, port);
                });
                clientThread.IsBackground = true;
                clientThread.Start();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ConnectToServer(IPAddress iPAddress, int port)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);

            client.Connect(iPEndPoint);

            ReceiveMovieList();

            while (client.Connected)
            {
                Stream stream = client.GetStream();
                byte[] bytes = new byte[1024];
                int count = stream.Read(bytes, 0, bytes.Length);
                string receivedMessage = Encoding.UTF8.GetString(bytes, 0, count);

                if (count > 0)
                {
                    Movie movieInfoChangeFromClient = new Movie();
                    movieInfoChangeFromClient = JsonSerializer.Deserialize<Movie>(receivedMessage);
                    ReceiveMovieInfoUpdate(movieInfoChangeFromClient);
                }
            }
        }


        private void ReceiveMovieList()
        {
            try
            {
                Stream stream = client.GetStream();
                string jsonContent = string.Empty;

                while (jsonContent == string.Empty)
                {
                    byte[] bytes = new byte[4096];
                    int count = stream.Read(bytes, 0, bytes.Length);
                    jsonContent += Encoding.UTF8.GetString(bytes, 0, count);
                }

                movies = JsonSerializer.Deserialize<List<Movie>>(jsonContent);

                movieInfoPanel.Invoke(new MethodInvoker(delegate
                {
                    movieInfoPanel.Enabled = true;
                }));
                foreach (Movie movie in movies)
                {
                    movieNameComboBox.Invoke(new MethodInvoker(delegate
                    {
                        movieNameComboBox.Items.Add(movie.TenPhim);
                    }));
                }

            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void ReceiveMovieInfoUpdate(Movie recievedMovieInfo)
        {
            try
            {
                foreach (Movie movie in movies)
                {
                    if (movie.TenPhim == movie.TenPhim)
                    {
                        movie.Clone(recievedMovieInfo);

                        string selectedMovie = string.Empty;
                            movieNameComboBox.Invoke(new MethodInvoker(delegate
                        {
                            selectedMovie = movieNameComboBox.Text;
                        }));
                        if (selectedMovie == movie.TenPhim)
                        {
                            Dictionary<int, List<bool>> seats = movie.ChoNgoi;
                            int selectedRoom = 0;
                            roomComboBox.Invoke(new MethodInvoker(delegate
                            {
                                selectedRoom = int.Parse(roomComboBox.Text);
                            }));
                            List<bool> seatStatus = seats[selectedRoom];
                            for (int i = 0; i < 15; i++)
                            {
                                CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + (i + 1).ToString(), true)[0];
                                if (seatStatus[i] == true)
                                {
                                    cb.Invoke(new MethodInvoker(delegate
                                    {
                                        cb.Enabled = false;
                                        cb.Checked = true;
                                        cb.BackColor = Color.Black;
                                    }));
                                    SeatCheckChanged(new object () { }, new EventArgs());
                                }
                            }
                            
                        }
                        break;
                    }
                }
            } catch
            {

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
                                cb.BackColor = Color.PeachPuff;
                            }
                            else if (LoaiGhe(TenGhe(i)) == "Chuan")
                            {
                                cb.BackColor = Color.White;
                            }
                            else if (LoaiGhe(TenGhe(i)) == "VIP")
                            {
                                cb.BackColor = Color.FromArgb(255, 255, 128);
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

                        SendChangedMovieInfoToServer(movie);

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

        private void SendChangedMovieInfoToServer(Movie movieInfo)
        {
            Stream stream = client.GetStream();

            string moviesInfoString = JsonSerializer.Serialize(movieInfo);
            byte[] bytes = Encoding.UTF8.GetBytes(moviesInfoString);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }
    }
}
