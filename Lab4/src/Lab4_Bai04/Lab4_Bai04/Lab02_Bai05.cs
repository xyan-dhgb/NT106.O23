﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Windows.Forms.AxHost;

namespace Lab2
{
    public partial class form2 : UserControl
    {
        public form2()
        {
            InitializeComponent();
        }

        public class Item
        {
            public string ten;
            public long giavechuan;
            public List<int> phongchieu;
        }

        List<Item> items = new List<Item>();
        
        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("input5.json"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file input5.json");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string json = sr.ReadToEnd();
            items = JsonConvert.DeserializeObject<List<Item>>(json);

            List<int> tmp = new List<int>();
            int so_phim = 0, so_phong_chieu;

            foreach (Item item in items)
            {
                try
                {
                    movieCb.Items.Add(item.ten);
                    tmp.Add(item.phongchieu.Count);
                    so_phim++;
                }
                catch
                {
                    MessageBox.Show("Kiểm tra định dạng file JSON!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            so_phong_chieu = tmp.Max();
            int n = CantorPairing(so_phim, so_phong_chieu) + 1;

            for (int i = 0; i < n; i++)
            {
                checkedValues.Add(new List<string>());
                checkedValuesIndex.Add(new List<int>());
            }
        }

        static List<List<string>> checkedValues = new List<List<string>>();
        static List<List<int>> checkedValuesIndex = new List<List<int>>();
        static long[] resStoring = new long[1001];

        private void movieCb_SelectedValueChanged(object sender, EventArgs e)
        {
            screenCb.Items.Clear();

            Item movie = new Item();
            foreach (Item item in items)
            {
                if (item.ten == movieCb.Text) { movie = item; break; }
            }

            for (int i = 0; i < movie.phongchieu.Count; i++)
            {
                movie.phongchieu.Sort();
                screenCb.Items.Add(string.Format("Phòng chiếu {0}", movie.phongchieu[i]));
            }

            label3.Visible = false;
            checkedListBox.Visible = false;
        }

        private void screenCb_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] str = new string[]
            {
                "A1", "B1", "C1",
                "A2", "B2", "C2",
                "A3", "B3", "C3",
                "A4", "B4", "C4",
                "A5", "B5", "C5"
            };
            bool state = false;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
                checkedListBox.Items[i] = str[i];
            }

            int idx = CantorPairing(movieCb.SelectedIndex, screenCb.SelectedIndex);

            foreach (var index in checkedValuesIndex[idx])
            {
                checkedListBox.Items[index] = "sold";
                checkedListBox.SetItemCheckState(index, CheckState.Indeterminate);
            }

            label3.Visible = true;
            checkedListBox.Visible = true;
        }

        public static int CantorPairing(int a, int b)
        {
            int res = (((a + b) * (a + b + 1)) / 2) + b;
            return res;
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            Item movie = new Item();
            foreach (Item item in items)
            {
                if (item.ten == movieCb.Text) { movie = item; break; }
            }

            long gia_ve = movie.giavechuan;
            int idx = CantorPairing(movieCb.SelectedIndex, screenCb.SelectedIndex);

            foreach (var item in checkedListBox.CheckedItems)
            {
                if (item.ToString() != "sold")
                {
                    checkedValues[idx].Add(item.ToString());
                    checkedValuesIndex[idx].Add(checkedListBox.Items.IndexOf(item));
                }
            }

            int so_ve_vot = 0, so_ve_thuong = 0, so_ve_vip = 0;
            string picked = "";
            foreach (var item in checkedValues[idx])
            {
                if (item == "A1" || item == "A5" || item == "C1" || item == "C5")
                {
                    picked += item + ", ";
                    so_ve_vot++;
                }
                else if (item == "B2" || item == "B3" || item == "B4")
                {
                    picked += item + ", ";
                    so_ve_vip++;
                }
                else
                {
                    picked += item + ", ";
                    so_ve_thuong++;
                }
            }

            long res = (so_ve_vot * gia_ve / 4) + (so_ve_thuong * gia_ve) + (so_ve_vip * gia_ve * 2);
            resStoring[idx] = res;

            if (res == 0)
            {
                MessageBox.Show(
                    "Đảm bảo chọn đầy đủ phim, phòng chiếu và ít nhất 1 ghế!",
                    "Đặt vé không thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                return;
            }

            MessageBox.Show(string.Format(
                "Tên phim: {0}\n" +
                "{1}\n" +
                "Những ghế đã chọn là: {2}\n" +
                "Số tiền cần phải thanh toán: {3}\n",
                movieCb.Text, screenCb.Text, picked, res),
                "Đặt vé thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

            foreach (var index in checkedValuesIndex[idx])
            {
                checkedListBox.Items[index] = "sold";
                checkedListBox.SetItemCheckState(index, CheckState.Indeterminate);
            }
        }

        class OutputItem
        {
            public string ten;
            public int sovebanra;
            public int soveton;
            public string tilevebanra;
            public long doanhthu;
            public int xephangdoanhthu;
        }
        private void writeBtn_Click(object sender, EventArgs e)
        {
            List<OutputItem> data = new List<OutputItem>();

            int i = 0;
            foreach (Item item in items)
            {
                OutputItem outputItem = new OutputItem();
                data.Add(outputItem);

                int sovebanra = 0;
                long doanhthu = 0;

                for (int j = 0; j < item.phongchieu.Count; j++)
                {
                    int idx = CantorPairing(i, j);
                    sovebanra += checkedValuesIndex[idx].Count;
                    doanhthu += resStoring[idx];
                }

                int soveton = 15 * item.phongchieu.Count - sovebanra;

                outputItem.ten = item.ten;
                outputItem.sovebanra = sovebanra;
                outputItem.soveton = soveton;
                outputItem.tilevebanra = string.Format("{0:0.00} %", sovebanra * 100.0 / (sovebanra + soveton));
                outputItem.doanhthu = doanhthu;
                i++;
            }

            List<long> ranking = new List<long>();

            foreach (OutputItem outputItem in data)
            {
                ranking.Add(outputItem.doanhthu);
            }

            ranking.Sort();
            ranking.Reverse();

            for (int k = 0; k < ranking.Count; k++)
            {
                foreach (OutputItem outputItem in data)
                {
                    if (outputItem.doanhthu == ranking[k])
                    {
                        outputItem.xephangdoanhthu = k + 1;
                        break;
                    }
                }
            }

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("output5.json"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file output5.json");
                return;
            }

            try { File.WriteAllText(ofd.FileName, string.Empty); }
            catch { MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
            MessageBox.Show("Đã ghi thành công vào output5.json");

            fs.Close();
        }
    }
}
