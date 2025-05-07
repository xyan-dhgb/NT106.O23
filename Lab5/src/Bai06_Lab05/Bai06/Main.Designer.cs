namespace Bai06
{
    partial class Bai06Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai06Form));
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.afterLoginPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sendEmailFeatureButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.catpictureBox = new System.Windows.Forms.PictureBox();
            this.smtpPortTextBox = new System.Windows.Forms.TextBox();
            this.smtpTextBox = new System.Windows.Forms.TextBox();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.smtpPortLabel = new System.Windows.Forms.Label();
            this.imapPortTextBox = new System.Windows.Forms.TextBox();
            this.imapTextBox = new System.Windows.Forms.TextBox();
            this.ImapLabel = new System.Windows.Forms.Label();
            this.imapPortLabel = new System.Windows.Forms.Label();
            this.emailListView = new System.Windows.Forms.ListView();
            this.from_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datetime_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginGroupBox.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.afterLoginPanel.SuspendLayout();
            this.settingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.stopButton);
            this.loginGroupBox.Controls.Add(this.loadButton);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.Controls.Add(this.accountTextBox);
            this.loginGroupBox.Controls.Add(this.loginPanel);
            this.loginGroupBox.Controls.Add(this.label2);
            this.loginGroupBox.Controls.Add(this.label1);
            this.loginGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGroupBox.Location = new System.Drawing.Point(12, 29);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(561, 179);
            this.loginGroupBox.TabIndex = 1;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Đăng nhập";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(476, 24);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(77, 63);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(393, 24);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(77, 63);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Load mail";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(109, 57);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(278, 30);
            this.passwordTextBox.TabIndex = 7;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(109, 24);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(278, 30);
            this.accountTextBox.TabIndex = 6;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.afterLoginPanel);
            this.loginPanel.Controls.Add(this.exitButton);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(6, 91);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(549, 62);
            this.loginPanel.TabIndex = 5;
            // 
            // afterLoginPanel
            // 
            this.afterLoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.afterLoginPanel.Controls.Add(this.logoutButton);
            this.afterLoginPanel.Controls.Add(this.refreshButton);
            this.afterLoginPanel.Controls.Add(this.sendEmailFeatureButton);
            this.afterLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.afterLoginPanel.Name = "afterLoginPanel";
            this.afterLoginPanel.Size = new System.Drawing.Size(549, 62);
            this.afterLoginPanel.TabIndex = 3;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Plum;
            this.logoutButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.Location = new System.Drawing.Point(387, 18);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(149, 29);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightSalmon;
            this.refreshButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Location = new System.Drawing.Point(210, 18);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(153, 29);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // sendEmailFeatureButton
            // 
            this.sendEmailFeatureButton.BackColor = System.Drawing.Color.PaleGreen;
            this.sendEmailFeatureButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailFeatureButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendEmailFeatureButton.Location = new System.Drawing.Point(30, 18);
            this.sendEmailFeatureButton.Name = "sendEmailFeatureButton";
            this.sendEmailFeatureButton.Size = new System.Drawing.Size(156, 29);
            this.sendEmailFeatureButton.TabIndex = 3;
            this.sendEmailFeatureButton.Text = "Send email";
            this.sendEmailFeatureButton.UseVisualStyleBackColor = false;
            this.sendEmailFeatureButton.Click += new System.EventHandler(this.sendEmailFeatureButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(409, 15);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 34);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(6, 15);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(397, 34);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật  khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Controls.Add(this.catpictureBox);
            this.settingGroupBox.Controls.Add(this.smtpPortTextBox);
            this.settingGroupBox.Controls.Add(this.smtpTextBox);
            this.settingGroupBox.Controls.Add(this.smtpLabel);
            this.settingGroupBox.Controls.Add(this.smtpPortLabel);
            this.settingGroupBox.Controls.Add(this.imapPortTextBox);
            this.settingGroupBox.Controls.Add(this.imapTextBox);
            this.settingGroupBox.Controls.Add(this.ImapLabel);
            this.settingGroupBox.Controls.Add(this.imapPortLabel);
            this.settingGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingGroupBox.Location = new System.Drawing.Point(579, 29);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(682, 179);
            this.settingGroupBox.TabIndex = 2;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Cài đặt";
            // 
            // catpictureBox
            // 
            this.catpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.catpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("catpictureBox.Image")));
            this.catpictureBox.Location = new System.Drawing.Point(12, 90);
            this.catpictureBox.Name = "catpictureBox";
            this.catpictureBox.Size = new System.Drawing.Size(658, 63);
            this.catpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catpictureBox.TabIndex = 16;
            this.catpictureBox.TabStop = false;
            // 
            // smtpPortTextBox
            // 
            this.smtpPortTextBox.Location = new System.Drawing.Point(387, 52);
            this.smtpPortTextBox.Name = "smtpPortTextBox";
            this.smtpPortTextBox.ReadOnly = true;
            this.smtpPortTextBox.Size = new System.Drawing.Size(283, 30);
            this.smtpPortTextBox.TabIndex = 15;
            this.smtpPortTextBox.Text = "995";
            // 
            // smtpTextBox
            // 
            this.smtpTextBox.Location = new System.Drawing.Point(387, 24);
            this.smtpTextBox.Name = "smtpTextBox";
            this.smtpTextBox.ReadOnly = true;
            this.smtpTextBox.Size = new System.Drawing.Size(283, 30);
            this.smtpTextBox.TabIndex = 14;
            this.smtpTextBox.Text = "smtp.gmail.com";
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Location = new System.Drawing.Point(320, 27);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(61, 22);
            this.smtpLabel.TabIndex = 12;
            this.smtpLabel.Text = "SMTP";
            // 
            // smtpPortLabel
            // 
            this.smtpPortLabel.AutoSize = true;
            this.smtpPortLabel.Location = new System.Drawing.Point(320, 55);
            this.smtpPortLabel.Name = "smtpPortLabel";
            this.smtpPortLabel.Size = new System.Drawing.Size(43, 22);
            this.smtpPortLabel.TabIndex = 13;
            this.smtpPortLabel.Text = "Port";
            // 
            // imapPortTextBox
            // 
            this.imapPortTextBox.Location = new System.Drawing.Point(72, 52);
            this.imapPortTextBox.Name = "imapPortTextBox";
            this.imapPortTextBox.ReadOnly = true;
            this.imapPortTextBox.Size = new System.Drawing.Size(234, 30);
            this.imapPortTextBox.TabIndex = 11;
            this.imapPortTextBox.Text = "993";
            // 
            // imapTextBox
            // 
            this.imapTextBox.Location = new System.Drawing.Point(72, 24);
            this.imapTextBox.Name = "imapTextBox";
            this.imapTextBox.ReadOnly = true;
            this.imapTextBox.Size = new System.Drawing.Size(234, 30);
            this.imapTextBox.TabIndex = 10;
            this.imapTextBox.Text = "imap.gmail.com";
            // 
            // ImapLabel
            // 
            this.ImapLabel.AutoSize = true;
            this.ImapLabel.Location = new System.Drawing.Point(9, 28);
            this.ImapLabel.Name = "ImapLabel";
            this.ImapLabel.Size = new System.Drawing.Size(58, 22);
            this.ImapLabel.TabIndex = 8;
            this.ImapLabel.Text = "IMAP";
            // 
            // imapPortLabel
            // 
            this.imapPortLabel.AutoSize = true;
            this.imapPortLabel.Location = new System.Drawing.Point(9, 56);
            this.imapPortLabel.Name = "imapPortLabel";
            this.imapPortLabel.Size = new System.Drawing.Size(43, 22);
            this.imapPortLabel.TabIndex = 9;
            this.imapPortLabel.Text = "Port";
            // 
            // emailListView
            // 
            this.emailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.from_column,
            this.subject_column,
            this.datetime_column});
            this.emailListView.HideSelection = false;
            this.emailListView.Location = new System.Drawing.Point(12, 231);
            this.emailListView.Name = "emailListView";
            this.emailListView.Size = new System.Drawing.Size(1249, 466);
            this.emailListView.TabIndex = 3;
            this.emailListView.UseCompatibleStateImageBehavior = false;
            this.emailListView.SelectedIndexChanged += new System.EventHandler(this.EmailListView_SelectedIndexChanged);
            // 
            // from_column
            // 
            this.from_column.Text = "From";
            // 
            // subject_column
            // 
            this.subject_column.Text = "Subject";
            // 
            // datetime_column
            // 
            this.datetime_column.Text = "Datetime";
            // 
            // Bai06Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 709);
            this.Controls.Add(this.emailListView);
            this.Controls.Add(this.settingGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "Bai06Form";
            this.Text = "Bai06_Lab05";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.afterLoginPanel.ResumeLayout(false);
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel afterLoginPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button sendEmailFeatureButton;
        private System.Windows.Forms.TextBox smtpPortTextBox;
        private System.Windows.Forms.TextBox smtpTextBox;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.Label smtpPortLabel;
        private System.Windows.Forms.TextBox imapPortTextBox;
        private System.Windows.Forms.TextBox imapTextBox;
        private System.Windows.Forms.Label ImapLabel;
        private System.Windows.Forms.Label imapPortLabel;
        private System.Windows.Forms.PictureBox catpictureBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListView emailListView;
        private System.Windows.Forms.ColumnHeader from_column;
        private System.Windows.Forms.ColumnHeader subject_column;
        private System.Windows.Forms.ColumnHeader datetime_column;
    }
}

