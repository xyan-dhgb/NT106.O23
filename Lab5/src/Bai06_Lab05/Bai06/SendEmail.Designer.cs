namespace Bai06
{
    partial class SendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browsePictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browsePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(113, 52);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(68, 25);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(113, 108);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(37, 25);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(113, 165);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(109, 25);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(113, 225);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(88, 25);
            this.subjectLabel.TabIndex = 3;
            this.subjectLabel.Text = "Subject";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(228, 49);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(378, 34);
            this.fromTextBox.TabIndex = 4;
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(228, 105);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(378, 34);
            this.toTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(228, 162);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(378, 34);
            this.passwordTextBox.TabIndex = 6;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextBox.Location = new System.Drawing.Point(228, 222);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(378, 34);
            this.subjectTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contentRichTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 330);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(18, 33);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(603, 274);
            this.contentRichTextBox.TabIndex = 0;
            this.contentRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LightGreen;
            this.sendButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendButton.Location = new System.Drawing.Point(36, 679);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(486, 45);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(36, 627);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(504, 34);
            this.filePathTextBox.TabIndex = 10;
            // 
            // browsePictureBox
            // 
            this.browsePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.browsePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("browsePictureBox.Image")));
            this.browsePictureBox.Location = new System.Drawing.Point(546, 627);
            this.browsePictureBox.Name = "browsePictureBox";
            this.browsePictureBox.Size = new System.Drawing.Size(60, 34);
            this.browsePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.browsePictureBox.TabIndex = 11;
            this.browsePictureBox.TabStop = false;
            this.browsePictureBox.Click += new System.EventHandler(this.browsePictureBox_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Crimson;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(537, 679);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(141, 45);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(618, 627);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(60, 34);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePictureBox.TabIndex = 13;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 736);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.browsePictureBox);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Name = "SendEmail";
            this.Text = "SendEmail";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browsePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.PictureBox browsePictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox deletePictureBox;
    }
}