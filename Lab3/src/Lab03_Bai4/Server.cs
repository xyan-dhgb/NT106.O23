using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using static System.Windows.Forms.AxHost;
using System.Threading;

namespace Lab_3___Bài_4
{
    public partial class Server : Form
    {
        public Server()
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

        volatile List<Movie> movies;

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
                        movie.SoLuongVeTon = 15 * movie.PhongChieu.Count;
                        foreach (int phong in movie.PhongChieu)
                        {
                            List<bool> list = Enumerable.Repeat(false, 15).ToList<bool>();
                            movie.ChoNgoi.Add(phong, list);
                        }
                        messageRichTextBox.AppendText($"Đã thêm phim {movie.TenPhim}\r\n");
                    }

                    startServerButton.Enabled = true;
                    exportFileButton.Enabled = true;
                    messageRichTextBox.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        TcpListener listener;
        static volatile List<TcpClient> connectedClients = new List<TcpClient>();

        private void startServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                readFileButton.Enabled = false;
                portTextBox.Enabled = false;

                int port = int.Parse(portTextBox.Text);

                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), int.Parse(portTextBox.Text));
                StartServer();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void StartServer()
        {
            try
            {
                listener.Start();
                messageRichTextBox.AppendText("Đã khởi động Server. Đang lắng nghe các kết nối...\r\n");

                #region Luồng chấp nhận kết nối từ Client
                Thread acceptThread = new Thread(AcceptClientThread);
                acceptThread.IsBackground = true;
                acceptThread.Start();
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AcceptClientThread()
        {
            try
            {
                while (true)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();
                    connectedClients.Add(tcpClient);

                    #region Thông báo đã có client kết nối
                    messageRichTextBox.Invoke(new MethodInvoker(delegate
                    {
                        messageRichTextBox.AppendText($"Client {tcpClient.Client.AddressFamily} đã kết nối!\r\n");
                    }));
                    #endregion

                    Thread clientThread = new Thread(() =>
                    {
                        HandleClientThread(tcpClient);
                    });
                    clientThread.IsBackground = true;
                    clientThread.Start();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        private void HandleClientThread(TcpClient tcpClient)
        {
            SendMovieList(tcpClient, movies);

            while (tcpClient.Connected)
            {
                try
                {
                    Stream clientStream = tcpClient.GetStream();
                    byte[] bytes = new byte[1024];
                    int count = clientStream.Read(bytes, 0, bytes.Length);
                    string receivedMessage = Encoding.UTF8.GetString(bytes, 0, count);

                    if (count > 0)
                    {
                        Movie movieInfoChangeFromClient = new Movie();
                        movieInfoChangeFromClient = JsonSerializer.Deserialize<Movie>(receivedMessage);
                        ChangeMoviesInfo(movieInfoChangeFromClient);

                        #region Thông báo đã có client đặt vé
                        messageRichTextBox.Invoke(new MethodInvoker(delegate
                        {
                            messageRichTextBox.AppendText($"Client {tcpClient.Client.AddressFamily} đã đặt vé!\r\n");
                        }));
                        #endregion
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void SendMovieList(TcpClient tcpClient, List<Movie> MovieList)
        {
            string moviesInfoString = JsonSerializer.Serialize(MovieList);
            byte[] bytes = Encoding.UTF8.GetBytes(moviesInfoString);
            Stream stream = tcpClient.GetStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }

        private void SendMoviesInfo(TcpClient tcpClient, Movie movieInfo)
        {
            string moviesInfoString = JsonSerializer.Serialize(movieInfo);
            byte[] bytes = Encoding.UTF8.GetBytes(moviesInfoString);
            Stream stream = tcpClient.GetStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }

        private void ChangeMoviesInfo (Movie movieInfo)
        {
            foreach (Movie movie in movies)
            {
                if (movie.TenPhim == movieInfo.TenPhim)
                {
                    movie.Clone(movieInfo);
                    break;
                }
            }

            foreach (TcpClient client in connectedClients)
            {
                SendMoviesInfo(client, movieInfo);
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

        public class CustomComparer : IComparer<Movie>
        {
            public int Compare(Movie A, Movie B)
            {
                return B.DoanhThu.CompareTo(A.DoanhThu);
            }
        }

        private void exportFileButton_Click(object sender, EventArgs e)
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
    }
}
