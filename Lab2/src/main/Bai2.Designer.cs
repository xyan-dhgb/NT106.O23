namespace _22520101_BaoCaoLab02
{
    partial class Bai02Form
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
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.ContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.LineCountTextBox = new System.Windows.Forms.TextBox();
            this.LineCountLabel = new System.Windows.Forms.Label();
            this.WordCountTextBox = new System.Windows.Forms.TextBox();
            this.WordCountLabel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CharacterCountTextBox = new System.Windows.Forms.TextBox();
            this.CharacterCountLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(261, 63);
            this.TittleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(531, 38);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = "Bài 02 – Đọc thông tin một file .txt";
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadFileButton.Location = new System.Drawing.Point(25, 141);
            this.ReadFileButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(609, 67);
            this.ReadFileButton.TabIndex = 1;
            this.ReadFileButton.Text = "Read from File";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // ContentRichTextBox
            // 
            this.ContentRichTextBox.Location = new System.Drawing.Point(666, 141);
            this.ContentRichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ContentRichTextBox.Name = "ContentRichTextBox";
            this.ContentRichTextBox.Size = new System.Drawing.Size(392, 538);
            this.ContentRichTextBox.TabIndex = 2;
            this.ContentRichTextBox.Text = "";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(20, 252);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "File name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(179, 243);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(455, 30);
            this.NameTextBox.TabIndex = 4;
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeTextBox.Location = new System.Drawing.Point(179, 301);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(455, 30);
            this.SizeTextBox.TabIndex = 6;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(20, 310);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(51, 25);
            this.SizeLabel.TabIndex = 5;
            this.SizeLabel.Text = "Size";
            // 
            // URLTextBox
            // 
            this.URLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox.Location = new System.Drawing.Point(179, 364);
            this.URLTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.ReadOnly = true;
            this.URLTextBox.Size = new System.Drawing.Size(455, 30);
            this.URLTextBox.TabIndex = 8;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel.Location = new System.Drawing.Point(20, 370);
            this.URLLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(50, 25);
            this.URLLabel.TabIndex = 7;
            this.URLLabel.Text = "URL";
            // 
            // LineCountTextBox
            // 
            this.LineCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineCountTextBox.Location = new System.Drawing.Point(179, 426);
            this.LineCountTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LineCountTextBox.Name = "LineCountTextBox";
            this.LineCountTextBox.ReadOnly = true;
            this.LineCountTextBox.Size = new System.Drawing.Size(455, 30);
            this.LineCountTextBox.TabIndex = 10;
            // 
            // LineCountLabel
            // 
            this.LineCountLabel.AutoSize = true;
            this.LineCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineCountLabel.Location = new System.Drawing.Point(20, 435);
            this.LineCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LineCountLabel.Name = "LineCountLabel";
            this.LineCountLabel.Size = new System.Drawing.Size(102, 25);
            this.LineCountLabel.TabIndex = 9;
            this.LineCountLabel.Text = "Line count";
            // 
            // WordCountTextBox
            // 
            this.WordCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCountTextBox.Location = new System.Drawing.Point(179, 492);
            this.WordCountTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.WordCountTextBox.Name = "WordCountTextBox";
            this.WordCountTextBox.ReadOnly = true;
            this.WordCountTextBox.Size = new System.Drawing.Size(455, 30);
            this.WordCountTextBox.TabIndex = 12;
            // 
            // WordCountLabel
            // 
            this.WordCountLabel.AutoSize = true;
            this.WordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCountLabel.Location = new System.Drawing.Point(14, 501);
            this.WordCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WordCountLabel.Name = "WordCountLabel";
            this.WordCountLabel.Size = new System.Drawing.Size(123, 25);
            this.WordCountLabel.TabIndex = 11;
            this.WordCountLabel.Text = "Words count";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(250, 738);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(455, 34);
            this.textBox6.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 745);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Character count";
            // 
            // CharacterCountTextBox
            // 
            this.CharacterCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterCountTextBox.Location = new System.Drawing.Point(179, 556);
            this.CharacterCountTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CharacterCountTextBox.Name = "CharacterCountTextBox";
            this.CharacterCountTextBox.ReadOnly = true;
            this.CharacterCountTextBox.Size = new System.Drawing.Size(455, 30);
            this.CharacterCountTextBox.TabIndex = 16;
            // 
            // CharacterCountLabel
            // 
            this.CharacterCountLabel.AutoSize = true;
            this.CharacterCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterCountLabel.Location = new System.Drawing.Point(14, 565);
            this.CharacterCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CharacterCountLabel.Name = "CharacterCountLabel";
            this.CharacterCountLabel.Size = new System.Drawing.Size(151, 25);
            this.CharacterCountLabel.TabIndex = 15;
            this.CharacterCountLabel.Text = "Character count";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(25, 612);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(609, 67);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Bai02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 693);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CharacterCountTextBox);
            this.Controls.Add(this.CharacterCountLabel);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WordCountTextBox);
            this.Controls.Add(this.WordCountLabel);
            this.Controls.Add(this.LineCountTextBox);
            this.Controls.Add(this.LineCountLabel);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ContentRichTextBox);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.TittleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bai02Form";
            this.Text = "Lab02-Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.RichTextBox ContentRichTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox LineCountTextBox;
        private System.Windows.Forms.Label LineCountLabel;
        private System.Windows.Forms.TextBox WordCountTextBox;
        private System.Windows.Forms.Label WordCountLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CharacterCountTextBox;
        private System.Windows.Forms.Label CharacterCountLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}