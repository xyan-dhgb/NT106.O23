namespace Lab01
{
    partial class Bai031Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.ReadingButton = new System.Windows.Forms.Button();
            this.DeletingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(122, 44);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(278, 38);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = "Đọc số nâng cao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Location = new System.Drawing.Point(208, 136);
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(277, 22);
            this.EnterTextBox.TabIndex = 2;
            // 
            // ReadingButton
            // 
            this.ReadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadingButton.Location = new System.Drawing.Point(183, 197);
            this.ReadingButton.Name = "ReadingButton";
            this.ReadingButton.Size = new System.Drawing.Size(136, 37);
            this.ReadingButton.TabIndex = 3;
            this.ReadingButton.Text = "Đọc";
            this.ReadingButton.UseVisualStyleBackColor = true;
            this.ReadingButton.Click += new System.EventHandler(this.ReadingButton_Click);
            // 
            // DeletingButton
            // 
            this.DeletingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletingButton.Location = new System.Drawing.Point(66, 197);
            this.DeletingButton.Name = "DeletingButton";
            this.DeletingButton.Size = new System.Drawing.Size(96, 37);
            this.DeletingButton.TabIndex = 4;
            this.DeletingButton.Text = "Xóa";
            this.DeletingButton.UseVisualStyleBackColor = true;
            this.DeletingButton.Click += new System.EventHandler(this.DeletingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(338, 197);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 37);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 287);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(86, 25);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Kết quả:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(17, 332);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(468, 22);
            this.ResultTextBox.TabIndex = 7;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bai031Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 474);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeletingButton);
            this.Controls.Add(this.ReadingButton);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TittleLabel);
            this.Name = "Bai031Form";
            this.Text = "Lab01-Bai03.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.Button ReadingButton;
        private System.Windows.Forms.Button DeletingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}