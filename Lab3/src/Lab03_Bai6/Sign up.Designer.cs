namespace Lab_3___Bài_6
{
    partial class Sign_up
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            createButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(10, 50);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 87);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 123);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 3;
            label4.Text = "Re-Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Indigo;
            textBox1.Location = new Point(146, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 34);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Azure;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Indigo;
            textBox2.Location = new Point(146, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 34);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Azure;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.ForeColor = Color.Indigo;
            textBox3.Location = new Point(146, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 34);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // createButton
            // 
            createButton.BackColor = Color.Pink;
            createButton.FlatStyle = FlatStyle.System;
            createButton.Font = new Font("Segoe UI", 12F);
            createButton.ForeColor = Color.Purple;
            createButton.Location = new Point(111, 169);
            createButton.Name = "createButton";
            createButton.Size = new Size(122, 49);
            createButton.TabIndex = 7;
            createButton.Text = "Khởi tạo";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(347, 254);
            Controls.Add(createButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sign_up";
            Text = "Bai6_SignUp";
            Load += Sign_up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button createButton;
    }
}