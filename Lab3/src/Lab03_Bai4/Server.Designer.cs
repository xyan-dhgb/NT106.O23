namespace Lab_3___Bài_4
{
    partial class Server
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
            this.readFileButton = new System.Windows.Forms.Button();
            this.exportFileButton = new System.Windows.Forms.Button();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.startServerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readFileButton
            // 
            this.readFileButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFileButton.Location = new System.Drawing.Point(16, 15);
            this.readFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(201, 49);
            this.readFileButton.TabIndex = 0;
            this.readFileButton.Text = "Đọc thông tin phim";
            this.readFileButton.UseVisualStyleBackColor = false;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // exportFileButton
            // 
            this.exportFileButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportFileButton.Enabled = false;
            this.exportFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileButton.Location = new System.Drawing.Point(16, 479);
            this.exportFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(201, 49);
            this.exportFileButton.TabIndex = 0;
            this.exportFileButton.Text = "Xuất thống kê";
            this.exportFileButton.UseVisualStyleBackColor = false;
            this.exportFileButton.Click += new System.EventHandler(this.exportFileButton_Click);
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.messageRichTextBox.Enabled = false;
            this.messageRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageRichTextBox.Location = new System.Drawing.Point(225, 15);
            this.messageRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(696, 512);
            this.messageRichTextBox.TabIndex = 1;
            this.messageRichTextBox.Text = "";
            // 
            // startServerButton
            // 
            this.startServerButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startServerButton.Enabled = false;
            this.startServerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startServerButton.Location = new System.Drawing.Point(16, 281);
            this.startServerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(201, 49);
            this.startServerButton.TabIndex = 0;
            this.startServerButton.Text = "Khởi động Server";
            this.startServerButton.UseVisualStyleBackColor = false;
            this.startServerButton.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.portTextBox.Location = new System.Drawing.Point(16, 249);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(76, 22);
            this.portTextBox.TabIndex = 5;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageRichTextBox);
            this.Controls.Add(this.exportFileButton);
            this.Controls.Add(this.startServerButton);
            this.Controls.Add(this.readFileButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button exportFileButton;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
    }
}