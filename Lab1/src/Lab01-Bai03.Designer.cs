namespace Lab01
{
    partial class Bai03Form
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
            this.InputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ReadingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeletingButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.Black;
            this.InputLabel.Location = new System.Drawing.Point(12, 134);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(279, 22);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đọc số";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(312, 134);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(191, 22);
            this.InputTextBox.TabIndex = 2;
            // 
            // ReadingButton
            // 
            this.ReadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadingButton.ForeColor = System.Drawing.Color.Black;
            this.ReadingButton.Location = new System.Drawing.Point(12, 193);
            this.ReadingButton.Name = "ReadingButton";
            this.ReadingButton.Size = new System.Drawing.Size(279, 38);
            this.ReadingButton.TabIndex = 3;
            this.ReadingButton.Text = "Đọc";
            this.ReadingButton.UseVisualStyleBackColor = true;
            this.ReadingButton.Click += new System.EventHandler(this.ReadingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(414, 193);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeletingButton
            // 
            this.DeletingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletingButton.ForeColor = System.Drawing.Color.Black;
            this.DeletingButton.Location = new System.Drawing.Point(312, 193);
            this.DeletingButton.Name = "DeletingButton";
            this.DeletingButton.Size = new System.Drawing.Size(75, 38);
            this.DeletingButton.TabIndex = 5;
            this.DeletingButton.Text = "Xóa";
            this.DeletingButton.UseVisualStyleBackColor = true;
            this.DeletingButton.Click += new System.EventHandler(this.DeletingButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultLabel.Location = new System.Drawing.Point(12, 264);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(72, 22);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Kết quả";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 302);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(477, 22);
            this.ResultTextBox.TabIndex = 7;
            // 
            // Bai03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DeletingButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReadingButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputLabel);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Bai03Form";
            this.Text = "Lab01-Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ReadingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeletingButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}