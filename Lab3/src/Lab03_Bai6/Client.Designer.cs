namespace Lab_3___Bài_6
{
    partial class Client
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            textBox1.ForeColor = Color.Indigo;
            textBox1.Location = new Point(258, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBox2.ForeColor = Color.Indigo;
            textBox2.Location = new Point(31, 72);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(518, 355);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBox3.ForeColor = Color.Indigo;
            textBox3.Location = new Point(29, 432);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(578, 61);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(613, 432);
            button1.Name = "button1";
            button1.Size = new Size(127, 60);
            button1.TabIndex = 3;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonHighlight;
            comboBox1.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            comboBox1.ForeColor = Color.Indigo;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(555, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 29);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBox4.ForeColor = Color.Indigo;
            textBox4.Location = new Point(555, 72);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 355);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(141, 37);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(779, 533);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Client";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Bai6_Client";
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label2;
    }
}