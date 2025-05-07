namespace Lab_3___Bài_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            textBox2 = new TextBox();
            signinButton = new Button();
            createNewButton = new Button();
            deleteButton = new Button();
            serverButton = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.ButtonHighlight;
            nameTextBox.Font = new Font("Calibri", 10F, FontStyle.Bold);
            nameTextBox.ForeColor = Color.Indigo;
            nameTextBox.Location = new Point(136, 74);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(206, 28);
            nameTextBox.TabIndex = 3;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBox2.ForeColor = Color.Indigo;
            textBox2.Location = new Point(136, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 28);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // signinButton
            // 
            signinButton.BackColor = SystemColors.ButtonHighlight;
            signinButton.FlatStyle = FlatStyle.System;
            signinButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            signinButton.ForeColor = SystemColors.ActiveCaptionText;
            signinButton.Location = new Point(26, 150);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(315, 38);
            signinButton.TabIndex = 5;
            signinButton.Text = "Đăng nhập";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // createNewButton
            // 
            createNewButton.BackColor = SystemColors.ButtonHighlight;
            createNewButton.FlatStyle = FlatStyle.System;
            createNewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            createNewButton.ForeColor = SystemColors.ActiveCaptionText;
            createNewButton.Location = new Point(173, 195);
            createNewButton.Name = "createNewButton";
            createNewButton.Size = new Size(169, 62);
            createNewButton.TabIndex = 6;
            createNewButton.Text = "Tạo tài khoản mới";
            createNewButton.UseVisualStyleBackColor = false;
            createNewButton.Click += createNewButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ButtonHighlight;
            deleteButton.FlatStyle = FlatStyle.System;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deleteButton.ForeColor = SystemColors.ActiveCaptionText;
            deleteButton.Location = new Point(26, 195);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 62);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Xóa bộ nhớ ";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // serverButton
            // 
            serverButton.BackColor = SystemColors.ButtonHighlight;
            serverButton.FlatStyle = FlatStyle.System;
            serverButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            serverButton.ForeColor = SystemColors.ActiveCaptionText;
            serverButton.Location = new Point(27, 263);
            serverButton.Name = "serverButton";
            serverButton.Size = new Size(315, 38);
            serverButton.TabIndex = 8;
            serverButton.Text = "Máy chủ";
            serverButton.UseVisualStyleBackColor = false;
            serverButton.Click += serverButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(108, 24);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 114);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(369, 361);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(serverButton);
            Controls.Add(deleteButton);
            Controls.Add(createNewButton);
            Controls.Add(signinButton);
            Controls.Add(textBox2);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Bai6_ChatRoom";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameTextBox;
        private TextBox textBox2;
        private Button signinButton;
        private Button createNewButton;
        private Button deleteButton;
        private Button serverButton;
        private Label label2;
        private Label label4;
    }
}
