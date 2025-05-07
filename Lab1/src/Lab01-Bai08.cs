using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class AddButton : Form
    {
        public AddButton()
        {
            InitializeComponent();
        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            string data = EnterFoodTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(data))
            {
                ListViewItem newItem = new ListViewItem(data);
                FoodListView.Items.Add(newItem);
                EnterFoodTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập món ăn phù hợp!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            FoodListView.Clear();
            ResultTextBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (FoodListView.Items.Count > 0)
            {
                // Khởi tạo một đối tượng random
                var randomFood = new Random();
                // Tạo ra một số ngẫu nhiên từ 0 đến FoodListView.Items.Count - 1 (số lượng item trong ListView)
                // và gán nó cho biến index
                int index = randomFood.Next(FoodListView.Items.Count);
                // Lấy item tại vị trí index trong FoodListView.Items
                ListViewItem selectedFood = FoodListView.Items[index];
                ResultTextBox.Text = selectedFood.Text;
            }
        }
    }
}
