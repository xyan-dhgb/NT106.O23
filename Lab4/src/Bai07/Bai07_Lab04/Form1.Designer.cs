namespace Lab05Bai4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ideaButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.pageSizecomboBox = new System.Windows.Forms.ComboBox();
            this.pagecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDish = new System.Windows.Forms.Button();
            this.whatToEatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 132);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 461);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // ideaButton
            // 
            this.ideaButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ideaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideaButton.Location = new System.Drawing.Point(83, 98);
            this.ideaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ideaButton.Name = "ideaButton";
            this.ideaButton.Size = new System.Drawing.Size(155, 34);
            this.ideaButton.TabIndex = 18;
            this.ideaButton.Text = "Tôi đóng góp";
            this.ideaButton.UseVisualStyleBackColor = false;
            this.ideaButton.Click += new System.EventHandler(this.ideaButton_Click);
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.PowderBlue;
            this.allButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.Location = new System.Drawing.Point(19, 97);
            this.allButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(58, 37);
            this.allButton.TabIndex = 17;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = false;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // pageSizecomboBox
            // 
            this.pageSizecomboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pageSizecomboBox.FormattingEnabled = true;
            this.pageSizecomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.pageSizecomboBox.Location = new System.Drawing.Point(597, 602);
            this.pageSizecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageSizecomboBox.Name = "pageSizecomboBox";
            this.pageSizecomboBox.Size = new System.Drawing.Size(43, 24);
            this.pageSizecomboBox.TabIndex = 16;
            this.pageSizecomboBox.SelectedIndexChanged += new System.EventHandler(this.pageSizecomboBox_SelectedIndexChanged);
            // 
            // pagecomboBox
            // 
            this.pagecomboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pagecomboBox.FormattingEnabled = true;
            this.pagecomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.pagecomboBox.Location = new System.Drawing.Point(436, 603);
            this.pagecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagecomboBox.Name = "pagecomboBox";
            this.pagecomboBox.Size = new System.Drawing.Size(43, 24);
            this.pagecomboBox.TabIndex = 15;
            this.pagecomboBox.SelectedIndexChanged += new System.EventHandler(this.pagecomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(517, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Page Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(380, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Page";
            // 
            // addDish
            // 
            this.addDish.BackColor = System.Drawing.Color.PowderBlue;
            this.addDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDish.Location = new System.Drawing.Point(435, 50);
            this.addDish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDish.Name = "addDish";
            this.addDish.Size = new System.Drawing.Size(205, 43);
            this.addDish.TabIndex = 12;
            this.addDish.Text = "Thêm món ăn";
            this.addDish.UseVisualStyleBackColor = false;
            this.addDish.Click += new System.EventHandler(this.addDish_Click);
            // 
            // whatToEatButton
            // 
            this.whatToEatButton.BackColor = System.Drawing.Color.PowderBlue;
            this.whatToEatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatToEatButton.Location = new System.Drawing.Point(211, 50);
            this.whatToEatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.whatToEatButton.Name = "whatToEatButton";
            this.whatToEatButton.Size = new System.Drawing.Size(218, 43);
            this.whatToEatButton.TabIndex = 11;
            this.whatToEatButton.Text = "Ăn gì giờ?";
            this.whatToEatButton.UseVisualStyleBackColor = false;
            this.whatToEatButton.Click += new System.EventHandler(this.whatToEatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hôm nay ăn gì?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 642);
            this.Controls.Add(this.ideaButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.pageSizecomboBox);
            this.Controls.Add(this.pagecomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDish);
            this.Controls.Add(this.whatToEatButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ideaButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.ComboBox pageSizecomboBox;
        private System.Windows.Forms.ComboBox pagecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addDish;
        private System.Windows.Forms.Button whatToEatButton;
        private System.Windows.Forms.Label label1;
    }
}

