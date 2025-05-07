namespace Lab01
{
    partial class ThirdScreen
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
            this.TittleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.ChooseComboBox = new System.Windows.Forms.ComboBox();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.SeatPanel = new System.Windows.Forms.Panel();
            this.C5 = new System.Windows.Forms.CheckBox();
            this.B5 = new System.Windows.Forms.CheckBox();
            this.B4 = new System.Windows.Forms.CheckBox();
            this.B3 = new System.Windows.Forms.CheckBox();
            this.B2 = new System.Windows.Forms.CheckBox();
            this.B1 = new System.Windows.Forms.CheckBox();
            this.A2 = new System.Windows.Forms.CheckBox();
            this.A3 = new System.Windows.Forms.CheckBox();
            this.A4 = new System.Windows.Forms.CheckBox();
            this.A5 = new System.Windows.Forms.CheckBox();
            this.A1 = new System.Windows.Forms.CheckBox();
            this.BuyingButton = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.CheckBox();
            this.C4 = new System.Windows.Forms.CheckBox();
            this.C3 = new System.Windows.Forms.CheckBox();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.SeatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(186, 33);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(109, 38);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = "Rạp 3";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(13, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(111, 26);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Họ và tên:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(149, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(327, 27);
            this.NameTextBox.TabIndex = 2;
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseLabel.Location = new System.Drawing.Point(12, 154);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(204, 26);
            this.ChooseLabel.TabIndex = 3;
            this.ChooseLabel.Text = "Vui lòng chọn phim:";
            // 
            // ChooseComboBox
            // 
            this.ChooseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseComboBox.FormattingEnabled = true;
            this.ChooseComboBox.Items.AddRange(new object[] {
            "Đào, phở và piano",
            "Mai",
            "Tarot"});
            this.ChooseComboBox.Location = new System.Drawing.Point(239, 152);
            this.ChooseComboBox.Name = "ChooseComboBox";
            this.ChooseComboBox.Size = new System.Drawing.Size(237, 28);
            this.ChooseComboBox.TabIndex = 4;
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatLabel.Location = new System.Drawing.Point(13, 216);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(158, 26);
            this.SeatLabel.TabIndex = 5;
            this.SeatLabel.Text = "Chọn chỗ ngồi:";
            // 
            // SeatPanel
            // 
            this.SeatPanel.Controls.Add(this.C5);
            this.SeatPanel.Controls.Add(this.C1);
            this.SeatPanel.Controls.Add(this.C2);
            this.SeatPanel.Controls.Add(this.B5);
            this.SeatPanel.Controls.Add(this.C4);
            this.SeatPanel.Controls.Add(this.B4);
            this.SeatPanel.Controls.Add(this.C3);
            this.SeatPanel.Controls.Add(this.B3);
            this.SeatPanel.Controls.Add(this.B2);
            this.SeatPanel.Controls.Add(this.B1);
            this.SeatPanel.Controls.Add(this.A2);
            this.SeatPanel.Controls.Add(this.A3);
            this.SeatPanel.Controls.Add(this.A4);
            this.SeatPanel.Controls.Add(this.A5);
            this.SeatPanel.Controls.Add(this.A1);
            this.SeatPanel.Location = new System.Drawing.Point(18, 266);
            this.SeatPanel.Name = "SeatPanel";
            this.SeatPanel.Size = new System.Drawing.Size(458, 149);
            this.SeatPanel.TabIndex = 6;
            // 
            // C5
            // 
            this.C5.AutoSize = true;
            this.C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C5.Location = new System.Drawing.Point(326, 95);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(60, 29);
            this.C5.TabIndex = 14;
            this.C5.Text = "C5";
            this.C5.UseVisualStyleBackColor = true;
            // 
            // B5
            // 
            this.B5.AutoSize = true;
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(326, 60);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(58, 29);
            this.B5.TabIndex = 9;
            this.B5.Text = "B5";
            this.B5.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            this.B4.AutoSize = true;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(261, 60);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(58, 29);
            this.B4.TabIndex = 8;
            this.B4.Text = "B4";
            this.B4.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.AutoSize = true;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(196, 60);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(58, 29);
            this.B3.TabIndex = 7;
            this.B3.Text = "B3";
            this.B3.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.AutoSize = true;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(131, 60);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(58, 29);
            this.B2.TabIndex = 6;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(66, 60);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(58, 29);
            this.B1.TabIndex = 5;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            this.A2.AutoSize = true;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(131, 25);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(59, 29);
            this.A2.TabIndex = 4;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = true;
            // 
            // A3
            // 
            this.A3.AutoSize = true;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(196, 25);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(59, 29);
            this.A3.TabIndex = 3;
            this.A3.Text = "A3";
            this.A3.UseVisualStyleBackColor = true;
            // 
            // A4
            // 
            this.A4.AutoSize = true;
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.Location = new System.Drawing.Point(261, 25);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(59, 29);
            this.A4.TabIndex = 2;
            this.A4.Text = "A4";
            this.A4.UseVisualStyleBackColor = true;
            // 
            // A5
            // 
            this.A5.AutoSize = true;
            this.A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5.Location = new System.Drawing.Point(326, 25);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(59, 29);
            this.A5.TabIndex = 1;
            this.A5.Text = "A5";
            this.A5.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(66, 25);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(59, 29);
            this.A1.TabIndex = 0;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = true;
            // 
            // BuyingButton
            // 
            this.BuyingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyingButton.Location = new System.Drawing.Point(159, 436);
            this.BuyingButton.Name = "BuyingButton";
            this.BuyingButton.Size = new System.Drawing.Size(170, 50);
            this.BuyingButton.TabIndex = 7;
            this.BuyingButton.Text = "Mua vé";
            this.BuyingButton.UseVisualStyleBackColor = true;
            this.BuyingButton.Click += new System.EventHandler(this.BuyingButton_Click);
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(129, 95);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(60, 29);
            this.C2.TabIndex = 10;
            this.C2.Text = "C2";
            this.C2.UseVisualStyleBackColor = true;
            // 
            // C4
            // 
            this.C4.AutoSize = true;
            this.C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C4.Location = new System.Drawing.Point(261, 95);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(60, 29);
            this.C4.TabIndex = 11;
            this.C4.Text = "C4";
            this.C4.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(196, 95);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(60, 29);
            this.C3.TabIndex = 12;
            this.C3.Text = "C3";
            this.C3.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(66, 95);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(60, 29);
            this.C1.TabIndex = 13;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = true;
            // 
            // ThirdScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 549);
            this.Controls.Add(this.BuyingButton);
            this.Controls.Add(this.SeatPanel);
            this.Controls.Add(this.SeatLabel);
            this.Controls.Add(this.ChooseComboBox);
            this.Controls.Add(this.ChooseLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TittleLabel);
            this.Name = "ThirdScreen";
            this.Text = "Form1";
            this.SeatPanel.ResumeLayout(false);
            this.SeatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.ComboBox ChooseComboBox;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.Panel SeatPanel;
        private System.Windows.Forms.Button BuyingButton;
        private System.Windows.Forms.CheckBox A1;
        private System.Windows.Forms.CheckBox A2;
        private System.Windows.Forms.CheckBox A3;
        private System.Windows.Forms.CheckBox A4;
        private System.Windows.Forms.CheckBox A5;
        private System.Windows.Forms.CheckBox C5;
        private System.Windows.Forms.CheckBox B5;
        private System.Windows.Forms.CheckBox B4;
        private System.Windows.Forms.CheckBox B3;
        private System.Windows.Forms.CheckBox B2;
        private System.Windows.Forms.CheckBox B1;
        private System.Windows.Forms.CheckBox C2;
        private System.Windows.Forms.CheckBox C4;
        private System.Windows.Forms.CheckBox C3;
        private System.Windows.Forms.CheckBox C1;
    }
}